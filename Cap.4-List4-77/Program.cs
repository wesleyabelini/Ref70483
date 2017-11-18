using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace Cap._4_List4_77
{
    class Program
    {
        static void Main(string[] args)
        {
            //Use DataContractSerializer

            PersonDataContract p = new PersonDataContract
            {
                Id = 1,
                Name = "John Doe"
            };

            SerializeXML(p);
            SerializeJSON(p);
        }

        public static void SerializeXML(PersonDataContract p)
        {
            using (Stream stream = new FileStream("data.xml", FileMode.Create))
            {
                DataContractSerializer ser = new DataContractSerializer(typeof(PersonDataContract));
                ser.WriteObject(stream, p);
            }

            using (Stream stream = new FileStream("data.xml", FileMode.Open))
            {
                DataContractSerializer ser = new DataContractSerializer(typeof(PersonDataContract));
                PersonDataContract result = (PersonDataContract)ser.ReadObject(stream);
            }
        }

        public static void SerializeJSON(PersonDataContract p)
        {
            using(MemoryStream strem = new MemoryStream())
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(PersonDataContract));
                ser.WriteObject(strem, p);

                strem.Position = 0;
                StreamReader reader = new StreamReader(strem);
                Console.WriteLine(reader.ReadToEnd());

                strem.Position = 0;
                PersonDataContract result = (PersonDataContract)ser.ReadObject(strem);
            }
        }
    }

    [DataContract]
    public class PersonDataContract
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        private bool isDirty = false;
    }
}

/*
 * DataContract is used when you use WCF and can serialize your objects to xml or json.
 * */
