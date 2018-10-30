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
            deck.MuestraDeck(deck.DealCards(56));
            Console.WriteLine("Indica el número de cartas a repartir:");
            string dealcards;
            dealcards = Console.ReadLine();
            Console.WriteLine("Estas son las cartas que se repartieron:");
            deck.MuestraDeck(deck.DealCards(5));
            Console.WriteLine("Estas son las cartas revuletas:");
            deck.MuestraDeck(deck.ShuffleCards());

        Console.ReadKey();

        }
    }
}
