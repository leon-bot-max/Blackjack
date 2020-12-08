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


        public Player()
        {
            Reset();
        }

        private void UpdateValues()
        {
            int amountAce = 0;
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
                    amountAce++;
                }
                else
                {
                    HighValue += card.BlackJackValue;
                }
            }

            BestValue = LowValue;
            for (int i = 0; i < amountAce; i++)
            {
                if (BestValue+10 <= 21)
                {
                    BestValue += 10;//1 is already counted in low value
                }
            }


        }
        public void AddCard(Card card)
        {
            Hand.Add(card);
            LastDrawnCard = card;
            UpdateValues();
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
            return playerString;
        }
    }
}
