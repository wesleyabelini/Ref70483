using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap._2_List2_91
{
    class Program
    {
        static void Main(string[] args)
        {
            // IndexOf()
            string valor = "My Sample Value";
            int indexOfp = valor.IndexOf('p');
            int lastIndexOfm = valor.LastIndexOf("m");

            //primeira e ultima letra

            if (valor.StartsWith("M"))
            {
                Console.WriteLine("Valor inicia com M");
            }

            if (valor.EndsWith("e"))
            {
                Console.WriteLine("Valor termina com e");
            }

            string subString = valor.Substring(3, 6); //return 'Sample'
        }
    }
}

/*
 * Best practices when working with strings >> http://msdn.microsoft.com/en-us/library/dd465121.aspx.
 * */
