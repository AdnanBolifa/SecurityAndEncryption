using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace security_program {
    public class Caesar : ICipher {
        public string Encrypt(string plaintext, Dictionary<string, object> parameters) {
            if (!parameters.ContainsKey("key") || !(parameters["key"] is int)) {
                throw new ArgumentException("Invalid key parameter for Caesar cipher");
            }
            int key = (int)parameters["key"];
            return CaesarEncrypt(plaintext, key);
        }

        public string Decrypt(string ciphertext, Dictionary<string, object> parameters) {
            if (!parameters.ContainsKey("key") || !(parameters["key"] is int)) {
                throw new ArgumentException("Invalid key parameter for Caesar cipher");
            }
            int key = (int)parameters["key"];
            return CaesarDecrypt(ciphertext, key);
        }

        private string CaesarEncrypt(string str, int key) {
            StringBuilder tmpStr = new StringBuilder(str);
            for (int i = 0; i < tmpStr.Length; i++) {
                if (tmpStr[i] != ' ') {
                    tmpStr[i] = (char)(tmpStr[i] + key);
                    if (tmpStr[i] > 'z') {
                        tmpStr[i] = (char)((tmpStr[i] % 'z') + ('a' - 1));
                    } else if (tmpStr[i] > 'Z' && tmpStr[i] < 'a') {
                        tmpStr[i] = (char)((tmpStr[i] % 'Z') + ('A' - 1));
                    }
                }
            }
            return tmpStr.ToString();
        }

        private string CaesarDecrypt(string str, int key) {
            StringBuilder tmpStr = new StringBuilder(str);
            for (int i = 0; i < tmpStr.Length; i++) {
                if (tmpStr[i] != ' ') {
                    tmpStr[i] = (char)(tmpStr[i] - key);
                    if (tmpStr[i] < 'a' && tmpStr[i] > 'Z') {
                        tmpStr[i] = (char)(('z' + 1) - ('a' - tmpStr[i]));
                    } else if (tmpStr[i] < 'A' && tmpStr[i] > ' ') {
                        tmpStr[i] = (char)(('Z' + 1) - ('A' - tmpStr[i]));
                    }
                }
            }
            return tmpStr.ToString();
        }
    }
}
