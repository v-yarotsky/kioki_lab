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
        public string Signature { get; private set; }

        public SignedString(string text, string signature)
            : this()
        {
            Text = text;
            Signature = signature;
        }

        public SignedString(string signedText)
            : this()
        {
            try
            {
                Match matches = new Regex(@"\A(.*) ([:\d]+)\Z", RegexOptions.Singleline).Match(signedText);
                if (matches.Groups.Count < 3)
                {
                    throw new FormatException();
                }
                Text = matches.Groups[1].Value;
                Signature = matches.Groups[2].Value;
            }
            catch (FormatException e)
            {
                throw new FormatException("Текст не соответствует требуемуму формату подписанного текста");
            }
        }

        public override string ToString()
        {
            return Text + " " + Signature;
        }
    }

    public class RSASigner : Signer
    {
        Encoding utf8 = new UTF8Encoding();

        private const int P = 23819;
        private const int Q = 80251;
        private const int H0 = 100;
        private char DELIMITER = ':';

        public SignedString sign(string text, SignKey key)
        {
            string textDigest = digest(text);
            var signatureQuery = from b in utf8.GetBytes(textDigest) select BigInteger.ModPow(b, key.Exponent, key.Modulus).ToString();
            string signature = String.Join(DELIMITER.ToString(), signatureQuery.ToArray<String>());
            SignedString result = new SignedString(text, signature);
            return result;
        }

        public bool checkSignature(SignedString signedText, SignKey key)
        {
            var calculatedTextDigestQuery = from b in signedText.Signature.Split(DELIMITER) select (byte)BigInteger.ModPow(BigInteger.Parse(b), key.Exponent, key.Modulus);
            string calculatedTextDigest = utf8.GetString(calculatedTextDigestQuery.ToArray<Byte>());
            string currentTextDigest = digest(signedText.Text);
            return calculatedTextDigest == currentTextDigest;
        }

        public string digest(string text)
        {
            byte[] hashBytes = SHA1.Create().ComputeHash(utf8.GetBytes(text));
            string result = BitConverter.ToString(hashBytes);
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

        private const int MIN_EXP = 100000;
        private const int MAX_EXP = 999999;
        private const int EPSILON = 5000;

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
