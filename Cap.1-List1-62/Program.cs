using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap._1_List1_62
{
    public static class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            CheckWithSwitch(a);
        }

        public static void CheckWithSwitch(string input)
        {
            switch (input)
            {
                case "a":
                case "e":
                case "i":
                case "o":
                case "u":
                    {
                        Console.WriteLine("Input is a vowel");
                        break;
                    }

                case "y":
                    {
                        Console.WriteLine("Input is sometimes a vower");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Input is a consonant");
                        break;
                    }
            }
        }
    }
}
