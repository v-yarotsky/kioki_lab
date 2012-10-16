using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CryptographyTemplate.EncryptionStrategies
{
    public class PassPhraseEncryptionStrategy : EncryptionStrategy
    {
        private String input;
        private String key;

        public PassPhraseEncryptionStrategy(String input, String key)
        {
            if (key == "")
            {
                throw new ArgumentException("Ключ не может быть пустым");
            }
            this.input = input;
            this.key = key;
        }

        public string encrypt()
        {
            int tableLength = CalculateTableLength(input.Length, key.Length);
            ResultAccumulator encryptionResultAccumulator = new EncryptResultAccumulator(input, tableLength);
            ExchangeColumns(tableLength, key, encryptionResultAccumulator);
            return encryptionResultAccumulator.GetResult();
        }

        public string decrypt()
        {
            int tableLength = CalculateTableLength(input.Length, key.Length);
            ResultAccumulator decryptionResultAccumulator = new DecryptResultAccumulator(input, tableLength);
            ExchangeColumns(tableLength, key, decryptionResultAccumulator);
            return decryptionResultAccumulator.GetResult();
        }

        abstract class ResultAccumulator
        {
            protected char[] input;
            protected char[] result;

            public ResultAccumulator(String input, int tableLength)
            {
                this.input = InitializeCharTable(input.Length, tableLength);
                input.ToCharArray().CopyTo(this.input, 0);
                this.result = InitializeCharTable(input.Length, tableLength);
            }

            public abstract void Accumulate(int p1, int p2);

            public String GetResult()
            {
                return new String(result);
            }

            private char[] InitializeCharTable(int inputSize, int tableLength)
            {
                char[] result = new char[tableLength];
                for (int i = 0; i < result.Length; i++) { result[i] = ' '; }
                return result;
            }
        }

        class EncryptResultAccumulator : ResultAccumulator
        {
            public EncryptResultAccumulator(String input, int blockSize) : base(input, blockSize) { }

            public override void Accumulate(int p1, int p2)
            {
                this.result[p1] = this.input[p2];
            }
        }

        class DecryptResultAccumulator : ResultAccumulator
        {
            public DecryptResultAccumulator(String input, int blockSize) : base(input, blockSize) { }

            public override void Accumulate(int p1, int p2)
            {
                this.result[p2] = this.input[p1];
            }
        }

        private int CalculateTableLength(int inputSize, int rowSize)
        {
            int resultSize = (int)Math.Ceiling((double)inputSize / rowSize) * rowSize;
            return resultSize;
        }

        private void ExchangeColumns(int tableLength, String key, ResultAccumulator accumulator)
        {
            int[] exchanges = GetExchanges(key);
            for (int i = 0; i < tableLength; i++)
            {
                int row = i / exchanges.Length;
                int currentOffset = i % exchanges.Length;
                int destinationIndex = row * exchanges.Length + exchanges[currentOffset];
                accumulator.Accumulate(i, destinationIndex);
            }
        }

        private int[] GetExchanges(String encryptionKey)
        {
            int[] exchanges = new int[encryptionKey.Length];
            for (int i = 0; i < encryptionKey.Length; i++)
            {
                exchanges[i] = i;
            }
            char[] symbols = encryptionKey.ToCharArray();
            Array.Sort(symbols, exchanges);
            return exchanges;
        }
    }
}
