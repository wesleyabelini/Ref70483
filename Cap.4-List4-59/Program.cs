using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap._4_List4_59
{
    class Program
    {
        static void Main(string[] args)
        {
            //Error here

            Order orders = new Order
            {
                OrderLines =
                {
                    new OrderLine { Amount=3, Product =
                        {
                            Price =10,
                            Description ="camisa"
                        }
                    },
                    new OrderLine
                {
                    Amount =5,
                    Product =
                    {
                        Price =8,
                        Description ="calça"
                    }
                } }
            };

            OrderLine orderlines = new OrderLine
            {
                Amount = 10,
                Product =
                {
                    Description="Calça", Price=10,
                }
            };

            var result = from l in o.orderlines
                         group l by l.Product into p
                         select new
                         {
                             Product = p.key,
                             Amount = p.Sum(x => x.Amount)
                         };

        }
    }

    public class Product
    {
        public string Description { get; set; }
        public decimal Price { get; set; }
    }

    public class OrderLine
    {
        public int Amount { get; set; }
        public Product Product { get; set; }
    }

    public class Order
    {
        public List<OrderLine> OrderLines { get; set; }
    }
}
