using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap._2_List2_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int? a = null;      // ? representa que esta variável aceita valores null

            int b = a ?? 0;     // esta operação diz se 'a = null' >> 'b = 0' como default

            Console.WriteLine(b);
        }

        struct Nullable<T> where T: struct
        {
            private bool hasValue;
            private T value;

            public Nullable(T value)
            {
                this.hasValue = true;
                this.value = value;
            }

            public bool HasValue { get { return this.hasValue; } }
            public T Value
            {
                get
                {
                    if (!this.HasValue) throw new ArgumentException();
                        return this.value;
                }
            }

            public T GetValueOrDefault()
            {
                return this.value;
            }
        }
    }
}

/*
 * Generic Nullable<T> implementation
 * 
 * where T: struct >> The type argument must be a value type (only Nullable is not allowed
 * where T: class  >> The type argument must be a reference type: ex: class, interface, delegate or array
 * where T: new()  >> The type must have a public default constructor
 * where T: <base class name> >> The type argument must be or derive from the specified interface
 * where T: U >> The type argument supplied for T must be or derive from the argument supplied for U
 * 
 * For more information. see 2.2 . Consume types, later
 */
