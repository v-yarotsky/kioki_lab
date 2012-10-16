using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CryptographyTemplate.EncryptionStrategies
{
    public class RotatingGridEncryptionStrategy : EncryptionStrategy
    {
        private String input;
        private bool[,] grid;

        public RotatingGridEncryptionStrategy(String input, bool[,] key)
        {
            this.input = input;
            this.grid = key;
        }

        public string encrypt()
        {
            int n = (int)Math.Sqrt(grid.Length);
            int numberOfHoles = NumberOfHoles(n);

            int size = (int)Math.Ceiling((double)input.Length / (4 * numberOfHoles)) * grid.Length;
            char[] source = new char[size];
            input.ToCharArray().CopyTo(source, 0);
            char[] result = new char[size];


            int counter = 0;

            int substrNumber = 0;
            int substrLength = 4 * numberOfHoles;
            char[] substr = new char[grid.Length];

            int substringsCount = (int)Math.Ceiling((double)input.Length / (4 * numberOfHoles));

            while (substrNumber < substringsCount)
            {
                Array.Copy(source, substrNumber * substrLength, substr, 0, substrLength);
                for (int side = 0; side < 4; side++)
                {
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            if (grid[i, j])
                            {
                                result[substrNumber * grid.Length + i * n + j] = substr[counter++];
                            }
                        }
                    }
                    grid = RotateMatrix(grid);
                }
                counter = 0;
                substrNumber++;
            }

            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] == '\0')
                {
                    result[i] = ' ';
                }
            }
            return new String(result);
        }

        public string decrypt()
        {
            int n = (int)Math.Sqrt(grid.Length);
            int numberOfHoles = NumberOfHoles(n);

            int size = (int)Math.Ceiling((double)input.Length / grid.Length) * grid.Length;
            char[] source = new char[size];
            input.ToCharArray().CopyTo(source, 0);
            char[] result = new char[size];

            int counter = 0;
            int substrNumber = 0;
            int substringsCount = (int)Math.Ceiling((double)input.Length / grid.Length);
            char[] substr = new char[grid.Length];

            while (substrNumber < substringsCount)
            {
                for (int side = 0; side < 4; side++)
                {
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            if (grid[i, j])
                            {
                                result[counter++] = source[substrNumber * grid.Length + i * n + j];
                            }
                        }
                    }
                    grid = RotateMatrix(grid);
                }
                substrNumber++;
            }
            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] == '\0')
                {
                    result[i] = ' ';
                }
            }
            return new String(result.ToArray<char>());
        }

        private int NumberOfHoles(int n)
        {
            int a = n / 2;
            return a * (n - a);
        }

        private bool[,] RotateMatrix(bool[,] matrix)
        {
            int n = (int)Math.Sqrt(matrix.Length);
            bool[,] result = new bool[n,n];

            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    result[i, j] = matrix[n - j - 1, i];
                }
            }

            return result;
        }
    }
}
