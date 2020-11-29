using System;
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
        public int Value { get; set; }
        public SuitType Suit { get; set; }
        public int BlackJackValue { get; set; }

        public Card(int value, SuitType suit)
        {
            this.Value = value;
            this.Suit = suit;
            this.BlackJackValue = Math.Min(value, 10); //Klädda kort = 10
        }

        public override string ToString()
        {
            string returnValue = Value + " of ";
            switch (Suit)
            {
                case SuitType.Club:
                    returnValue += "Club";
                    break;
                case SuitType.Diamond:
                    returnValue += "Diamond";
                    break;
                case SuitType.Heart:
                    returnValue += "Heart";
                    break;
                case SuitType.Spade:
                    returnValue += "Spade";
                    break;
            }
            return returnValue;
        }
    }
}
