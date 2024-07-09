using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace security_program {
    public class Vigenere : ICipher {
        public string Encrypt(string plaintext, Dictionary<string, object> parameters) {
            if (!parameters.ContainsKey("key")) {
                throw new KeyNotFoundException("The 'key' parameter is missing.");
            }

            string key = parameters["key"].ToString();
            return VigenereEncrypt(plaintext, key);
        }

        public string Decrypt(string ciphertext, Dictionary<string, object> parameters) {
            if (!parameters.ContainsKey("key")) {
                throw new KeyNotFoundException("The 'key' parameter is missing.");
            }

            string key = parameters["key"].ToString();
            return VigenereDecrypt(ciphertext, key);
        }

        private string VigenereEncrypt(string plaintext, string key) {
            StringBuilder result = new StringBuilder();
            plaintext = plaintext.ToLower();
            key = key.ToLower();

            for (int i = 0; i < plaintext.Length; i++) {
                char c = plaintext[i];
                if (char.IsLetter(c)) {
                    char encryptedChar = (char)((((c - 'a') + (key[i % key.Length] - 'a')) % 26) + 'a');
                    result.Append(encryptedChar);
                } else {
                    result.Append(c);
                }
            }

            return result.ToString();
        }

        private string VigenereDecrypt(string ciphertext, string key) {
            StringBuilder result = new StringBuilder();
            ciphertext = ciphertext.ToLower();
            key = key.ToLower();

            for (int i = 0; i < ciphertext.Length; i++) {
                char c = ciphertext[i];
                if (char.IsLetter(c)) {
                    char decryptedChar = (char)((((c - 'a') - (key[i % key.Length] - 'a') + 26) % 26) + 'a');
                    result.Append(decryptedChar);
                } else {
                    result.Append(c);
                }
            }

            return result.ToString();
        }
    }
}
