using _32_Symmetric_Asymmetric_Encryption.Models;
using System;
using System.IO;
using System.Security.Cryptography;

namespace _32_Symmetric_Asymmetric_Encryption
{
    public static class SymmetricEncryption
    {
        public static void GetExample()
        {
            const string originalMessage = "Message to be encrypted and decrypted using AES cryptography.";

            var encryptionData = EncryptMessage(originalMessage);
            var decryptedMessage = DecryptMessage(encryptionData);

            Console.WriteLine($"Original message: {originalMessage}");
            Console.WriteLine($"Decrypted message: {decryptedMessage}");
        }

        private static EncryptionData EncryptMessage(string message)
        {
            byte[] cipherText, key, iv;

            using (var aes = Aes.Create())
            {
                key = aes.Key;
                iv = aes.IV;

                var encryptor = aes.CreateEncryptor(key, iv);

                using (var memoryStream = new MemoryStream())
                {
                    using (var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                    {
                        using (var streamWriter = new StreamWriter(cryptoStream))
                        {
                            streamWriter.Write(message);
                        }

                        cipherText = memoryStream.ToArray();
                    }
                }
            }

            return new EncryptionData(key, iv, cipherText);
        }

        private static string DecryptMessage(EncryptionData encryptionData)
        {
            string decryptedMessage;

            using (var aes = Aes.Create())
            {
                var decryptor = aes.CreateDecryptor(encryptionData.Key, encryptionData.Iv);

                using (var memoryStream = new MemoryStream(encryptionData.CipherText))
                {
                    using (var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read))
                    {
                        using (var streamReader = new StreamReader(cryptoStream))
                        {
                            decryptedMessage = streamReader.ReadToEnd();
                        }
                    }
                }
            }

            return decryptedMessage;
        }
    }
}
