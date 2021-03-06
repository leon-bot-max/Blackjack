﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.model
{
    class Player
    {
        public List<Card> Hand { get; private set; } = new List<Card>();
        public Card LastDrawnCard { get; private set; }
        public int LowValue { get; private set; }
        public int HighValue { get; private set; }
        public int BestValue { get; private set; }


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
                if (card.IsHidden) //Dont count card
                {
                    continue;
                }
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
        public void UnHideCard(int index)
        {
            if (Hand[index].IsHidden)
            {
                LastDrawnCard = Hand[index];
                Hand[index].IsHidden = false;
                UpdateValues();
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
            foreach (Card card in Hand)
            {
                playerString += card.ToString() + " ";
            }
            return playerString;
        }
    }
}
