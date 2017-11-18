using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap._4_List4_48
{
    class Program
    {
        static void Main(string[] args)
        {
            //create and instantiate objecto # 1

            Person p = new Person();
            p.FirstName = "John";
            p.LastName = "Doe";

            //Create and instantiate a new object in one step #2

            Person p2 = new Person
            {
                FirstName = "John",
                LastName = "Doe"
            };

            //using a collection initializer #3

            var people = new List<Person>
            {
                new Person
                {
                    FirstName = "John",
                    LastName="Doe"
                },
                new Person
                {
                    FirstName="Jane",
                    LastName="Doe"
                }
            };
        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
