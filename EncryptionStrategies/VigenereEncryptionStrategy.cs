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
            if (key == "")
            {
                throw new ArgumentException("Ключ не может быть пустым");
            }
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
            int alphabetLength = char.MaxValue + 1;
            int code = ((int)inputChar + (int)keyChar) % alphabetLength;
            return System.Convert.ToChar(code);
        }

        public char VigenereDecryptTableValue(char encryptedInputChar, char keyChar)
        {
            int alphabetLength = char.MaxValue + 1;
            //int code = (int)encryptedInputChar - (int)keyChar;
            //if (code < 0)
            //    code = alphabetLength + code;
            int code = ((int)encryptedInputChar + alphabetLength - (int)keyChar) % alphabetLength;
            return System.Convert.ToChar(code);
        }
    }
}
