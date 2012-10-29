using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using CryptographyTemplate.Utils;
using System.Security.Cryptography;
using CryptographyTemplate.Extensions;
using System.Text.RegularExpressions;

namespace CryptographyTemplate
{
    public interface Signer
    {
        SignedString sign(string text, SignKey key);
        bool checkSignature(SignedString text, SignKey key);
    }

    public struct SignKey
    {
        public BigInteger Exponent { get; private set; }
        public BigInteger Modulus { get; private set; }

        public SignKey(BigInteger exponent, BigInteger modulus)
            : this()
        {
            Exponent = exponent;
            Modulus = modulus;
        }
    }

    public struct SignedString
    {
        public string Text { get; private set; }
        public BigInteger Signature { get; private set; }

        public SignedString(string text, BigInteger signature) : this()
        {
            Text = text;
            Signature = signature;
        }

        public SignedString(string signedText)
            : this()
        {
            try
            {
                Match matches = new Regex(@"\A(.*) (\d+)\Z", RegexOptions.Singleline).Match(signedText);
                Text = matches.Groups[1].Value;
                Signature = BigInteger.Parse(matches.Groups[2].Value);
            }
            catch (FormatException e)
            {
                throw new FormatException("Текст не соответствует требуемуму формату подписанного текста");
            }
        }

        public override string ToString()
        {
            return Text + " " + Signature.ToString();
        }
    }

    public class RSASigner : Signer
    {
        private const int P = 23819;
        private const int Q = 80251;
        private const int H0 = 100;

        public SignedString sign(string text, SignKey key)
        {
            BigInteger textDigest = digest(text);
            BigInteger s = BigInteger.ModPow(textDigest, key.Exponent, key.Modulus);
            SignedString result = new SignedString(text, s);
            return result;
        }

        public bool checkSignature(SignedString signedText, SignKey key)
        {
            BigInteger calculatedTextDigest = BigInteger.ModPow(signedText.Signature, key.Exponent, key.Modulus);
            BigInteger currentTextDigest = digest(signedText.Text);
            return calculatedTextDigest == currentTextDigest;
        }

        public BigInteger digest(string text)
        {
            //BigInteger n = new BigInteger(P) * Q;
            //BigInteger tmp, h = H0, hPrev = H0;
            //foreach (char c in text)
            //{
            //    tmp = h;
            //    h = BigInteger.ModPow(hPrev + Convert.ToInt32(c), 2, n);
            //    hPrev = tmp;
            //}
            //BigInteger result = h;
            BigInteger h = H0;
            BigInteger n = new BigInteger(P) * Q;
            foreach (char c in text)
            {
                h += Convert.ToInt32(c);
            }
            BigInteger result = BigInteger.ModPow(h, 2, n);
            return result;
        }
    }

    public class RSAKeyGenerator
    {
        public SignKey PublicKey { get; private set; }
        public SignKey PrivateKey { get; private set; }

        public BigInteger P { get; private set; }
        public BigInteger Q { get; private set; }
        public BigInteger N { get; private set; }
        public BigInteger Phi { get; private set; }

        private const int MIN_EXP = 10000;
        private const int MAX_EXP = 99999;
        private const int EPSILON = 500;

        private RandomGenerator primesGenerator = new RandomPrimeGenerator(MAX_EXP);
        private RandomGenerator numbersGenerator = new Utils.RandomNumberGenerator();

        public RSAKeyGenerator()
        {
            Generate();
        }

        public void Generate()
        {
            P = primesGenerator.Next(MIN_EXP, MAX_EXP);
            Q = primesGenerator.Next(P - EPSILON, P + EPSILON, x => x != P);
            N = P * Q;
            Phi = (P - 1) * (Q - 1);

            BigInteger e = numbersGenerator.Next(1, Phi, y => BigInteger.GreatestCommonDivisor(y, Phi) == 1);
            BigInteger d = e.ModInverse(Phi);

            PublicKey = new SignKey(e, N);
            PrivateKey = new SignKey(d, N);
        }
    }
}
