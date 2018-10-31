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
        public static string[] RankOptions = new string[] { "A", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
        public static string[] ClubOptions = new string[] { "D", "S", "H", "C" };

        Card[] _cards;

        public Deck()
        {
            _cards = new Card[ClubOptions.Length * RankOptions.Length];
            int y = 0;
            for (int club = 0; club < ClubOptions.Length; ++club)
            {
                
                for (int rank = 0; rank < RankOptions.Length; ++rank)
                {
                    var card = new Card();
                    card.Club = ClubOptions[club];
                    card.Rank = RankOptions[rank];
                    _cards[y] = card;
                    y++;
                }
            }
        }

        private Deck(Card[] cards)
        {
            _cards = cards;
        }

        //debe tener un constructor que genere un deck con 52 cartas (check)
        //debe tener un método que se llame deal que le quite el número de cartas especificadas en los parámteros del metodo
        //debe tener un método que se llame shufle
        // override to string (imprime la lista de todas las cartas que tiene el mazo)



        public Deck DealCards(int cardsnumber)
        {
            Card[] todeal = new Card[cardsnumber];
            for(int i = 0; i < cardsnumber; i++)
            {
                todeal[i] = _cards[i];
            }

            Card[] deckWithRemovedCards = new Card[_cards.Length - cardsnumber];
            //falta for
            int f = 0;
            for(int r = cardsnumber; r < _cards.Length; r++)
            {
                deckWithRemovedCards[f] = _cards[r];
                f++;
            }
            _cards = deckWithRemovedCards;
            return new Deck(todeal);
        }

        public void ShuffleCards()
        {

            Card[] toShuffle = new Card[_cards.Length];
            
            Random rand = new Random();
            int randomCard = 0;
            int w = 0;
            int q = _cards.Length;
            while (q > 0)
            {
                randomCard = rand.Next(_cards.Count());
                toShuffle[w] = _cards[randomCard];
                w++;
                Card[] deckWithRemovedCards = new Card[_cards.Length];
                for (int z = 0; z < randomCard; z++)
                {
                    deckWithRemovedCards[z] = _cards[z];

                }
                for (int x = randomCard; x < _cards.Length; x++)
                {
                    deckWithRemovedCards[x] = _cards[x];
                }
                _cards = deckWithRemovedCards;
                q--;
            }
            _cards = toShuffle;
        }

        public override string ToString()
        {
            string result = "";
            for(int i = 0; i < _cards.Length; i++)
            {
                result += _cards[i].ToString() + " | ";
            }
            result += "\n###########################################################################\n";
            return result;
        }
    }
}
