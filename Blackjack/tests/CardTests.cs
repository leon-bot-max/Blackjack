using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Blackjack.model;


namespace Blackjack.tests
{
    [TestFixture]
    class CardTests
    {
        [TestCase(12, SuitType.Heart, 10)]
        [TestCase(1, SuitType.Spade, 1)]
        [TestCase(13, SuitType.Diamond, 10)]
        [TestCase(5, SuitType.Club, 5)]
        public void TestCardValues(int value, SuitType suit, int blackJackValue)
        {
            Card card = new Card(value, suit);
            Assert.AreEqual(value, card.Value);
            Assert.AreEqual(suit, card.Suit);
            Assert.AreEqual(blackJackValue, card.BlackJackValue);
        }
    }
}
