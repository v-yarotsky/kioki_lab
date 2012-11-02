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
        public struct ExtendedEuclideanResult
        {
            public BigInteger x;
            public BigInteger y;
            public BigInteger gcd;
        }

        public static ExtendedEuclideanResult ExtendedEuclide(BigInteger a, BigInteger b)
        {
            BigInteger x = 1;
            BigInteger d = a;
            BigInteger v1 = 0;
            BigInteger v3 = b;

            while (v3 > 0)
            {
                BigInteger q0 = d / v3;
                BigInteger q1 = d % v3;
                BigInteger tmp = v1 * q0;
                BigInteger tn = x - tmp;
                x = v1;
                v1 = tn;

                d = v3;
                v3 = q1;
            }

            BigInteger tmp2 = x * (a);
            tmp2 = d - (tmp2);
            BigInteger res = tmp2 / (b);

            ExtendedEuclideanResult result = new ExtendedEuclideanResult()
            {
                x = x,
                y = res,
                gcd = d
            };

            return result;
        }

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
            byte[] bytes = encoder.GetBytes(input);
            BigInteger[] resultNumbers = bytes.Select(c => encryptOne(c)).ToArray<BigInteger>();
            return String.Join<BigInteger>(DELIMITER.ToString(), resultNumbers);
        }

        private BigInteger encryptOne(byte b)
        {
            BigInteger m = 2 * b + 1;
            BigInteger n = key.N;
            if (m.L(n) == 1)
            {
                if (4 * m < n)
                    return BigInteger.ModPow(4 * m, 2, n);
                else
                    throw new ArgumentOutOfRangeException("Невозможно зашифровать данный текст");
            }
            else
            {
                if (2 * m < n)
                    return BigInteger.ModPow(2 * m, 2, n);
                else
                    throw new ArgumentOutOfRangeException("Невозможно зашифровать данный текст");
            }
        }

        public string decrypt()
        {
            BigInteger[] numbers = input.Split(DELIMITER).Select(n => BigInteger.Parse(n)).ToArray<BigInteger>();
            List<BigInteger> charCodes = new List<BigInteger>();
            BigInteger p = key.P, q = key.Q;
            BigInteger N = p * q;
            for (int i = 0; i < numbers.Length; i++)
            {
                BigInteger d = ((p - 1) * (q - 1) / 4 + 1) / 2;
                BigInteger L = BigInteger.ModPow(numbers[i], d, N);
                BigInteger[] roots = 
                { 
                    (L / 4 - 1) / 2,
                    ((N - L) / 4 - 1) / 2,
                    (L / 2 - 1) / 2,
                    ((N - L) / 2 - 1) / 2
                };
                charCodes.Add(roots[(int)(L % 4)]);
            }
            Encoding utf = new UTF8Encoding();
            string result = utf.GetString((from c in charCodes select (byte)(c)).ToArray<byte>());
            return result;
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
                BigInteger p = primes.Next(x => x % 8 == 3);
                BigInteger q = primes.Next(x => x % 8 == 7 && x != p);
                
                BigInteger n = p * q;

                PublicKey = new RabinKey(n);
                PrivateKey = new RabinKey(p, q);
            }
        }
    }
}
