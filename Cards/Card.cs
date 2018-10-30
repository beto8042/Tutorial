using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards
{
    public class Card
    {
        #region Fields

        string _field1;

        #endregion

        #region Constructor

        public Card()
        {
            _field1 = "algo";
        }

        #endregion

        public static string[] RankOptions = new string[] { "A", "1", "2", "3" };
        public static string[] ClubOptions = new string[] { "Diamonds", "Spades", "Harts", "Clubs" };

        public string Rank { get; private set; } = "A";

        public string Club { get; private set; } = "Spades";

        public string CualquierCosa()
        {
            return Rank + ":" + Club;
        }

        public void SetClub()
        {
            Rank = RankOptions[0];
        }

    }
}
