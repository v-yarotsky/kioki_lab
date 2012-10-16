using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace CryptographyTemplate.EncryptionStrategies
{
    public class RSAEncryptionStrategy : EncryptionStrategy
    {
        private string input;

        private BigInteger p, q, n, phi, e, d;

        private const char DELIMITER = ';';

        public RSAEncryptionStrategy(string input, BigInteger p, BigInteger q)
        {
            this.input = input;

            this.p = p;
            this.q = q;
            this.n = p * q;
            this.phi = (p - 1) * (q - 1);

            this.e = 257;
            this.d = ModInverse(e, phi);
        }

        public string encrypt()
        {
            BigInteger[] resultNumbers = input.ToCharArray().Select(c => 
                ModPow(Convert.ToInt32(c), e, n)).ToArray<BigInteger>();
            return String.Join<BigInteger>(DELIMITER.ToString(), resultNumbers);
        }

        public string decrypt()
        {
            char[] resultSymbols = input.Split(DELIMITER).Select(s => 
                (char)(ModPow(BigInteger.Parse(s), d, n))).ToArray<char>();
            return String.Join("", resultSymbols);
        }

        public BigInteger ModPow(BigInteger num, BigInteger exp, BigInteger modulus)
        {
            BigInteger x = 1;
            while (!exp.IsZero)
            {
                while (exp.IsEven)
                {
                    exp = exp / 2;
                    num = (num * num) % modulus;
                }
                exp--;
                x = (x * num) % modulus;
            }
            return x;
        }

        private BigInteger ModInverse(BigInteger a, BigInteger b)
        {
            BigInteger dividend = a % b;
            BigInteger divisor = b;

            BigInteger last_x = BigInteger.One;
            BigInteger curr_x = BigInteger.Zero;

            while (divisor.Sign > 0)
            {
                BigInteger quotient = dividend / divisor;
                BigInteger remainder = dividend % divisor;
                if (remainder.Sign <= 0)
                {
                    break;
                }

                BigInteger next_x = last_x - curr_x * quotient;
                last_x = curr_x;
                curr_x = next_x;

                dividend = divisor;
                divisor = remainder;
            }

            if (divisor != BigInteger.One)
            {
                throw new Exception("Числа не являются взаимно простыми");
            }
            return (curr_x.Sign < 0 ? curr_x + b : curr_x);
        }
    }
}
