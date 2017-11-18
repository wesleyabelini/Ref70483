using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Cap._4_List4_70
{
    class Program
    {
        static void Main(string[] args)
        {
            string xml;
            XmlSerializer serializer = new XmlSerializer(typeof(Person));

            using (StringWriter w = new StringWriter())
            {
                Person p = new Person
                {
                    FirstName = "John",
                    LastName = "Doe",
                    Age = 42
                };

                serializer.Serialize(w, p);
                xml = w.ToString();
            }

            Console.WriteLine(xml);

            using(StringReader reader = new StringReader(xml))
            {
                Person p = (Person)serializer.Deserialize(reader);
                Console.WriteLine("{0} {1} is {2} years old", p.FirstName, p.LastName, p.Age);
            }
        }
    }

    [Serializable]
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
}
/*
 * Serializing an object with the XMLSErializer
 * */