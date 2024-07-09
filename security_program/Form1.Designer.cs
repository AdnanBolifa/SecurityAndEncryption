namespace security_program
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cipher_type = new System.Windows.Forms.ComboBox();
            this.encryption = new System.Windows.Forms.Button();
            this.Decryption = new System.Windows.Forms.Button();
            this.plaintextTextBox = new System.Windows.Forms.RichTextBox();
            this.ciphertextTextBox = new System.Windows.Forms.RichTextBox();
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.pTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.qTextBox = new System.Windows.Forms.TextBox();
            this.eTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Keys = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Keys.SuspendLayout();
            this.SuspendLayout();
            // 
            // cipher_type
            // 
            this.cipher_type.FormattingEnabled = true;
            this.cipher_type.Location = new System.Drawing.Point(20, 48);
            this.cipher_type.Name = "cipher_type";
            this.cipher_type.Size = new System.Drawing.Size(215, 21);
            this.cipher_type.TabIndex = 0;
            // 
            // encryption
            // 
            this.encryption.Location = new System.Drawing.Point(144, 248);
            this.encryption.Name = "encryption";
            this.encryption.Size = new System.Drawing.Size(91, 31);
            this.encryption.TabIndex = 1;
            this.encryption.Text = "encrypt";
            this.encryption.UseVisualStyleBackColor = true;
            this.encryption.Click += new System.EventHandler(this.encryption_Click);
            // 
            // Decryption
            // 
            this.Decryption.Location = new System.Drawing.Point(22, 250);
            this.Decryption.Name = "Decryption";
            this.Decryption.Size = new System.Drawing.Size(91, 29);
            this.Decryption.TabIndex = 2;
            this.Decryption.Text = "decrypt";
            this.Decryption.UseVisualStyleBackColor = true;
            this.Decryption.Click += new System.EventHandler(this.Decryption_Click);
            // 
            // plaintextTextBox
            // 
            this.plaintextTextBox.Location = new System.Drawing.Point(252, 92);
            this.plaintextTextBox.Name = "plaintextTextBox";
            this.plaintextTextBox.Size = new System.Drawing.Size(197, 76);
            this.plaintextTextBox.TabIndex = 3;
            this.plaintextTextBox.Text = "";
            // 
            // ciphertextTextBox
            // 
            this.ciphertextTextBox.Location = new System.Drawing.Point(252, 200);
            this.ciphertextTextBox.Name = "ciphertextTextBox";
            this.ciphertextTextBox.Size = new System.Drawing.Size(197, 73);
            this.ciphertextTextBox.TabIndex = 4;
            this.ciphertextTextBox.Text = "";
            // 
            // keyTextBox
            // 
            this.keyTextBox.Location = new System.Drawing.Point(56, 25);
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.Size = new System.Drawing.Size(132, 20);
            this.keyTextBox.TabIndex = 5;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(19, 25);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(31, 13);
            this.label.TabIndex = 6;
            this.label.Text = "Key: ";
            // 
            // pTextBox
            // 
            this.pTextBox.Location = new System.Drawing.Point(56, 51);
            this.pTextBox.Name = "pTextBox";
            this.pTextBox.Size = new System.Drawing.Size(132, 20);
            this.pTextBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "P: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Q: ";
            // 
            // qTextBox
            // 
            this.qTextBox.Location = new System.Drawing.Point(56, 81);
            this.qTextBox.Name = "qTextBox";
            this.qTextBox.Size = new System.Drawing.Size(132, 20);
            this.qTextBox.TabIndex = 10;
            // 
            // eTextBox
            // 
            this.eTextBox.Location = new System.Drawing.Point(56, 116);
            this.eTextBox.Name = "eTextBox";
            this.eTextBox.Size = new System.Drawing.Size(132, 20);
            this.eTextBox.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "e: ";
            // 
            // Keys
            // 
            this.Keys.Controls.Add(this.label);
            this.Keys.Controls.Add(this.eTextBox);
            this.Keys.Controls.Add(this.keyTextBox);
            this.Keys.Controls.Add(this.label3);
            this.Keys.Controls.Add(this.pTextBox);
            this.Keys.Controls.Add(this.qTextBox);
            this.Keys.Controls.Add(this.label1);
            this.Keys.Controls.Add(this.label2);
            this.Keys.Location = new System.Drawing.Point(21, 86);
            this.Keys.Name = "Keys";
            this.Keys.Size = new System.Drawing.Size(214, 156);
            this.Keys.TabIndex = 13;
            this.Keys.TabStop = false;
            this.Keys.Text = "Keys";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(249, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Plain Text";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(249, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Cipher Text";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Ciphers";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 339);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Keys);
            this.Controls.Add(this.ciphertextTextBox);
            this.Controls.Add(this.plaintextTextBox);
            this.Controls.Add(this.Decryption);
            this.Controls.Add(this.encryption);
            this.Controls.Add(this.cipher_type);
            this.Name = "Form1";
            this.Text = "my project for abd almotleb alapor";
            this.Keys.ResumeLayout(false);
            this.Keys.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cipher_type;
        private System.Windows.Forms.Button encryption;
        private System.Windows.Forms.Button Decryption;
        private System.Windows.Forms.RichTextBox plaintextTextBox;
        private System.Windows.Forms.RichTextBox ciphertextTextBox;
        private System.Windows.Forms.TextBox keyTextBox;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox pTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox qTextBox;
        private System.Windows.Forms.TextBox eTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox Keys;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

