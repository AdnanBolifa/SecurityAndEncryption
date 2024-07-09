using System;
using System.Collections.Generic;

namespace security_program {
    public interface ICipher {
        string Encrypt(string plaintext, Dictionary<string, object> parameters);
        string Decrypt(string ciphertext, Dictionary<string, object> parameters);
    }
}
