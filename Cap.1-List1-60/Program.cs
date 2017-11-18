using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap._1_List1_60
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = GetValue(true);     //return 1
            int b = GetValue(false);    //return 0
            int? c = GetValue(true);    //return 1
            int? d = GetValue(false);   //return 0
        }

        private static int GetValue(bool p)
        {
            if (p) { return 1; }
            else { return p ? 1 : 0; }
        }
    }
}
