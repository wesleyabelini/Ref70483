using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap._4_List4_85
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person { Id = 1, Name = "Name1" };
            Person p2 = new Person { Id = 2, Name = "Name2" };
            Person p3 = new Person { Id = 3, Name = "Name3" };

            var dict = new Dictionary<int, Person>();
            dict.Add(p1.Id, p1);
            dict.Add(p2.Id, p2);
            dict.Add(p3.Id, p3);

            foreach(KeyValuePair<int, Person> v in dict)
            {
                Console.WriteLine("{0}: {1}", v.Key, v.Value.Name);
            }

            dict[0] = new Person { Id = 4, Name = "Name4" };

            Person result;

            if(!dict.TryGetValue(5, out result))
            {
                Console.WriteLine("No Person with a key of 5 can be found");
            }
        }
    }

    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
