using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap._3_List3_43
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.FirstName = "TESTE";
        }
    }
    [DebuggerDisplay("Name={FirstName} {LastName")]
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
