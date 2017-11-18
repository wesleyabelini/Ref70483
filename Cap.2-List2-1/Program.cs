using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap._2_List2_1
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        [Flags]
        enum Days
        {
            None=0x0,
            Sunday=0x1,
            Monday=0x2,
            Tuesday=0x4,
            Wednesday=0x8,
            Thursday= 0x10,
            Friday=0x20,
            Saturday=0x40
        }
        Days readingDays = Days.Monday | Days.Saturday;
    }
}

/*
 * Using the FlagAttribute fo an enum
 * 
 * More info 2.5 > Find, Execute and Create types
 * */
