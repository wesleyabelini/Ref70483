using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Cap._2_List2_89
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * OUTPUT
             * */

            var stringWriter = new StringWriter();

            using (XmlWriter writer = XmlWriter.Create(stringWriter))
            {
                writer.WriteStartElement("book");
                writer.WriteElementString("price", "19.95");
                writer.WriteEndElement();
                writer.Flush();
            }

            string xml = stringWriter.ToString();

            /*
             * INPUT
             * */

            var stringReader = new StringReader(xml);

            using(XmlReader reader = XmlReader.Create(stringReader))
            {
                reader.ReadToFollowing("price");
                decimal price = decimal.Parse(reader.ReadInnerXml(), new CultureInfo("en-US"));
            }
        }
    }
}

/*
 * Using a StringWriter as the output for an XmlWriter
 * 
 * <?xml version=\”1.0\” encoding=\”utf-16\”?>
 * <book>
 *      <price>19.95</price>
 * </book>
 * */
