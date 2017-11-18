using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.XPath;

namespace Cap._4_List4_45
{
    class Program
    {
        static void Main(string[] args)
        {
            string xml = @"D:\\PROJETO\\Ref70483\\Cap.4-List4-43\\Person.xml";

            XmlDocument doc = new XmlDocument();
            doc.Load(xml);

            XmlNodeList nodes = doc.GetElementsByTagName("person");

            //output the names of the people in the document
            foreach(XmlNode node in nodes)
            {
                string firstname = node.Attributes["firstname"].Value;
                string lastname = node.Attributes["lastname"].Value;

                Console.WriteLine("Name: {0} {1}", firstname, lastname);
            }

            //Start creating a new node
            XmlNode newNode = doc.CreateNode(XmlNodeType.Element, "person", "");

            XmlAttribute firstnameAttribute = doc.CreateAttribute("firstname");
            firstnameAttribute.Value = "Foo";

            XmlAttribute lastnameAttribute = doc.CreateAttribute("lastname");
            lastnameAttribute.Value = "Bar";

            newNode.Attributes.Append(firstnameAttribute);
            newNode.Attributes.Append(lastnameAttribute);

            doc.DocumentElement.AppendChild(newNode);
            Console.WriteLine("Modified xml...");
            doc.Save(Console.Out);

            XPathQuery(doc);
        }

        public static void XPathQuery(XmlDocument document)
        {
            /*
             * Using an XPath qyery
             * */

            Console.Clear();

            XPathNavigator nav = document.CreateNavigator();
            string query = "//people/person[@firstname='Jane']";
            XPathNodeIterator iterator = nav.Select(query);

            Console.WriteLine(iterator.Count);

            while (iterator.MoveNext())
            {
                string firstname = iterator.Current.GetAttribute("firstname", "");
                string lastname = iterator.Current.GetAttribute("lastname", "");

                Console.WriteLine("Name: {0} {1}", firstname, lastname);
            }

            
        }
    }
}
