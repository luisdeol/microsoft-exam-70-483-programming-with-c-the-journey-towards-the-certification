namespace _32_Symmetric_Asymmetric_Encryption.Models
{
    public class EncryptionData
    {
        public EncryptionData(byte[] key, byte[] iv, byte[] cipherText)
        {
            Key = key;
            Iv = iv;
            CipherText = cipherText;
        }

        public byte[] Key { get; private set; }
        public byte[] Iv { get; private set; }
        public byte[] CipherText { get; private set; }
    }
}
