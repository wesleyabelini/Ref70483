using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap._4_List4_83
{
    class Program
    {
        static void Main(string[] args)
        {
            //4-84

            List<string> listString = new List<string> { "A", "B", "C", "D", "E" };

            for(int i=0; i < listString.Count; i++)
            {
                Console.WriteLine(listString[i]);
            }

            listString.Remove("A");
            Console.WriteLine(listString[0]);

            listString.Add("F");

            Console.WriteLine(listString.Count);

            bool hasC = listString.Contains("C");
            Console.WriteLine(hasC);
        }
    }

    public interface IList<T>: ICollection<T>, IEnumerable<T>, IEnumerable
    {
        T this[int index] { get;set; }
        int IndexOf(T item);
        void Insert(int index, T item);
        void RemoveAt(int index);
    }

    public interface ICollection<T>: IEnumerable<T>, IEnumerable
    {
        int Count { get; }
        bool IsReadOnly { get; }
        void Add(T item);
        void Clear();
        bool Contains(T item);
        void CopyTo(T[] array, int arrayIndex);
        bool Remove(T item);
    }
}
