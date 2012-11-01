using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Security.Cryptography;

namespace CryptographyTemplate.Extensions
{
    public static class BigIntegerExtensions
    {
        public static BigInteger ModInverse(this BigInteger a, BigInteger b)
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

        public static bool IsProbablePrime(this BigInteger source, int certainty)
        {
            if (source == 2 || source == 3)
                return true;
            if (source < 2 || source % 2 == 0)
                return false;

            BigInteger d = source - 1;
            int s = 0;

            while (d % 2 == 0)
            {
                d /= 2;
                s += 1;
            }

            // There is no built-in method for generating random BigInteger values.
            // Instead, random BigIntegers are constructed from randomly generated
            // byte arrays of the same length as the source.
            RandomNumberGenerator rng = RandomNumberGenerator.Create();
            byte[] bytes = new byte[source.ToByteArray().LongLength];
            BigInteger a;

            for (int i = 0; i < certainty; i++)
            {
                do
                {
                    rng.GetBytes(bytes);
                    a = new BigInteger(bytes);
                }
                while (a < 2 || a >= source - 2);

                BigInteger x = BigInteger.ModPow(a, d, source);
                if (x == 1 || x == source - 1)
                    continue;

                for (int r = 1; r < s; r++)
                {
                    x = BigInteger.ModPow(x, 2, source);
                    if (x == 1)
                        return false;
                    if (x == source - 1)
                        break;
                }

                if (x != source - 1)
                    return false;
            }

            return true;
        }

        public struct ExtendedEuclideanResult
        {
            public BigInteger x;
            public BigInteger y;
            public BigInteger gcd;
        }

        public static ExtendedEuclideanResult ExtendedEuclide(this BigInteger a, BigInteger b)
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
    }
}
