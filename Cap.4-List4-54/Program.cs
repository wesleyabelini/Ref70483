using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap._4_List4_54
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = { 1, 2, 5, 8, 11 };

            var result = from d in data where d % 2 == 0 select d;

            // OR

            var result2 = data.Where(d => d % 2 == 0);

            foreach(int i in result)
            {
                Console.WriteLine(i);
            }
        }

    }
}

// A LINQ select query
// http://code.msdn.microsoft.com/101-LINQ-Samples-3fb9811b
