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
        public void TestBestHand()
        {
            //Test testing
            Player plr = new Player();
            plr.Hand.Add(new Card(13, SuitType.Diamond));
            plr.Hand.Add(new Card(6, SuitType.Diamond));
            plr.Hand.Add(new Card(1, SuitType.Diamond));
            plr.Hand.Add(new Card(1, SuitType.Heart));
            plr.UpdateValues();
            Assert.AreEqual(18, plr.BestValue);

        }
    }
}
