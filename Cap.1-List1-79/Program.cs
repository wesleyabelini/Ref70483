using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap._1_List1_79
{
    public static class Program
    {
        public delegate int Calculate(int x, int y);

        public static void Main(string[] args)
        {
            Calculate calc = (x, y) => x + y;
            Console.WriteLine(calc(3, 4));

            calc = (x, y) => x * y;
            Console.WriteLine(calc(3, 4));

            /* outro exemplo de lambda */

            Calculate calculate = (x, y) =>
            {
                Console.WriteLine("Adding numbers");
                return x + y;
            };

            int result = calculate(3, 4);
        }
    }
}
/*
 * Lambda utilizada para criar um delegate 
 * */
