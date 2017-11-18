using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap._1_List1_77
{
    class Program
    {
        
        static void Main(string[] args)
        {
            CovarianceDele del = new CovarianceDele();
            StreamWriter a = del.MethodStream();
            StringWriter b = del.MethodString();
        }
    }

    public class CovarianceDele
    {
        public delegate TextWriter CovarianceDel();
        public StreamWriter MethodStream() { return null; }
        public StringWriter MethodString() { return null; }
    }
}
