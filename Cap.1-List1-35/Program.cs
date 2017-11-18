using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap._1_List1_35
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            int n = 0;
            object _lock = new object();

            var up = Task.Run(() =>
            {
                for (int i = 0; i < 1000000; i++)
                {
                    lock (_lock) ; 
                    n++;
                }
            });

            for(int i=0; i<1000000; i++)
            {
                lock (_lock);
                n--;
            }

            up.Wait();
            Console.WriteLine(n);
        }
    }
}

/*
 * Acessar os mesmo dados em processos diferentes.
 * No entanto apresenta algumas falhas na sincronização.
 * Continue 37
 * */
