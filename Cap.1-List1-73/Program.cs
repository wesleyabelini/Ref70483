using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap._1_List1_73
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person>.Enumerator e = people.GetEnumerator();

            try
            {
                Person v;

                while (e.MoveNext())
                {
                    v = e.Current;
                }
            }
            finally
            {
                System.IDisposable d = e as System.IDisposable;
                if (d != null)
                {
                    d.Dispose();
                }
            }
        }
    }

    public class Person
    {

    }
}
