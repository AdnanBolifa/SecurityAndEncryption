using System;
using System.Collections.Generic;

namespace security_program {
    public class RSACipher : ICipher {
        public string Encrypt(string plaintext, Dictionary<string, object> parameters) {
            if (!parameters.ContainsKey("p") || !parameters.ContainsKey("q") || !parameters.ContainsKey("e")) {
                throw new ArgumentException("Invalid parameters for RSA cipher");
            }
            int p = Convert.ToInt32(parameters["p"]);
            int q = Convert.ToInt32(parameters["q"]);
            int e = Convert.ToInt32(parameters["e"]);

            return RSAEncrypt(plaintext, p, q, e);
        }

        public string Decrypt(string ciphertext, Dictionary<string, object> parameters) {
            if (!parameters.ContainsKey("p") || !parameters.ContainsKey("q") || !parameters.ContainsKey("e")) {
                throw new ArgumentException("Invalid parameters for RSA cipher");
            }
            int p = Convert.ToInt32(parameters["p"]);
            int q = Convert.ToInt32(parameters["q"]);
            int e = Convert.ToInt32(parameters["e"]);

            return RSADecrypt(ciphertext, p, q, e);
        }

        private string RSAEncrypt(string plaintext, int p, int q, int e) {
            // Convert plaintext to a numeric representation
            string M_str1 = "";
            for (int i = 0; i < plaintext.Length; i++) {
                if ((plaintext[i] >= '0' && plaintext[i] <= '9')) {
                    M_str1 += plaintext[i].ToString();
                } else {
                    M_str1 += ((byte)plaintext[i]).ToString();
                }
            }

            int M = Convert.ToInt32(M_str1, 10);
            int n = p * q;

            double M_to_e = Math.Pow(M, e);
            int C = (int)(M_to_e % n);

            return C.ToString();
        }

        private string RSADecrypt(string ciphertext, int p, int q, int e) {
            int C = Convert.ToInt32(ciphertext, 10);
            int n = p * q;
            int phi = (p - 1) * (q - 1);
            int d = 0;
            int mod1_phi = phi + 1;

            // Find d
            while (d == 0) {
                if (mod1_phi % e == 0) {
                    d = mod1_phi / e;
                } else {
                    mod1_phi += phi;
                }
            }

            double M_to_d = Math.Pow(C, d);
            int M = (int)(M_to_d % n);

            return M.ToString();
        }
    }
}
