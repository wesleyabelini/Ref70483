using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Cap._4_List4_65
{
    class Program
    {
        static void Main(string[] args)
        {
            XDocument doc = XDocument.Load("D:\\PROJETO\\Ref70483\\Cap.4-List4-43\\Person.xml");

            IEnumerable<string>[] ienumerable = new IEnumerable<string>[2];
            ienumerable[0] = QuerySomeXML(doc);
            ienumerable[1] = WhereOrderbyLINQ(doc);

            for(int i=0; i < ienumerable.Length; i++)
            {
                foreach (string s in ienumerable[i])
                {
                    Console.WriteLine(s);
                }
            } 
        }

        public static IEnumerable<string> QuerySomeXML(XDocument doc)
        {
            // 4-65

            IEnumerable<string> personnames = from p in doc.Descendants("person")
                                              select (string)p.Attribute("firstname")
                                              + " " + (string)p.Attribute("lastname");

            return personnames;
        }

        public static IEnumerable<string> WhereOrderbyLINQ(XDocument doc)
        {
            //4-66

            IEnumerable<string> personnames = from p in doc.Descendants("person")
                                              where p.Descendants("phonenumber").Any()
                                              let name = (string)p.Attribute("firstname")
                                              + " " + (string)p.Attribute("lastname")
                                              orderby name
                                              select name;

            return personnames;
        }
    }
}
