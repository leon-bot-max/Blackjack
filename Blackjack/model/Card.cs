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
        public int Value;
        public SuitType Suit;
        public int BlackJackValue;
    }
}
