using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Cap._4_List4_73
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person
            {
                ID = 1,
                Name = "John Doe",
            };

            IFormatter formater = new BinaryFormatter();
            using(Stream stream = new FileStream("data.bin", FileMode.Create))
            {
                formater.Serialize(stream, p);
                StringWriter stringWriter = new StringWriter();
            }

            using(Stream strem = new FileStream("data.bin", FileMode.Open))
            {
                Person dp = (Person)formater.Deserialize(strem);
            }
        }
    }

    [Serializable]
    public class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        //[NonSerialized]       //Descoment to nonserialized
        private bool isDirty = false;

        [OnSerializing]
        internal void OnSerializingMethod(StreamingContext context)
        {
            Console.WriteLine("OnSerializing.");
        }

        [OnSerialized]
        internal void OnSerializedMethod(StreamingContext context)
        {
            Console.WriteLine("OnSerialized.");
        }
    
        [OnDeserializing]
        internal void OnDeserializingMethod(StreamingContext context)
        {
            Console.WriteLine("OnDeserializing.");
        }

        [OnDeserialized]
        internal void OnDeserialized(StreamingContext context)
        {
            Console.WriteLine("OnDeserialized.");
        }
    }

    public class PersonComplex : ISerializable
    {
        //Implementing ISerializable

        public int Id { get; set; }
        public string Name { get; set; }
        public bool isDirty = false;
        public PersonComplex() { }

        protected PersonComplex(SerializationInfo info, StreamingContext context)
        {
            Id = info.GetInt32("Value1");
            Name = info.GetString("Value2");
            isDirty = info.GetBoolean("Value3");
        }

        [System.Security.Permissions.SecurityPermission(System.Security.Permissions.SecurityAction.Demand, SerializationFormatter =true)]
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Value1", Id);
            info.AddValue("Value2", Name);
            info.AddValue("Value3", isDirty);
        }
    }
}
