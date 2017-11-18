﻿using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap._1_List1_33
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            ConcurrentQueue<int> queue = new ConcurrentQueue<int>();
            queue.Enqueue(42);

            int result;

            if(queue.TryDequeue(out result))
            {
                Console.WriteLine("Dequeued: {0}", result);
            }
        }
    }
}

/*TryDequeue() tenta remover no fim da lista 'primeiro'
 * */
