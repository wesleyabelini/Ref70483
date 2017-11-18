using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap._2_List2_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Base bases = new Base();
            Console.WriteLine(bases.MyMethod());

            Derived derived = new Derived();
            Console.WriteLine(derived.MyMethod());

            Derived2 derived2 = new Derived2();
            Console.WriteLine(derived2.MyMethod());
        }
    }

    class Base
    {
        public virtual int MyMethod()
        {
            return 42;
        }
    }
    
    class Derived : Base
    {
        public override int MyMethod()
        {
            return base.MyMethod() * 2;
        }
    }

    class Derived2: Derived
    {
        //This line would give a compile error
        public override int MyMethod()
        {
            return 1;
        }
    }
}

/*
 * Override a virtual method
 * */
