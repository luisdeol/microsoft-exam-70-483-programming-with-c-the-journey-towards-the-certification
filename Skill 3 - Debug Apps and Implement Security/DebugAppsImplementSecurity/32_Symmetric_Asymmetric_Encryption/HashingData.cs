using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace _32_Symmetric_Asymmetric_Encryption
{
    public static class HashingData
    {
        public static void GetExample()
        {
            var messageToBeHashed = "A message to be hashed";
            var messageBytes = Encoding.UTF8.GetBytes(messageToBeHashed);

            // Initalizing providers for some hashing algorithms
            var md5 = new MD5CryptoServiceProvider();
            var sha1 = new SHA1CryptoServiceProvider();
            var sha256 = new SHA256CryptoServiceProvider();
            var sha512 = new SHA512CryptoServiceProvider();

            var md5HashedMessage = md5.ComputeHash(messageBytes);
            var sha1HashedMessage = sha1.ComputeHash(messageBytes);
            var sha256HashedMessage = sha256.ComputeHash(messageBytes);
            var sha512HashedMessage = sha512.ComputeHash(messageBytes);

            // Let's simulate a data tampering, which would make the resulting SHA256 hash differ when compared with the original.
            TamperData(sha256HashedMessage);

            var validMd5 = VerifyMd5Hash(messageBytes, md5HashedMessage);
            var validSha1 = VerifySha1Hash(messageBytes, sha1HashedMessage);
            var validSha256 = VerifySha256Hash(messageBytes, sha256HashedMessage); // Results false, since the data was tampered.
            var validSha512 = VerifySha512Hash(messageBytes, sha512HashedMessage);

            DisplayMessage("MD5", validMd5);
            DisplayMessage("SHA1", validSha1);
            DisplayMessage("SHA256", validSha256);
            DisplayMessage("SHA512", validSha512);
        }

        public static bool VerifyMd5Hash(byte[] messageBytes, byte[] hash)
        {
            var md5 = new MD5CryptoServiceProvider();

            return md5.ComputeHash(messageBytes).SequenceEqual(hash);
        }

        public static bool VerifySha1Hash(byte[] messageBytes, byte[] hash)
        {
            var sha1 = new SHA1CryptoServiceProvider();

            return sha1.ComputeHash(messageBytes).SequenceEqual(hash);
        }

        public static bool VerifySha256Hash(byte[] messageBytes, byte[] hash)
        {
            var sha256 = new SHA256CryptoServiceProvider();

            return sha256.ComputeHash(messageBytes).SequenceEqual(hash);
        }

        public static bool VerifySha512Hash(byte[] messageBytes, byte[] hash)
        {
            var sha512 = new SHA512CryptoServiceProvider();

            return sha512.ComputeHash(messageBytes).SequenceEqual(hash);
        }

        public static void TamperData(byte[] data)
        {
            data[4] = 0x20;
        }

        public static void DisplayMessage(string algorithm, bool valid)
        {
            var message = $"Message hash using {algorithm} is {(valid ? "" : "not")} valid";

            Console.WriteLine(message);
        }
    }
}
