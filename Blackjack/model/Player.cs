using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.model
{
    class Player
    {
        public List<Card> Hand;
        public Card LastDrawnCard;
        public int LowValue;
        public int HighValue;
        public int BestValue;

        public void Reset()
        {

        }

        public override string ToString()
        {
            return "Player";
        }
    }
}
