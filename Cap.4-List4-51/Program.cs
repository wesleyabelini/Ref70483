using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap._4_List4_51
{
    class Program
    {
        static void Main(string[] args)
        {
            //this is a annonymous method

            Func<int, int> myDelegate = delegate (int x)
            {
                return x * 2;
            };

            //Step 2, is the same up code

            Func<int, int> myDelegateInLambda = x => x * 2;

            // => this can read as "becomes" or "for whick"

            Console.WriteLine(myDelegate(Convert.ToInt32(Console.ReadLine())));
            Console.WriteLine(myDelegateInLambda(Convert.ToInt32(Console.ReadLine())));
        }
    }
}

/*
 * Lambda expressions
 * Lambda introduce a shorthand notation for creating anonymous funcions.
 * The same code can be written by using a lambda:                           << >>   Step 2
 * */
