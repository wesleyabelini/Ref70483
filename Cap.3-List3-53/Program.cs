using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap._3_List3_53
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press scape key to stop");

            using (PerformanceCounter pc = new PerformanceCounter("Memory", "Available Bytes"))
            {
                string text = "Available memory: ";
                Console.WriteLine(text);
                do
                {
                    while (!Console.KeyAvailable)
                    {
                        Console.WriteLine(pc.RawValue);
                        Console.SetCursorPosition(text.Length, Console.CursorTop);
                    }
                } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
            }
        }
    }
}

/*
 * Windows Performance Monitor
 * 
 * Reading data from a performance counter
 * */
