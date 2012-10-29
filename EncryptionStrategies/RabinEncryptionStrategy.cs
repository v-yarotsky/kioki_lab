using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Collections;
using CryptographyTemplate.Utils;
using CryptographyTemplate.Extensions;

namespace CryptographyTemplate.EncryptionStrategies
{
    public class RabinEncryptionStrategy : EncryptionStrategy
    {
        public struct RabinKey
        {
            public BigInteger N { get; private set; }
            public BigInteger P { get; private set; }
            public BigInteger Q { get; private set; }

            public RabinKey(BigInteger n) : this()
            {
                this.N = n;
            }

            public RabinKey(BigInteger p, BigInteger q) : this()
            {
                this.P = p; 
                this.Q = q;
            }
        }

        private string input;
        private RabinKey key;
        private const char DELIMITER = ':';
        private const string TOKEN = "xRABIN_TOKENx";
        private UTF8Encoding encoder;

        public RabinEncryptionStrategy(string input, RabinKey key)
        {
            if (input == "")
            {
                throw new ArgumentException("Введите сообщение для шифрования/дешифрации");
            }
            this.input = input;
            this.key = key;
            this.encoder = new UTF8Encoding();
        }

        public string encrypt()
        {
            byte[] bytes = encoder.GetBytes(TOKEN + input);
            BigInteger[] resultNumbers = bytes.Select(c => BigInteger.ModPow(c, 2, key.N)).ToArray<BigInteger>();
            return String.Join<BigInteger>(DELIMITER.ToString(), resultNumbers);
        }

        public string decrypt()
        {
            Extensions.BigIntegerExtensions.ExtendedEuclideanResult r = key.P.ExtendedEuclide(key.Q);
            BigInteger Yp = r.x;
            BigInteger Yq = r.y;
            BigInteger[] numbers = input.Split(DELIMITER).Select(n => BigInteger.Parse(n)).ToArray<BigInteger>();
            BigInteger Mq;
            BigInteger Mp;
            List<BigInteger> r1 = new List<BigInteger>();
            List<BigInteger> r2 = new List<BigInteger>();
            List<BigInteger> r3 = new List<BigInteger>();
            List<BigInteger> r4 = new List<BigInteger>();
            BigInteger N = key.P * key.Q;
            for (int i = 0; i < numbers.Length; i++)
            {
                r1.Add((Yp * key.P + Yq * key.Q) % N);
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                r2.Add(key.N - r1[i]);
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                r3.Add((Yp * key.P - Yq * key.Q) % N);
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                r4.Add(key.N - r3[i]);
            }

            String s1 = new String(r1.Select(n => System.Convert.ToChar((int)n)).ToArray<char>());
            String s2 = new String(r2.Select(n => System.Convert.ToChar((int)n)).ToArray<char>());
            String s3 = new String(r3.Select(n => System.Convert.ToChar((int)n)).ToArray<char>());
            String s4 = new String(r4.Select(n => System.Convert.ToChar((int)n)).ToArray<char>());
            return "";
        }

        public class RabinKeyGenerator
        {
            private RandomGenerator primes;
            private RandomGenerator randoms;

            public RabinKey PublicKey { get; private set; }
            public RabinKey PrivateKey { get; private set; }

            public RabinKeyGenerator(int max)
            {
                this.primes = new RandomPrimeGenerator(max);
                this.randoms = new RandomNumberGenerator();
            }

            public void GenerateKeys()
            {
                BigInteger p = primes.Next(x => x % 4 == 3);
                BigInteger q = primes.Next(x => (x % 4 == 3 && x != p));
                BigInteger n = p * q;

                PublicKey = new RabinKey(n);
                PrivateKey = new RabinKey(p, q);
            }
        }
    }
}
