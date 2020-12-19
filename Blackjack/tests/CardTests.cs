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
        [Test]
        public void TestCardToString()
        {
            Card card1 = new Card(1, SuitType.Heart);
            Card card2 = new Card(11, SuitType.Club);
            Card card3 = new Card(12, SuitType.Spade);
            Card card4 = new Card(13, SuitType.Diamond);
            Card card5 = new Card(5, SuitType.Heart);
            card5.IsHidden = true;

            Assert.AreEqual("A♥", card1.ToString());
            Assert.AreEqual("J♣", card2.ToString());
            Assert.AreEqual("Q♠", card3.ToString());
            Assert.AreEqual("K♦", card4.ToString());
            Assert.AreEqual("[]", card5.ToString());


        }
    }
}
