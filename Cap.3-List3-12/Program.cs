using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap._3_List3_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsJson(Console.ReadLine()));
        }
        public static bool IsJson(string input)
        {
            input = input.Trim();
            return input.StartsWith("{") && input.EndsWith("}") || input.StartsWith("[") && input.EndsWith("]");
        }
    }
}

/*
 * Seeing whether a string contains potential JSON data
 * */
