using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap2._List2_41
{
    class Program
    {
        static void Main(string[] args)
        {
            ExampleImplementation example = new ExampleImplementation();
            int valor = example.Value;
            string valor2 = example.GetResult();
        }
    }

    interface IExample
    {
        string GetResult();
        int Value { get; set; }
        event EventHandler ResultRetrieved;
        int this[string index] { get;set; }
    }

    class ExampleImplementation : IExample
    {
        public int this[string index]
        {
            get { return 42; }
            set { }
        }

        public int Value { get; set; }

        public event EventHandler CalculationPerformed;
        public event EventHandler ResultRetrieved;

        public string GetResult()
        {
            return "result";
        }
    }
}
