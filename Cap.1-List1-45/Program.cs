using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Cap._1_List1_45
{
    public class Program
    {
        static void Main(string[] args)
        {
            Task longRunning = Task.Run(() =>
            {
                Thread.Sleep(10000);
            });

            int index = Task.WaitAny(new[] { longRunning }, 5000);

            if (index == -1)
            {
                Console.WriteLine("Task time out");
            }
        }
    }
}

/*
 * É iniciada uma tarefa de 10s.
 * O processo é finalizado por time out em 5s, assim,
 * finalizando o processo
 * */
