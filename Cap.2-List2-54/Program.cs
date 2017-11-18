using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap._2_List2_54
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Order> orders = new List<Order>
            {
                new Order{Created= new DateTime(2012, 12, 1)},
                new Order{Created= new DateTime(2012, 1, 6)},
                new Order{Created= new DateTime(2012, 7, 8)},
                new Order{Created= new DateTime(2012, 2, 20)}
            };

            orders.Sort();
        }
    }

    class Order : IComparable
    {
        /*
         * Esta Interface implementa CompareTo
         * */

        public int CompareTo(object obj)
        {
            if (obj == null) { return 1; }
            Order o = obj as Order;

            if (o == null)
            {
                throw new ArgumentException("Object is not an Order");
            }

            return this.Created.CompareTo(o.Created);
        }

        public DateTime Created { get; set; }
    }
}

/*
 * Implementing hte IComparable interface
 * */
