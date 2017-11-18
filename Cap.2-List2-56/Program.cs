using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap._2_List2_56
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }

    class People : IEnumerable<Person>
    {
        Person[] people;
        public People(Person[] people)
        {
            this.people = people;
        }
        public IEnumerator<Person> GetEnumerator()
        {
            for(int index=0; index < people.Length; index++)
            {
                /*
                 * Yield is a special keyword that can be used only in the context of iterators.
                 * It instructs the compiler to convert this regular code to a state machine.
                 * */
                yield return people[index];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

/*
 * Implementing IEnumerable<T> on a custom type
 * */
