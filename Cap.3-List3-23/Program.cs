using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Cap._3_List3_23
{
    class Program
    {
        static void Main(string[] args)
        {
            string hash = "";

            UnicodeEncoding byteCoverter = new UnicodeEncoding();
            SHA256 sha = SHA256.Create();

            string data = Console.ReadLine();
            byte[] hashA = sha.ComputeHash(byteCoverter.GetBytes(data));

            foreach(var code in hashA)
            {
                hash += code.ToString("x");
            }

            Console.WriteLine();
        }
    }
}

/*
 * Using sha256Managed to calculate a hash code
 * */
