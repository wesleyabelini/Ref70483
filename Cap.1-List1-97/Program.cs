using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Cap._1_List1_97
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * This method can be used to throw an exception and preserve the original stack trace.
             * */

            ExceptionDispatchInfo possibleException = null;
            try
            {
                string s = Console.ReadLine();
                int.Parse(s);
            }
            catch(FormatException ex)
            {
                possibleException = ExceptionDispatchInfo.Capture(ex);
            }

            if(possibleException!= null)
            {
                possibleException.Throw();
            }
        }
    }
}

/*
 * Using ExceptionDispatchInfo
 * */


