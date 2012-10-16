using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CryptographyTemplate.EncryptionStrategies
{
    public class RailwayFenceEncryptionStrategy : EncryptionStrategy
    {
        private String input;
        private int fenceSize;

        public RailwayFenceEncryptionStrategy(String input, int key)
        {
            this.input = input;
            this.fenceSize = key;

            if (fenceSize >= input.Length)
            {
                throw new ArgumentException("Ключ слишком велик для данного текста");
            }
            else if (fenceSize <= 1)
            {
                throw new ArgumentException("Ключ - натуральное число, большее, чем 1");
            }
        }

        public String encrypt()
        {
            ResultAccumulator encryptionResultAccumulator = new EncryptResultAccumulator(input);
            railwaize(input.Length, fenceSize, encryptionResultAccumulator);
            return encryptionResultAccumulator.GetResult();
        }

        public String decrypt()
        {
            ResultAccumulator decryptionResultAccumulator = new DecryptResultAccumulator(input);
            railwaize(input.Length, fenceSize, decryptionResultAccumulator);
            return decryptionResultAccumulator.GetResult();
        }

        public interface ResultAccumulator
        {
            void Accumulate(int position);
            string GetResult();
        }

        public class EncryptResultAccumulator : ResultAccumulator
        {
            protected String input;
            protected char[] result;
            protected int counter = 0;

            public EncryptResultAccumulator(String input)
            {
                this.input = input;
                this.result = new char[input.Length];
            }

            public virtual void Accumulate(int position)
            {
                result[counter++] = input[position];
            }

            public string GetResult()
            {
                return new String(result);
            }
        }

        class DecryptResultAccumulator : EncryptResultAccumulator
        {
            public DecryptResultAccumulator(String input) : base(input) { }

            public override void Accumulate(int position)
            {
                result[position] = input[counter++];
            }
        }

        private void railwaize(int length, int fenceSize, ResultAccumulator accumulator)
        {
            for (int line = 0; line < fenceSize; line++)
            {
                int offset = line;
                int distanceBetweenPairElements = line == fenceSize - 1 ? 0 : (fenceSize - line - 1) * 2 - 1;
                int distanceBetweenPairs = line == 0 ? 0 : line * 2 - 1;

                int counter = 0;
                do
                {
                    int delta = counter++ % 2 == 0 ? distanceBetweenPairElements : distanceBetweenPairs;
                    if (delta == 0)
                    {
                        continue;
                    }
                    accumulator.Accumulate(offset);
                    offset += delta + 1;
                } while (offset < length);
            }
        }
    }
}
