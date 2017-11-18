using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Cap._1_List1_5
{
    public static class Program
    {
        /*este atributo é necessário para que force valores diferentes 
         * para cada valor de _field
         *
         *Caso contrário o valor se repetiria em todos os casos*/
        [ThreadStatic] 
        public static int _field;
        static void Main(string[] args)
        {
            new Thread(() =>
            {
                for (int x = 0; x < 10; x++)
                {
                    _field++;
                    Console.WriteLine("Thread A: {0}", _field);
                }
            }).Start();

            new Thread(() =>
            {
                for (int x = 0; x < 10; x++)
                {
                    _field++;
                    Console.WriteLine("Thread B: {0}", _field);
                }
            }).Start();

            Console.ReadKey();
        }
    }
}
