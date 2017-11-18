using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap._1_List1_30
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ConcurrentBag<int> bag = new ConcurrentBag<int>();

            bag.Add(42);
            bag.Add(21);

            int result;

            if(bag.TryPeek(out result))
            {
                Console.WriteLine("There is a next item: {0}", result);
            }

            /*
             * Peed() - Retorna o próximo objeto de bag sem remover
             * Take() - Removerá um objeto de bag e mostrará este objeto removido
             * */
        }
    }
}
