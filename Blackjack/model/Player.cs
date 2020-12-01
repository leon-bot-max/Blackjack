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
        public Card LastDrawnCard { get { return LastDrawnCard; } 
            set {
                //Update LowValue, HighValue, BestValue
            } 
        }
        public int LowValue { get; set; }
        public int HighValue { get; set; }
        public int BestValue { get; set; }


        public Player()
        {
            Reset();
        }

        private void UpdateValues()
        {
            LowValue = 0;
            HighValue = 0;
            foreach (Card card in Hand)
            {
                //Low
                LowValue += card.BlackJackValue;//BlackJackValue is always lowest value

                //High
                if (card.Value == 1) //Is ace
                {
                    HighValue += 11;
                }
                else
                {
                    HighValue += card.BlackJackValue;
                }
            }


        }
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
            string playerString = "";
            //Implementera Low/High/Best
            foreach (Card card in Hand)
            {
                playerString += card.ToString() + " ";
            }
            return playerString+BestValue;
        }
    }
}
