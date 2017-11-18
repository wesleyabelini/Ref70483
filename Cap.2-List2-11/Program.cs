using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap._2_List2_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck(42);
            List<Card> cartas = new List<Card> { new Card { Nome = "Rei", Tipo = "Copas" }, new Card { Nome = "Valete", Tipo = "Espadilha" } };
            deck.Cards.AddRange(cartas);
        }
    }

    public class Deck
    {
        private int _maximumNumberOfCards;

        public List<Card> Cards { get; set; }

        public Deck(int maximumNumberOfCards)
        {
            this._maximumNumberOfCards = maximumNumberOfCards;
            Cards = new List<Card>();
        }
    }

    public class Card
    {
        public string Nome { get; set; }
        public string Tipo { get; set; }
    }
}

/*
 * Adding a contructor to your type
 * <<   Best Practices : http://msdn.microsoft.com/en-us/library/vstudio/ms229060(v=vs.100).aspx
 * */
