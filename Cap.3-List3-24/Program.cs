using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Cap._3_List3_24
{
    class Program
    {
        static void Main(string[] args)
        {
            SignAndVerify();
        }

        public static void SignAndVerify()
        {
            string textToSign = Console.ReadLine();
            byte[] signature = Sign(textToSign, "cn=WouterDeKort");
            //Uncomment this line to make the verirfication step fai8l
            //signature[0] = 0;

            Console.WriteLine(Verify(textToSign, signature));
        }

        static byte[] Sign(string text, string certSubject)
        {
            X509Certificate2 cert = GetCertificate();
            var csp = (RSACryptoServiceProvider)cert.PrivateKey;
            byte[] hash = HashData(text);

            return csp.SignHash(hash, CryptoConfig.MapNameToOID("SHA1"));
        }

        static bool Verify(string text, byte[] signature)
        {
            X509Certificate2 cert = GetCertificate();
            var csp = (RSACryptoServiceProvider)cert.PublicKey.Key;
            byte[] hash = HashData(text);

            return csp.VerifyHash(hash, CryptoConfig.MapNameToOID("SHA1"), signature);
        }

        private static byte[] HashData(string text)
        {
            HashAlgorithm hashAlgorithm = new SHA1Managed();
            UnicodeEncoding encoding = new UnicodeEncoding();
            byte[] data = encoding.GetBytes(text);
            byte[] hash = hashAlgorithm.ComputeHash(data);

            return hash;
        }

        private static X509Certificate2 GetCertificate()
        {
            X509Store my = new X509Store("testCertStore", StoreLocation.CurrentUser);
            my.Open(OpenFlags.ReadOnly);

            var certificate = my.Certificates[0];

            return certificate;
        }
    }
}

/*
 * Signing and verifying data with a certificate
 * 
 * Digital certificates are the area where both hashing and asymmetric encryption come together.
 * A digital certificate authenticas the identity of any objects signed by the certificate.
 * It also help with protecting the integrity of data.
 * " Alice sends a message to Bob, she first hashes her message to generat a hash code. Alice then encrypts the hash code 
 *      with her private key to create a personal signature. Bob receives Alice's message and signature.
 *      He decrypts the signature using Alice's public key and now he has both the message and the hash code.
 *      He can then hash the message end see whther his shash code and the hash code from Alice match.
 *      */
