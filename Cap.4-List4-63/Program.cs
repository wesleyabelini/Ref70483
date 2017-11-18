using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap._4_List4_63
{
    public static class Program
    {
        static void Main(string[] args)
        {
            //how implement that
        }
    }

    public static class LinqExtensions
    {
        public static IEnumerable<TSource> Wheree<TSource>(
            this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {
            foreach(TSource item in source)
            {
                if (predicate(item))
                {
                    yield return item;
                }
            }
        }
    }
}

/*
 * yield é uma facilidade da linguagem
 * Durante um looping a aplicação sabe exatamente onde está e de onde continuar.
 * for yield read chap 2
 */
