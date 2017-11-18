using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap._2_List2_10
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Card
    {

    }

    public class Deck
    {
        public ICollection<Card> Cards { get; private set; }

        public Card this[int index]
        {
            get { return Cards.ElementAt(index); }
        }
    }
}

/*
 * Creating a collection such as a Deck class
 * */
