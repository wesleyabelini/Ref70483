using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap._2_List2_16
{
    class Program
    {
        static void Main(string[] args)
        {
            string valor = Console.ReadLine();

            Product product = new Product();
            Calculator cal = new Calculator();
            product.Price = Convert.ToDecimal(valor);

            Console.WriteLine(product.Discount());                  // esse
            Console.WriteLine(cal.CalculateDiscount(product));      //igual esse
            Console.ReadLine();
        }
    }

    public class Product
    {
        public decimal Price { get; set; }
    }

    public static class MyExtension
    {
        /*
         * Esta é uma classe de Extenção onde Discount pertence a produto
         * */
        public static decimal Discount(this Product product)
        {
            return product.Price * .9M;
        }
    }

    public class Calculator
    {
        public decimal CalculateDiscount(Product p)
        {
            return p.Discount();
        }
    }

    public class Book
    {
        //not in use
        public string Nome { get; set; }
    }

    public static class Author
    {
        //not in use
        public static string NomeAuthor(this Book book)
        {
            return book.Nome = "TESTE";
        }
    }
}

/*
 * Creating a extension method
 * 
 * Extension methods need to be declared in anongeneric, non-nested, static class
 * */
