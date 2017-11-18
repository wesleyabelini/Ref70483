using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap._1_List1_25
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var numbers = Enumerable.Range(0, 20);
            var parallelResult = numbers.AsParallel().AsOrdered().Where(i => i % 2 == 0).AsSequential();
            var parallelResult2 = numbers.AsParallel().AsOrdered().Where(i => i % 2 == 0);
            /*
             * Take(5) retornará apenas os 5 primeiros resultados
             * AsSequential() garante que os dados não saiam da ordem
             * */

            foreach (int i in parallelResult.Take(5))
            {
                Console.WriteLine(i);
            }

            /* OR
             * mas não deve ser utilizado AsSequencial()
             * >> Vide parallelResult2
             * */

            parallelResult2.ForAll(c => Console.WriteLine(c));
        }
    }
}
