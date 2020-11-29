using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.model
{
    class Player
    {
        public List<Card> Hand { get; set; } = new List<Card>();
        public Card LastDrawnCard { get; set; }
        public int LowValue { get; set; }
        public int HighValue { get; set; }
        public int BestValue { get; set; }

        public void Reset()
        {
            Hand = new List<Card>();
            LastDrawnCard = null;
            LowValue = 0;
            HighValue = 0;
            BestValue = 0;
        }

        public override string ToString()
        {
            return "Player";
        }
    }
}
