using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap._4_List4_88
{
    class Program
    {
        static void Main(string[] args)
        {
            QueueExemple();
            StackExemple();
        }

        public static void QueueExemple()
        {
            Queue<string> myQueue = new Queue<string>();
            myQueue.Enqueue("Hello");
            myQueue.Enqueue("World");
            myQueue.Enqueue("From");
            myQueue.Enqueue("A");
            myQueue.Enqueue("Queue");

            foreach (string s in myQueue)
            {
                Console.Write(s + " ");
            }
        }

        private static void StackExemple()
        {
            Stack<string> myStack = new Stack<string>();

            myStack.Push("Hello");
            myStack.Push("World");
            myStack.Push("From");
            myStack.Push("A");
            myStack.Push("Stack");

            foreach(string s in myStack)
            {
                Console.Write(s + " ");
            }
        }
    }
}

/*
 * A queue is a special type of collection you can use to temporarily store some data.
 * FIFO > First In - First Out
 * 
 * Push - add a new item to the Stack
 * Pop - get the newest item from the Stack
 * Peek - Get the newest item without removing it
 * 
 * */
