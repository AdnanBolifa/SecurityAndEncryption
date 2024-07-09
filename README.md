# Security and Encrption Program

## Introduction

This project is a Windows Forms application that provides encryption and decryption functionalities for various ciphers including Caesar, PlayFair, HillCipher, RSA, Ecauden, and Vigenere. It is implemented in C# and uses a modular approach to handle different ciphers.

## Table of Contents

1. [Project Structure](#project-structure)
2. [Cipher Implementations](#cipher-implementations)
3. [User Interface](#user-interface)
4. [Input Validation](#input-validation)
5. [How to Use](#how-to-use)
6. [Examples](#examples)
7. [Dependencies](#dependencies)

## Project Structure

The project consists of the following main components:

- **Form1.cs**: The main form that handles user interactions and displays the UI.
- **ICipher.cs**: An interface defining the contract for encryption and decryption methods.
- **Cipher Implementations**: Individual classes implementing the `ICipher` interface for different ciphers:
  - `Caesar.cs`
  - `PlayFairCipher.cs`
  - `Hill.cs`
  - `RSACipher.cs`
  - `Ecauden.cs`
  - `Vigenere.cs`

## Cipher Implementations

Each cipher class implements the `ICipher` interface, which contains the following methods:

```csharp

public interface ICipher {
    string Encrypt(string plaintext, Dictionary<string, object> parameters);
    string Decrypt(string ciphertext, Dictionary<string, object> parameters);
}
```
Caesar Cipher
The Caesar cipher shifts each character in the plaintext by a fixed number of positions in the alphabet.

PlayFair Cipher
The PlayFair cipher encrypts pairs of letters using a 5x5 matrix of letters constructed using a keyword.

Hill Cipher
The Hill cipher uses linear algebra (matrix multiplication) to encrypt blocks of plaintext.

RSA Cipher
The RSA cipher is an asymmetric cryptographic algorithm that uses a pair of keys for encryption and decryption.

Ecauden Cipher
The Ecauden cipher finds the Greatest Common Divisor (GCD) of two numbers.

Vigenere Cipher
The Vigenere cipher uses a keyword to shift the positions of the characters in the plaintext.

User Interface
The UI consists of textboxes for inputting plaintext, ciphertext, keys, and parameters. The user selects the desired cipher from a dropdown menu and can then perform encryption or decryption.

UI Components
cipher_type (ComboBox): Dropdown for selecting the cipher.
plaintextTextBox (TextBox): Input for plaintext.
ciphertextTextBox (TextBox): Input for ciphertext.
keyTextBox (TextBox): Input for the key.
pTextBox, qTextBox, eTextBox (TextBoxes): Inputs for RSA parameters.
encryption_Click (Button): Button to trigger encryption.
Decryption_Click (Button): Button to trigger decryption.
Input Validation
To ensure valid input, each cipher has specific validation logic implemented in the Form1 class:

```csharp
private bool ValidateInputs(string selectedCipher) {
    if (selectedCipher == "Ceaser") {
        return ValidateCaesar();
    } else if (selectedCipher == "PlayFair") {
        return ValidatePlayFair();
    } else if (selectedCipher == "HillCipher") {
        return ValidateHillCipher();
    } else if (selectedCipher == "RSA") {
        return ValidateRSA();
    } else if (selectedCipher == "Ecauden") {
        return ValidateEcauden();
    } else if (selectedCipher == "Vigenere") {
        return ValidateVigenere();
    }
    return false;
}
```
Each validation method ensures that the inputs are in the correct format and range.

How to Use
Launch the application.
Select the desired cipher from the dropdown menu.
Enter the plaintext, key, and any other required parameters.
Click the "Encrypt" button to encrypt the plaintext.
Enter the ciphertext and the required parameters to decrypt.
Click the "Decrypt" button to decrypt the ciphertext.
Examples
Caesar Cipher
Plaintext: HELLO
Key: 3
Ciphertext: KHOOR
PlayFair Cipher
Plaintext: HELLO
Key: KEYWORD
Ciphertext: RIJVS
Hill Cipher
Plaintext: HELLO
Key: GYBNQKURP
Ciphertext: POHGL
RSA Cipher
Plaintext: 65
P: 61
Q: 53
E: 17
Ciphertext: 2790
Ecauden Cipher
Number1: 48
Number2: 18
GCD: 6
Vigenere Cipher
Plaintext: HELLO
Key: KEY
Ciphertext: RIJVS
Dependencies
.NET Framework
Windows Forms
Conclusion
This project demonstrates the implementation of various encryption algorithms using a modular approach in C#. The application provides a user-friendly interface for encrypting and decrypting messages using different ciphers, with proper input validation to ensure correct and meaningful operations.
