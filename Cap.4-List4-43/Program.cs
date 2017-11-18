using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Cap._4_List4_43
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument document = new XmlDocument();
            document.Load("D:\\PROJETO\\Ref70483\\Cap.4-List4-43\\Person.xml");

            using (StringReader stringReader = new StringReader(document.OuterXml))
            {
                using (XmlReader reader = XmlReader.Create(stringReader, new XmlReaderSettings() { IgnoreWhitespace = true }))
                {
                    reader.MoveToContent();
                    reader.ReadStartElement("people");

                    string firstName = reader.GetAttribute("firstname");
                    string lastName = reader.GetAttribute("lastname");

                    Console.WriteLine("Person: {0} {1}", firstName, lastName);
                    reader.ReadStartElement("person");

                    Console.WriteLine("Contact Details");

                    reader.ReadStartElement("contactdetails");
                    string emailAddress = reader.ReadString();

                    Console.WriteLine("E-mail Address: {0}", emailAddress);
                }
            }
        }
    }

    /*
     * 
     * Parsing an XML file with an XMLReader
     * */
}