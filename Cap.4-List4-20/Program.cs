using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap._4_List4_20
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\temp\test.txt";

            try
            {
                ReadAllText(path);
            }
            catch (DirectoryNotFoundException) { }
            catch (FileNotFoundException) { }
            
        }

        public static string ReadAllText(string path)
        {
            if (!File.Exists(path))
            {
                return File.ReadAllText(path);
            }

            return string.Empty;
        }
    }
}
