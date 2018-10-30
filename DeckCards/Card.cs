using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckCards
{
    public class Card
    {
        public Card()
        {
            Rank = "";
            Club = "";
        }

        public string Rank { get; set; }
        public string Club { get; set; }

    }
}
