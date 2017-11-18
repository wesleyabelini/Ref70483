using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap._2_List2_24
{
    class Program
    {
        static void Main(string[] args)
        {
            Money money = new Money(53);

            decimal decimalmoney = money;
            int intmodeney = (int)money;

            int value = Convert.ToInt32("42");
            value = int.Parse("42");
            bool success = int.TryParse("42", out value); // verifica se valor de entrada igual out value. if = success = true
        }
    }

    class Money
    {
        public decimal Amount { get; set; }

        public Money(decimal amount)
        {
            Amount = amount;
        }

        public static implicit operator decimal(Money money)
        {
            //inplicit convert to decimal
            return money.Amount;
        }

        public static explicit operator int(Money money)
        {
            //explicit convert to int
            return (int)money.Amount;
        }
    }
}
