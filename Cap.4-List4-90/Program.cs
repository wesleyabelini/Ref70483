using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap._4_List4_90
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public static class PeopleCollection : List<Person>
    {
        public void RemoveByAge(int age)
        {
            for(int index = this.Count - 1; index > 0; index--)
            {
                if(this[index].Age == age)
                {
                    this.RemoveAt(index);
                }
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach(Person p in this)
            {
                sb.AppendFormat("{0} {1} is {2}", p.FirstName, p.LasttName, p.Age);
            }

            return sb.ToString();
        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LasttName { get; set; }
        public int Age { get; set; }

        Person p1 = new Person
        {
            FirstName = "John",
            LasttName = "Doe",
            Age = 42
        };

        Person p2 = new Person
        {
            FirstName = "Jane",
            LasttName = "Doe",
            Age = 21,
        };
    }
}
