using System;
using System.Security.Cryptography;
using System.Text;

namespace _32_Symmetric_Asymmetric_Encryption
{
    public static class AsymmetricEncryption
    {
        public static void GetExample()
        {
            const string messageFromLuisToFelipe = "Hi, Felipe.";

            var messageBytes = Encoding.ASCII.GetBytes(messageFromLuisToFelipe);

            // Generating Felipe's public and private key
            using (var rsaCryptoServiceProviderWriter = new RSACryptoServiceProvider())
            {
                // Exporting public and private parameters
                var publicParameters = rsaCryptoServiceProviderWriter.ExportParameters(false);
                var privateParameters = rsaCryptoServiceProviderWriter.ExportParameters(true);

                // Luis uses Felipe's public key to encrypt the message.
                var encryptedData = EncryptMessage(messageBytes, publicParameters);

                // Felipe uses its own private key to decrypt the message
                var decryptedData = DecryptMessage(encryptedData, privateParameters);

                Console.WriteLine($"Message from Luis decrypted using Felipe's private key: {Encoding.UTF8.GetString(decryptedData)}");
            }
        }

        private static byte[] EncryptMessage(byte[] messageBytes, RSAParameters rsaParameters) {
            byte[] encryptedData;

            using (var rsaCryptoServiceProviderWriter = new RSACryptoServiceProvider())
            {
                rsaCryptoServiceProviderWriter.ImportParameters(rsaParameters);

                encryptedData = rsaCryptoServiceProviderWriter.Encrypt(messageBytes, false);
            }

            return encryptedData;
        }

        private static byte[] DecryptMessage(byte[] encryptedMessageBytes, RSAParameters rsaParameters)
        {
            byte[] decryptedMessage;

            using (var rsaCryptoServiceProviderReader = new RSACryptoServiceProvider())
            {
                rsaCryptoServiceProviderReader.ImportParameters(rsaParameters);

                decryptedMessage = rsaCryptoServiceProviderReader.Decrypt(encryptedMessageBytes, false);
            }

            return decryptedMessage;
        }
    }
}
