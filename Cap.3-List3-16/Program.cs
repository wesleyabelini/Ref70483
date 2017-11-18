using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;

namespace Cap._3_List3_16
{
    class Program
    {
        static void Main(string[] args)
        {
            validateXML();
        }

        public static void validateXML()
        {
            string xsdPath = "person.xsd";
            string xmlPath = "person.xml";

            if (!File.Exists(xmlPath))
            {
                File.Create(xmlPath);
            }

            if (!File.Exists(xsdPath)) { File.Create(xsdPath); }

            GC.Collect();

            XmlReader reader = XmlReader.Create(xmlPath);
            XmlDocument document = new XmlDocument();
            document.Schemas.Add("", xsdPath);
            document.Load(reader);

            ValidationEventHandler eventHandler = new ValidationEventHandler(ValidationEventHandler);
            document.Validate(eventHandler);
        }

        static void ValidationEventHandler(object sender, ValidationEventArgs e)
        {
            switch (e.Severity)
            {
                case XmlSeverityType.Error:
                    Console.WriteLine("Error: {0}", e.Message);
                    break;
                case XmlSeverityType.Warning:
                    Console.WriteLine("Warning {0}", e.Message);
                    break;
            }
        }
    }
}

/*
 * Validade an xml file with a schema
 * */
