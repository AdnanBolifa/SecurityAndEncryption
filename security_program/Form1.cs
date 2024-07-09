using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace security_program {
    public partial class Form1 : Form {
        private Dictionary<string, ICipher> ciphers;

        public Form1() {
            InitializeComponent();
            cipher_type.Items.Add("Ceaser");
            cipher_type.Items.Add("PlayFair");
            cipher_type.Items.Add("HillCipher");
            cipher_type.Items.Add("RSA");
            cipher_type.Items.Add("Ecauden");
            cipher_type.Items.Add("Vigenere");

            ciphers = new Dictionary<string, ICipher>();
            ciphers.Add("Ceaser", new Caesar());
            ciphers.Add("PlayFair", new PlayFairCipher());
            ciphers.Add("HillCipher", new Hill());
            ciphers.Add("RSA", new RSACipher());
            ciphers.Add("Ecauden", new Ecauden());
            ciphers.Add("Vigenere", new Vigenere());
        }

        private void encryption_Click(object sender, EventArgs e) {
            string selectedCipher = cipher_type.Text.ToString();
            string plaintext = plaintextTextBox.Text;
            var parameters = new Dictionary<string, object>();

            if (selectedCipher == "Ceaser") {
                parameters["key"] = int.Parse(keyTextBox.Text);
            } else if (selectedCipher == "PlayFair") {
                parameters["key"] = keyTextBox.Text;
            } else if (selectedCipher == "HillCipher") {
                parameters["key"] = keyTextBox.Text;
            } else if (selectedCipher == "RSA") {
                parameters["p"] = int.Parse(pTextBox.Text);
                parameters["q"] = int.Parse(qTextBox.Text);
                parameters["e"] = int.Parse(eTextBox.Text);
            } else if (selectedCipher == "Ecauden") {
                parameters["number1"] = int.Parse(pTextBox.Text);
                parameters["number2"] = int.Parse(qTextBox.Text);
            } else if (selectedCipher == "Vigenere") {
                parameters["key"] = keyTextBox.Text;
            }

            string ciphertext = ciphers[selectedCipher].Encrypt(plaintext, parameters);
            ciphertextTextBox.Text = ciphertext;
        }

        private void Decryption_Click(object sender, EventArgs e) {
            string selectedCipher = cipher_type.SelectedItem.ToString();
            string ciphertext = ciphertextTextBox.Text;
            var parameters = new Dictionary<string, object>();

            // Collect parameters based on selected cipher
            if (selectedCipher == "Ceaser") {
                parameters["key"] = int.Parse(keyTextBox.Text);
            } else if (selectedCipher == "PlayFair") {
                parameters["key"] = keyTextBox.Text;
            } else if (selectedCipher == "HillCipher") {
                parameters["key"] = keyTextBox.Text;
            } else if (selectedCipher == "RSA") {
                parameters["p"] = int.Parse(pTextBox.Text);
                parameters["q"] = int.Parse(qTextBox.Text);
                parameters["e"] = int.Parse(eTextBox.Text);
            } else if (selectedCipher == "Ecauden") {
                parameters["number1"] = int.Parse(pTextBox.Text);
                parameters["number2"] = int.Parse(qTextBox.Text);
            } else if (selectedCipher == "Vigenere") {
                parameters["key"] = keyTextBox.Text;
            }

            string plaintext = ciphers[selectedCipher].Decrypt(ciphertext, parameters);
            plaintextTextBox.Text = plaintext;

        }

        private void label6_Click(object sender, EventArgs e) {

        }
    }
}
