using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chap._1_List1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(new ThreadStart(ThreadMethod));
            t.Start();

            for(int i=0; i<4; i++)
            {
                Console.WriteLine("Main Thread: Do some work.");
                
            }
            //este metodo espera a finalização de todo o trabalho
            t.Join(); 
        }

        public static void ThreadMethod()
        {
            for(int i=0; i<10; i++)
            {
                Console.WriteLine("ThreadProc: {0}", i);
                Thread.Sleep(0);
            }
        }
    }
}
