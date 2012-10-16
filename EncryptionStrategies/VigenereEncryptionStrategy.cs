using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CryptographyTemplate.EncryptionStrategies
{
    public class VigenereEncryptionStrategy : EncryptionStrategy
    {
        private String input;
        private String key;

        public VigenereEncryptionStrategy(String input, String key)
        {
            this.input = input;
            this.key = key;
        }

        public string encrypt()
        {
            List<char> result = new List<char>();
            for (int i = 0; i < input.Length; i++)
            {
                result.Add(VigenereTableValue(input[i], key[i % key.Length]));
            }
            return new String(result.ToArray<char>());
        }

        public string decrypt()
        {
            List<char> result = new List<char>();
            for (int i = 0; i < input.Length; i++)
            {
                result.Add(VigenereDecryptTableValue(input[i], key[i % key.Length]));
            }
            return new String(result.ToArray<char>());
        }

        public char VigenereTableValue(char inputChar, char keyChar)
        {
            int code = (int)inputChar + (int)keyChar;
            return System.Convert.ToChar(code % char.MaxValue);
        }

        public char VigenereDecryptTableValue(char encryptedInputChar, char keyChar)
        {
            int code = (int)encryptedInputChar - (int)keyChar;
            if (code <= 0)
                code = char.MaxValue + code;
            return System.Convert.ToChar(code % char.MaxValue);
        }
    }
}
