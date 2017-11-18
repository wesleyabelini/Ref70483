using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap._2_List2_7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Setando os valores do método no parêmetro, é possivel alterar ou simplesmente ignorar aceitando os valores por padrão
             * */

            MyMethod(1, thirdArument: true);
        }

        public static void MyMethod(int firstArgument, string secondArgument = "default value", bool thirdArument = false)
        {

        }
    }
}

/*
 * Using named and optional arguments
 * */
