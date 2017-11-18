using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Cap._4_List4_67
{
    class Program
    {
        static void Main(string[] args)
        {
            XElement root = XElement.Load(@"D:\\PROJETO\\Ref70483\\Cap.4-List4-43\\Person.xml");
            CreateXML();

            UpdatingXML(root);
            TransformXML(root);
        }

        public static void CreateXML()
        {
            XElement root = new XElement("Root", new List<XElement>
            {
                new XElement("Child1"),
                new XElement("Child2"),
                new XElement("Child3")
            },
            new XAttribute("MyAttribute", 422));

            root.Save("teste.xml");
        }

        public static void UpdatingXML(XElement root)
        {
            foreach(XElement p in root.Descendants("person"))
            {
                string name = (string)p.Attribute("firstname") + (string)p.Attribute("lastname");
                p.Add(new XAttribute("IsMale", name.Contains("John")));

                XElement contactDetais = p.Element("contactdetails");
                if (!contactDetais.Descendants("phonenumber").Any())
                {
                    contactDetais.Add(new XElement("phonenumber", "00225588"));
                }
            }
        }

        public static void TransformXML(XElement root)
        {
            XElement newTree = new XElement("people",
            from p in root.Descendants("person")
            let name = (string)p.Attribute("firstname") + (string)p.Attribute("lastname")
            let contactDetails = p.Element("contactdetails")
            select new XElement("person",
            new XAttribute("IsMale", name.Contains("John")),
            p.Attributes(),
            new XElement("contactdetails",
            contactDetails.Element("emailaddress"),
            contactDetails.Element("phonenumber")
            ?? new XElement("phonenumber", "112233455")
            )));
        }
    }
}
