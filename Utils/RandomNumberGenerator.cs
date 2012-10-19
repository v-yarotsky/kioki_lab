﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace CryptographyTemplate.Utils
{
    class RandomNumberGenerator : RandomGenerator
    {
        private const int MIN_NUM = 0;
        private const int MAX_NUM = 99999;

        private Random rand;

        public RandomNumberGenerator()
        {
            this.rand = new Random();
        }

        public BigInteger Next()
        {
            return Next(MIN_NUM, MAX_NUM);
        }

        public BigInteger Next(Predicate<BigInteger> p)
        {
            return Next(MIN_NUM, MAX_NUM, p);
        }

        public BigInteger Next(BigInteger min, BigInteger max)
        {
            return Next(min, max, x => true);
        }

        public BigInteger Next(BigInteger min, BigInteger max, Predicate<BigInteger> p)
        {
            BigInteger result;
            do { result = rand.Next((int)min, (int)max); } while (!p(result));
            return result;
        }
    }
}
