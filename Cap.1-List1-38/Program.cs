using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Cap._1_List1_38
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            object gate = new object();
            bool _lockTaken = false;

            try
            {
                Monitor.Enter(gate, ref _lockTaken);
            }
            finally
            {
                if (_lockTaken)
                {
                    Monitor.Exit(gate);
                }
            }
        }
    }
}

/*
 * Monitor gerencia o acesso ao objeto e Enter realiza todo com trabalho com o lock, 
 * aplicando diretamente no objeto.
 * */
