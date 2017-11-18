using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap._1_List1_75
{
    class Program
    {
        static void Main(string[] args)
        {
            Teste teste = new Teste();
            teste.Multicast();                      //this call a delegate

            Calcular calcular = new Calcular();
            calcular.UseDelegate();                 // this call a delegate
        }
    }

    public class Calcular
    {
        public delegate int Calculate(int x, int y);
        public int Add(int x, int y) { return x + y; }
        public int Multiply(int x, int y) { return x * y; }

        public void UseDelegate()
        {
            Calculate calc = Add;
            Console.WriteLine(calc(3, 4));

            calc = Multiply;
            Console.WriteLine(calc(3, 4));
        }
    }

    public class Teste
    {
        public void MethodOne()
        {
            Console.WriteLine("MethodOne");
        }

        public void MethodTwo()
        {
            Console.WriteLine("MethodTwo");
        }

        public delegate void Del();

        public void Multicast()
        {
            Del d = MethodOne;
            d += MethodTwo;

            d();
        }
    }
}

/*
 * Delegates are a type that defines a method signature and can contain a reference to amethod.
 * Delegates can be instantiated, passed around, and invoked.Lambda expressions, also known as anonymous methods, use the => operator and
 *  form a compact way of creating inline methods.
 * Events are a layer of syntactic sugar on top of delegates to easily implement the publish-subscribe pattern.
 * Events can be raised only from the declaring class. Users of events can only remove and add methods the invocation list.
 * You can customize events by adding a custom event accessor and by directly using the underlying delegate type.
*/
