using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace security_program {
    public class Ecauden : ICipher {
        public string Encrypt(string plaintext, Dictionary<string, object> parameters) {
            int number1 = Convert.ToInt32(parameters["number1"]);
            int number2 = Convert.ToInt32(parameters["number2"]);
            int gcd = FindGCD(number1, number2);
            return gcd.ToString();
        }

        public string Decrypt(string ciphertext, Dictionary<string, object> parameters) {
            // Ecauden does not have a decryption process in the traditional sense
            return "Decryption not applicable for Ecauden cipher";
        }

        private int FindGCD(int num1, int num2) {
            while (num2 != 0) {
                int temp = num2;
                num2 = num1 % num2;
                num1 = temp;
            }
            return num1;
        }
    }
}
