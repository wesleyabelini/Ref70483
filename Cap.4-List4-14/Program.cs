using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap._4_List4_14
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\test.dat";

            StreamWrite(path);
            StreamRead(path);
        }

        public static void StreamWrite(string path)
        {
            // Using File.CreateText with a StreamWriter

            using (FileStream fs = File.Create(path))
            {
                string myvalue = Console.ReadLine();
                byte[] data = Encoding.UTF8.GetBytes(myvalue);
                fs.Write(data, 0, data.Length);
            }
        }

        public static void StreamRead(string path)
        {
            //Open a FileStream and decode the bytes to a string

            using(FileStream fs = File.OpenRead(path))
            {
                byte[] data = new byte[fs.Length];

                for(int index = 0; index < fs.Length; index++)
                {
                    data[index] = (byte)fs.ReadByte();
                }

                Console.WriteLine(Encoding.UTF8.GetString(data));
            }
        }

        public static void OpenTextContent(string path)
        {
            using (StreamReader reader = File.OpenText(path))
            {
                Console.WriteLine(reader.ReadLine());
            }
        }
    }
}
