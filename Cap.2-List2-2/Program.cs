using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap._2_List2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point(3, 4);
            Console.WriteLine(point.Soma());
        }

        public struct Point
        {
            public int x, y;

            public Point(int p1, int p2)
            {
                x = p1;
                y = p2;
            }

            public int Soma()
            {
                return x + y;
            }
        }
    }
}
