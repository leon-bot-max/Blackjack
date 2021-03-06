﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



enum SuitType
{
    Club, Diamond, Heart, Spade
}
namespace Blackjack.model
{
    class Card
    {
        public int Value { get; private set; }
        public SuitType Suit { get; private set; }
        public int BlackJackValue { get; private set; }
        public bool IsHidden { get; set; } = false;
        public Card(int value, SuitType suit)
        {
            this.Value = value;
            this.Suit = suit;
            this.BlackJackValue = Math.Min(value, 10); //picture cards (11, 12, 13)= 10
        }

        public override string ToString()
        {
            if (IsHidden)
            {
                return "[]";
            }
      
            string returnValue = "";

            
            switch (Value)
            {
                case 11:
                    returnValue += "J";
                    break;
                case 12:
                    returnValue += "Q";
                    break;
                case 13:
                    returnValue += "K";
                    break;
                case 1:
                    returnValue += "A";
                    break;
                default:
                    returnValue += Value;
                    break;
            }
            switch (Suit)
            {
                case SuitType.Club:
                    returnValue += "♣";
                    break;
                case SuitType.Diamond:
                    returnValue += "♦";
                    break;
                case SuitType.Heart:
                    returnValue += "♥";
                    break;
                case SuitType.Spade:
                    returnValue += "♠";
                    break;
            }
            
            return returnValue;
        }
    }
}
