using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckCards
{
    public class Card
    {
        public string Rank { get; set; }
        public string Club { get; set; }

        public Card()
        {
            Rank = "";
            Club = "";
        }

        public Card(string rank, string club)
        {
            Rank = rank;
            Club = club;
        }

        //falta override de tostring
        public override string ToString()
        {
            string result = "";
            result = Club + Rank;
            return result;
        }
    }
}
