using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CryptographyTemplate.Utils;
using System.Text.RegularExpressions;
using System.Numerics;
using CryptographyTemplate.Extensions;

namespace CryptographyTemplate
{
    public struct DSASignedString
    {
        public string Text { get; private set; }
        public BigInteger R { get; private set; }
        public BigInteger S { get; private set; }

        public DSASignedString(string text, BigInteger r, BigInteger s)
            : this()
        {
            Text = text;
            R = r;
            S = s;
        }

        public DSASignedString(string signedText)
            : this()
        {
            try
            {
                Match matches = new Regex(@"\A(.*) (\d+):(\d+)\Z", RegexOptions.Singleline).Match(signedText);
                if (matches.Groups.Count < 4)
                {
                    throw new FormatException();
                }
                Text = matches.Groups[1].Value;
                R = BigInteger.Parse(matches.Groups[2].Value);
                S = BigInteger.Parse(matches.Groups[3].Value);
            }
            catch (FormatException e)
            {
                throw new FormatException("Неверный формат подписанного текста!");
            }
        }

        public override string ToString()
        {
            return Text + " " + R + ":" + S;
        }
    }

    public class DSAKeyGenerator
    {
        public DomainParameters Domain { get; set; }
        public SignKey PrivateKey { get; private set; }
        public SignKey PublicKey { get; private set; }

        private RandomGenerator numbers;

        public DSAKeyGenerator(DomainParameters domain)
        {
            numbers = new RandomNumberGenerator();
            Domain = domain;
            GenerateKeys();
        }

        public void GenerateKeys()
        {
            BigInteger x, y;
            x = numbers.Next(0, Domain.Q);
            y = BigInteger.ModPow(Domain.G, x, Domain.P);

            PrivateKey = new SignKey(x);
            PublicKey = new SignKey(y);
        }
    }

    public struct SignKey
    {
        public BigInteger Value { get; private set; }
        public SignKey(BigInteger value) : this() { Value = value; }
    }

    public struct DomainParameters
    {
        public BigInteger P { get; private set; }
        public BigInteger Q { get; private set; }
        public BigInteger G { get; private set; }
        public BigInteger H { get; private set; }

        private static RandomPrimeGenerator primes;

        public DomainParameters(BigInteger p, BigInteger q, BigInteger g)
            : this()
        {
            P = p;
            Q = q;
            G = g;
        }

        public DomainParameters(BigInteger p, BigInteger q, BigInteger g, BigInteger h)
            : this(p, q, g)
        {
            H = h;
        }

        public override string ToString()
        {
            return "P: " + P + " Q: " + Q + " G: " + G;
        }

        public static DomainParameters GenerateDomainParameters(int minQ = 10000, int maxQ = 99999)
        {
            if (primes == null)
                primes = new RandomPrimeGenerator();
            RandomGenerator numbers = new RandomNumberGenerator();

            BigInteger q, p, h, g;

            q = primes.Next(minQ, maxQ);

            int i = 1;
            int tries = 0;
            do
            {
                p = q * i + 1;
                i++;
                tries++;
                if (tries > 500) { i = 0;  tries = 0; q = primes.Next(minQ, maxQ); }
            } while (!p.IsProbablePrime(1));
            h = numbers.Next(1, p - 1);
            g = BigInteger.ModPow(h, (p - 1) / q, p);
            //g = numbers.Next(n => BigInteger.Pow(n, (int)q) % p == 1);
            if (g.IsZero || g.IsOne) { throw new Exception("G = 0 or G = 1"); }
            return new DomainParameters(p, q, g, h);
        }
    }

    public interface Signer
    {
        string CheckSignatureIntermediateValues { get; }
        string SignIntermediateValues { get; }
        DSASignedString sign(string text, SignKey key);
        bool checkSignature(DSASignedString text, SignKey key);
        BigInteger digest(string text);
        BigInteger decryptedDigest(DSASignedString text, SignKey key);
    }

    public class DSASigner : Signer
    {
        public BigInteger K { get; set; }
        public BigInteger R { get; set; }
        public BigInteger S { get; set; }

        public string CheckSignatureIntermediateValues { get; private set; }
        public string SignIntermediateValues { get; private set; }

        private RandomGenerator primes;
        private RandomGenerator numbers;

        public DomainParameters Domain { get; set; }

        public DSASigner(DomainParameters domain)
        {
            numbers = new RandomNumberGenerator();
            Domain = domain;
        }

        public DSASignedString sign(string text, SignKey key)
        {
            BigInteger d;
            do
            {
                K = numbers.Next(1, Domain.Q);
                R = BigInteger.ModPow(Domain.G, K, Domain.P) % Domain.Q;
                d = digest(text);
                S = (K.ModInverse(Domain.Q) * (d + key.Value * R)) % Domain.Q;
            } while (R == 0 || S == 0);
            SignIntermediateValues = String.Format("K: {0:D}, R: {1:D}, S: {2:D}, h(M): {3:D}, X: {4:D}", K, R, S, d, key.Value);
            return new DSASignedString(text, R, S);
        }

        public bool checkSignature(DSASignedString signedText, SignKey key)
        {
            return decryptedDigest(signedText, key) == signedText.R;
        }

        public BigInteger digest(string text)
        {
            return text.GetDigest();
        }

        public BigInteger decryptedDigest(DSASignedString signedText, SignKey key)
        {
            BigInteger w = signedText.S.ModInverse(Domain.Q);
            BigInteger d = digest(signedText.Text);
            BigInteger u1 = (d * w) % Domain.Q;
            BigInteger u2 = (signedText.R * w) % Domain.Q;
            BigInteger v = ((BigInteger.ModPow(Domain.G, u1, Domain.P) * BigInteger.ModPow(key.Value, u2, Domain.P)) % Domain.P) % Domain.Q;
            CheckSignatureIntermediateValues = String.Format("W: {0:D}, h(M'): {1:D}, u1: {2:D}, u2: {3:D}, V: {4:D}, R: {5:D}, S: {6:D}, Y: {7:D}", w, d, u1, u2, v, signedText.R, signedText.S, key.Value);
            return v;
        }
    }
}
    