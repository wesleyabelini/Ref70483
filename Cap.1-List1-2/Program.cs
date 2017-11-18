using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Cap._1_List1_2
{
    /*
     * Show the diference between foreground and backgrounds threads.
     * */

    class Program
    {
        public static void ThreadMethod()
        {
            for(int i=0; i<10;i++)
            {
                Console.WriteLine("ThreadProc: {0}", i);
                Thread.Sleep(1000);
            }
        }
        static void Main(string[] args)
        {
            Thread t = new Thread(new ThreadStart(ThreadMethod));
            /*if isbackground set to true, the application imediataly is closed.
             * But, if set as true, the application print 10 times
             * */
            t.IsBackground = false;
            t.Start();
        }
    }
}
