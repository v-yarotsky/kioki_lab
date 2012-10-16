using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace CryptographyTemplate.EncryptionStrategies
{
    //public class RabinEncryptionStrategy : EncryptionStrategy
    //{
    //    public struct RabinKey
    //    {
    //        public BigInteger Exponent { get; private set; }
    //        public BigInteger Modulus { get; private set; }
    //        public RabinKey(BigInteger exponent, BigInteger modulus) { this.Exponent = exponent; this.Modulus = modulus; }
    //    }

    //    private string input;
    //    private RabinKey key;

    //    public RabinEncryptionStrategy(string input, RabinKey key)
    //    {
    //        this.input = input;
    //        this.key = key;
    //    }

    //    public string encrypt()
    //    {
    //        return "";
    //    }

    //    public string decrypt()
    //    {
    //        return "";
    //    }

    //    public BigInteger ModPow(BigInteger num, BigInteger exp, BigInteger modulus)
    //    {
    //        BigInteger x = 1;
    //        while (!exp.IsZero)
    //        {
    //            while (exp.IsEven)
    //            {
    //                exp = exp / 2;
    //                num = (num * num) % modulus;
    //            }
    //            exp--;
    //            x = (x * num) % modulus;
    //        }
    //        return x;
    //    }

    //    private BigInteger ModInverse(BigInteger a, BigInteger b)
    //    {
    //        BigInteger dividend = a % b;
    //        BigInteger divisor = b;

    //        BigInteger last_x = BigInteger.One;
    //        BigInteger curr_x = BigInteger.Zero;

    //        while (divisor.Sign > 0)
    //        {
    //            BigInteger quotient = dividend / divisor;
    //            BigInteger remainder = dividend % divisor;
    //            if (remainder.Sign <= 0)
    //            {
    //                break;
    //            }

    //            BigInteger next_x = last_x - curr_x * quotient;
    //            last_x = curr_x;
    //            curr_x = next_x;

    //            dividend = divisor;
    //            divisor = remainder;
    //        }

    //        if (divisor != BigInteger.One)
    //        {
    //            throw new Exception("Числа не являются взаимно простыми");
    //        }
    //        return (curr_x.Sign < 0 ? curr_x + b : curr_x);
    //    }
    //}
}
