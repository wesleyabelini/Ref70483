using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap._2_List2_81
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter stream = File.CreateText("temp.dat");
            /*ideal seria usar ... para garantir a inutilização do recurso
             * 
             * using (StreamWriter sw = File.CreateText("temp.dat")){}
             * */

            stream.Write("some data here");

            //GC.Collect();                      //> not work > exception continua
            //GC.WaitForPendingFinalizers();    //> not work

            stream.Dispose();

            File.Delete("temp.dat"); //Sem o Garbage collection >> Exception
        }
    }
}
