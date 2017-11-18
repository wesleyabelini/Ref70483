using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap1._List1_72
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new List<Person>
            {
                new Person(){FirstName="John", LastName="Doe"},
                new Person(){ FirstName="Jane", LastName="Doe"},
            };

            foreach (Person p in people)
            {
                p.LastName = "Changed"; //This is allowed
                //p = new Person(); // This gives a compile error
            }
        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
