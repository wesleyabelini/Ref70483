using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Cap._3_List3_27
{
    class Program
    {
        static void Main(string[] args)
        {
            //Set SecureString

            using(SecureString ss = new SecureString())
            {
                Console.WriteLine("Please enter password: ");
                while (true)
                {
                    ConsoleKeyInfo cki = Console.ReadKey(true);

                    if(cki.Key == ConsoleKey.Enter)
                    {
                        break;
                    }

                    ss.AppendChar(cki.KeyChar);
                    Console.Write("*");
                }

                ss.MakeReadOnly();
                ConvertToUnsecureString(ss);
            }
        }

        public static void ConvertToUnsecureString(SecureString securePassword)
        {
            //Getting the value

            IntPtr unmanagedString = IntPtr.Zero;

            try
            {
                unmanagedString = Marshal.SecureStringToGlobalAllocUnicode(securePassword);
                Console.WriteLine(Marshal.PtrToStringUni(unmanagedString));
            }
            finally
            {
                Marshal.ZeroFreeGlobalAllocUnicode(unmanagedString);
            }
        }
    }
}
/*
 * Initializing a SecureString and Getting the value of a SecureString
 * */
