using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Cap._4_List4_44
{
    class Program
    {
        static void Main(string[] args)
        {
            StringWriter stream = new StringWriter();

            using (XmlWriter writer = XmlWriter.Create(stream, new XmlWriterSettings() { Indent = true }))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("People");
                writer.WriteStartElement("Person");
                writer.WriteAttributeString("firstname", "John");
                writer.WriteAttributeString("lastname", "Doe");
                writer.WriteStartElement("ContactDetails");
                writer.WriteElementString("emailaddress", "john@unknown.com");
                writer.WriteEndElement();
                writer.WriteEndElement();
                writer.Flush();
            }

            FileStream file = File.Create(@"C:\temp\person.xml");
            byte[] dados = Encoding.UTF8.GetBytes(stream.ToString());
            file.Write(dados, 0, dados.Length);

            Console.WriteLine(stream.ToString());
        }
    }
}

/*
 * 
 * Creating an XML file with XMLWriter
 * */
