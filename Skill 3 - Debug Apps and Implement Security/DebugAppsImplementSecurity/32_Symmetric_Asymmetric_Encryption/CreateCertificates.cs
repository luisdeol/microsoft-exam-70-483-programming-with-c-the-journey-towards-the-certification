using System;
using System.IO;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace _32_Symmetric_Asymmetric_Encryption
{
    public static class CreateCertificates
    {
        public static void GetExample()
        {
            var ecdsa = ECDsa.Create();
            var certificateRequest = new CertificateRequest("cn=luisdeol", ecdsa, HashAlgorithmName.SHA256);
            var certificate = certificateRequest.CreateSelfSigned(DateTimeOffset.Now, DateTimeOffset.Now.AddYears(1));

            var baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

            // Saving CER file, containing public key.
            var base64StringCerContent = Convert.ToBase64String(certificate.Export(X509ContentType.Cert), Base64FormattingOptions.InsertLineBreaks);
            var cerContent = "-----BEGIN CERTIFICATE-----\r\n"
                + base64StringCerContent
                + "\r\n-----END CERTIFICATE-----";
            File.WriteAllText($"{baseDirectory}certificate.cer", cerContent);

            // Saving PFX file, containing private key.
            var pfxBytes = certificate.Export(X509ContentType.Pfx, "1ns3rt@g00dp@ssw0rd");
            File.WriteAllBytes($"{baseDirectory}certificate.pfx", pfxBytes);
        }
    }
}
