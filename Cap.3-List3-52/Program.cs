using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap._3_List3_52
{
    class Program
    {
        const int numberOfIterations = 100000;

        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            Algorithm1();
            sw.Stop();

            Console.WriteLine(sw.Elapsed);

            sw.Reset();
            sw.Start();
            Algorithm2();
            sw.Stop();

            Console.WriteLine(sw.Elapsed);
            Console.WriteLine("Ready...");
            Console.ReadLine();
        }

        private static void Algorithm1()
        {
            StringBuilder sb = new StringBuilder();
            for(int x=0; x< numberOfIterations; x++)
            {
                sb.Append('a');
            }

            string result = sb.ToString();
        }

        private static void Algorithm2()
        {
            string result = "";

            for(int x=0; x< numberOfIterations; x++)
            {
                result += 'a';
            }
        }
    }
}
/*
 * Using StopWatch class to calc some time of a method
 * */
