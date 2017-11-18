using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap._1_List1_94
{
    class Program
    {
        static void Main(string[] args)
        {
            string teste = OpenAndParse(Console.ReadLine());

            Console.WriteLine(teste);
            Console.WriteLine("Press any key to exist ...");
            Console.ReadLine();
        }

        public static string OpenAndParse(string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
            {
                throw new ArgumentNullException("fileName", "Filename is required");
            }

            return File.ReadAllText(fileName);
        }
    }
}
