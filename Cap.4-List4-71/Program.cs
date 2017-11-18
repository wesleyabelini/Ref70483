using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace Cap._4_List4_71
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Order), new Type[] { typeof(VIPOrder) });

            string xml;

            using(StringWriter writer = new StringWriter())
            {
                Order order = CreateOrder();
                serializer.Serialize(writer, order);
                xml = writer.ToString();

                Console.WriteLine(xml);
            }

            using(StringReader reader = new StringReader(xml))
            {
                Order o = (Order)serializer.Deserialize(reader);
            }
        }

        public static Order CreateOrder()
        {
            Product p1 = new Product { ID = 1, Description = "p2", Price = 9 };
            Product p2 = new Product { ID = 2, Description = "p3", Price = 6 };

            Order order = new VIPOrder
            {
                Id = 4,
                Description = "Order for John Doe. Use the nice giftwrap",
                OrderLines = new List<OrderLine>
                {
                    new OrderLine { ID=5, Amount=1, Product= p1 },
                    new OrderLine { ID=6, Amount=10, Product= p2 },
                }
            };

            return order;
        }
    }

    [Serializable]
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }

    [Serializable]
    public class Order
    {
        [XmlAttribute]
        public int Id { get; set; }
        [XmlIgnore]
        public bool IsDirty { get; set; }
        [XmlArray("Lines")]
        [XmlArrayItem("OrderLine")]
        public List<OrderLine> OrderLines { get; set; }
    }

    [Serializable]
    public class VIPOrder: Order
    {
        public string Description { get; set; }
    }

    [Serializable]
    public class OrderLine
    {
        [XmlAttribute]
        public int ID { get; set; }
        [XmlAttribute]
        public int Amount { get; set; }
        [XmlElement]
        public Product Product { get; set; }
    }

    [Serializable]
    public class Product
    {
        [XmlAttribute]
        public int ID { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
    }
}

/*
 * XmlIgnore    > Can be used to make sure that an element is no serialized.
 * XmlAttribute > You can map a member to an attribute on tis parent node.
 * XmlElement   > By default, each member is serialized as an XmlElement. This mean that they end up as node in your XML.
 * XmlArray     > Serializing collection
 * XmlArrayItem > Serializing collection
 * */
