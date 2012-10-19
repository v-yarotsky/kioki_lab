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
            public BigInteger X { get; private set; } // N for public key, P for private key
            public BigInteger Y { get; private set; } // B for public key, Q for private key

            public RabinKey(BigInteger x, BigInteger y) : this()
            {
                this.X = x; 
                this.Y = y;
            }
        }

        private string input;
        private RabinKey key;
        private const char DELIMITER = ':';
        private const string TOKEN = "xRABIN_TOKENx";
        private UTF8Encoding encoder;

        public RabinEncryptionStrategy(string input, RabinKey key)
        {
            this.input = input;
            this.key = key;
            this.encoder = new UTF8Encoding();
        }

        public string encrypt()
        {
            byte[] bytes = encoder.GetBytes(TOKEN + input);
            BigInteger b = key.Y;
            BigInteger n = key.X;
            BigInteger[] resultNumbers = bytes.Select(c => (BigInteger.Pow(c, 2) + b * c) % n).ToArray<BigInteger>();
            return String.Join<BigInteger>(DELIMITER.ToString(), resultNumbers);
        }

        public string decrypt()
        {
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
                BigInteger b = randoms.Next(x => x < n);

                PublicKey = new RabinKey(n, b);
                PrivateKey = new RabinKey(p, q);
            }
        }
    }
}
