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
            int size = (int)Math.Ceiling((double)input.Length / grid.Length) * grid.Length;
            char[] source = new char[size];
            input.ToCharArray().CopyTo(source, 0);
            char[] result = new char[size];
            bool isOddMatrixSize = grid.Length % 2 != 0;
            int n = (int)Math.Sqrt(grid.Length);

            int gridHolesCount = isOddMatrixSize ? n - 1 : 1;

            int counter = 0;
            int substrNumber = 0;
            char[] substr = new char[4 * n];

            while (substrNumber * 4 * n < source.Length)
            {
                Array.Copy(source, substrNumber * 4 * n, substr, 0, 4 * n);
                for (int side = 0; side < 4; side++)
                {
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            if (grid[i, j] && result[substrNumber * 4 * n + i * n + j] == '\0')
                            {
                                result[substrNumber * 4 * n + i * n + j] = substr[counter++];
                            }
                        }
                    }
                    grid = RotateMatrix(grid);
                }
                counter = 0;
                substrNumber++;
            }
            string noise = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTWXYZ";
            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] == '\0')
                {
                    result[i] = noise[i % noise.Length];
                }
            }
            return new String(result);
        }

        public string decrypt()
        {
            int size = (int)Math.Ceiling((double)input.Length / grid.Length) * grid.Length;
            char[] source = new char[size];
            input.ToCharArray().CopyTo(source, 0);
            List<char> result = new List<char>();
            bool isOddMatrixSize = grid.Length % 2 != 0;
            int n = (int)Math.Sqrt(grid.Length);
            int matrixCentralIndex = n / 2 + 1;
            
            int substrNumber = 0;
            while (substrNumber * 4 * n < source.Length)
            {
                for (int side = 0; side < 4; side++)
                {
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            if (grid[i, j])
                            {
                                var isCellReadBefore = isOddMatrixSize &&
                                                    i == matrixCentralIndex &&
                                                    j == matrixCentralIndex &&
                                                    side != 0;
                                if (!isCellReadBefore)
                                    result.Add(source[substrNumber * 4 * n + i * n + j]);
                            }
                        }
                    }
                    grid = RotateMatrix(grid);
                }
                substrNumber++;
            }
            for (int i = 0; i < result.Count; i++)
            {
                if (result[i] == '\0')
                {
                    result[i] = '_';
                }
            }
            return new String(result.ToArray<char>());
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
