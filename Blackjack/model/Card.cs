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
                    returnValue += "c";
                    break;
                case SuitType.Diamond:
                    returnValue += "d";
                    break;
                case SuitType.Heart:
                    returnValue += "h";
                    break;
                case SuitType.Spade:
                    returnValue += "s";
                    break;
            }
            return returnValue;
        }
    }
}
