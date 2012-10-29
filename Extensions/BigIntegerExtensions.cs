using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

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
