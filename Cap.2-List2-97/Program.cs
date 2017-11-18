using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Cap._2_List2_97
{
    class Program
    {
        static void Main(string[] args)
        {
            //Display a number with a currency format string

            double cost = 1234.56;
            Console.WriteLine(cost.ToString("C", new CultureInfo("en=US")));

            //Display a Datetime with different format strings

            DateTime d = new DateTime(2013, 4, 22);
            CultureInfo provider = new CultureInfo("en-US");

            Console.WriteLine(d.ToString("d", provider)); // 4/22/2013
            Console.WriteLine(d.ToString("D", provider)); // Monday, April 22, 2013
            Console.WriteLine(d.ToString("M", provider)); // April 22
        }
    }
}
