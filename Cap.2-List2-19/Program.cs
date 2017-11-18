using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap._2_List2_19
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 42;
            object o = i; //boxing

            int x = (int)o; //unboxing

            Console.WriteLine(i + " " + o + " " + x);
        }
    }
}

/*
 * Boxing is the process of taking a value type, putting it inside a new object on the heap, and storing a reference to int on the stack.
 * Unboxing is the opposite: It takes the item from the heap and returns a value type that contains the value from the heap.
 * */
