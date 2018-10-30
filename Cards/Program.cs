using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            var otravar = "lo que quiera";
            var card = new Card();
            string x = card.Rank;
            card.SetClub();

            var otraCard = new Card();
        }
    }
}
