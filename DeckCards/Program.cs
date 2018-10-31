using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckCards
{
    class Program
    {
        static void Main(string[] args)
        {

            Deck deck = new Deck();

            Console.WriteLine("Estas son las cartas ordenadas:");
            Console.WriteLine(deck.ToString());

            deck.ShuffleCards();
            Console.WriteLine(deck.ToString());
            
            Console.WriteLine("Estas son las cartas que se repartieron:");
            Deck repartidas = deck.DealCards(5);
            Console.WriteLine(repartidas.ToString());


            Console.WriteLine("Asi quedo el mazo:");
            Console.WriteLine(deck.ToString());
            Console.ReadKey();

        }
    }
}
