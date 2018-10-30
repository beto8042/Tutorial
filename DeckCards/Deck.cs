using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckCards
{
    public class Deck
    {
        ArrayList deck;

        public Deck()
        {
            Card cards;
            cards = new Card();

            deck = new ArrayList();

            for (int club = 0; club <4; ++club)
            {
                cards.Club = ClubOptions[club];
                for (int rank = 0; rank < 14; ++rank)
                {
                    cards.Rank = RankOptions[rank];
                    deck.Add(cards.Club +" "+cards.Rank);
                }
            }

        }
        //debe tener un constructor que genere un deck con 52 cartas (check)
        //debe tener un método que se llame deal que le quite el número de cartas especificadas en los parámteros del metodo
        //debe tener un método que se llame shufle
        // override to string (imprime la lista de todas las cartas que tiene el mazo)


        public static string[] RankOptions = new string[] { "A", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K"};
        public static string[] ClubOptions = new string[] { "Diamonds", "Spades", "Harts", "Clubs" };

        public ArrayList DealCards(int cardsnumber)
        {
            Deck deckCards = new Deck();

            ArrayList dealDeck = deckCards.deck.GetRange(0, cardsnumber);

            return dealDeck;
        }

        public ArrayList ShuffleCards()
        {
            Deck deckCards = new Deck();

            ArrayList shuffleCards = new ArrayList();
            Random rand = new Random();
            int randomCard = 0;
            for(int i=56; i>0; i--)
            {
                randomCard = rand.Next(i);
                    
                    shuffleCards.Add(deckCards.deck[randomCard]);
                    deckCards.deck.RemoveAt(randomCard);
                
            }
       
            return shuffleCards;
        }

        public void MuestraDeck(ArrayList deck)
        {
            foreach (string DeckCard in deck)
            { 
                Console.WriteLine(DeckCard);
            };


    }
    }
}
