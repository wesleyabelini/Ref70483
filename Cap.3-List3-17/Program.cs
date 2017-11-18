using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Cap._3_List3_17
{
    class Program
    {
        static void Main(string[] args)
        {
            EncryptSomeText();
        }

        public static void EncryptSomeText()
        {
            Console.WriteLine("Escreva o que deseja encryptar...");
            string original = Console.ReadLine();

            using(SymmetricAlgorithm symetricalgorithm = new AesManaged())
            {
                byte[] encrypted = Encrypt(symetricalgorithm, original);
                string textCrypt = "";

                foreach(var crypt in encrypted)
                {
                    textCrypt += crypt.ToString("X2"); //convertido em hexadecimal
                }

                Console.WriteLine(textCrypt);
                Console.ReadKey();

                string roundtrip = Decrypt(symetricalgorithm, encrypted);
                Console.WriteLine(roundtrip);
                Console.ReadKey();
            }

            PublicAndPrivateKey();
        }

        public static void PublicAndPrivateKey()
        {
            /*
             * GERANDO CHAVE PUBLICA E PRIVADA
             * */   

            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            string publicKeyXML = rsa.ToXmlString(false);
            string privateKeyXML = rsa.ToXmlString(true);

            Console.WriteLine("PUBLIC KEY");
            Console.WriteLine(publicKeyXML);
            Console.WriteLine("PRIVATE KEY");
            Console.WriteLine(privateKeyXML);
        }

        static byte[] Encrypt(SymmetricAlgorithm aesAlg, string plainText)
        {
            ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

            using(MemoryStream msEncrypt = new MemoryStream())
            {
                using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                {
                    using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                    {
                        swEncrypt.Write(plainText);
                    }

                    return msEncrypt.ToArray();
                }
            }
        }

        static string Decrypt(SymmetricAlgorithm aesAlg, byte[] cipherText)
        {
            ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

            using(MemoryStream msDecrypt = new MemoryStream(cipherText))
            {
                using(CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                {
                    using(StreamReader srDecrypt = new StreamReader(csDecrypt))
                    {
                        return srDecrypt.ReadToEnd();
                    }
                }
            }
        }
    }
}
