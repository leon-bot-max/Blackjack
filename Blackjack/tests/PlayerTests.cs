using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blackjack.model;
namespace Blackjack.tests
{
    [TestFixture]
    class PlayerTests
    {
        [Test]
        public void TestHandValue()
        {
            //Test testing
            Player plr = new Player();
            plr.AddCard(new Card(13, SuitType.Diamond));
            plr.AddCard(new Card(6, SuitType.Diamond));
            plr.AddCard(new Card(1, SuitType.Diamond));
            plr.AddCard(new Card(1, SuitType.Heart));
            Assert.AreEqual(18, plr.BestValue);
            Assert.AreEqual(18, plr.LowValue);
            Assert.AreEqual(38, plr.HighValue);

            plr.Reset();

            plr.AddCard(new Card(5, SuitType.Diamond));
            plr.AddCard(new Card(1, SuitType.Diamond));
            Assert.AreEqual(16, plr.BestValue);
            Assert.AreEqual(6, plr.LowValue);
            Assert.AreEqual(16, plr.HighValue);

        }
    }
}
