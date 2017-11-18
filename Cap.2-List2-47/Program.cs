using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap._2_List2_47
{
    class Program
    {
        static void Main(string[] args)
        {
            Base b = new Base();
            b.Execute();
            b = new Derived();
            b.Execute();

            Derived dev = new Derived();
            dev.Execute();
        }
    }

    class Base
    {
        public void Execute()
        {
            string a = Console.ReadLine();
        }
    }

    class Derived : Base
    {
        public new void Execute()
        {
            Console.WriteLine("Before executing");
            base.Execute();
            Console.WriteLine("After executing");
        }
    }
}
