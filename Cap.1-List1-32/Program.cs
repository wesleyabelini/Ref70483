using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap._1_List1_32
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            ConcurrentStack<int> stack = new ConcurrentStack<int>();
            stack.Push(42);

            int result;

            if(stack.TryPop(out result))
            {
                //result retorna 42
                Console.WriteLine("Popped: {0}", result);
                //stacj recebe valores abaixo
                stack.PushRange(new int[] { 1, 2, 3 });

                int[] values = new int[2];
                stack.TryPopRange(values);

                foreach(int i in values)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

/*
 * stack recebe os valores e quando é chamado TryPopRange é chamado OS valores que estão no topo "ultimos"
 * TryPop retira o valor do topo 'ultimo'
 * */
