using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap._4_List4_57
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkOrderBy();
            multipleLinqFrom();
        }

        public static void LinkOrderBy()
        {
            int[] data = { 1, 2, 5, 8, 11 };
            var result = from d in data
                         where d > 5
                         orderby d descending
                         select d;

            Console.WriteLine(string.Join(",", result));
        }

        public static void multipleLinqFrom()
        {
            int[] data1 = { 1, 2, 5 };
            int[] data2 = { 2, 4, 6 };

            var result = from d1 in data1
                         from d2 in data2
                         select d1 * d2;

            Console.WriteLine(string.Join(",", result));
        }
    }
}
