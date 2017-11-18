using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap._2_List2_43
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    interface IRepository<T>
    {
        T FindById(int id);
        IEnumerable<T> All();
    }
}

/*
 * Creating an interface with a generic type parameter
 * */
