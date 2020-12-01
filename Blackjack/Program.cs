using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blackjack.model;
namespace Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            Player plr = new Player();
            Deck deck = new Deck(1);
            for (int i = 0; i < 3; i++)
            {
                plr.Hand.Add(deck.Draw());
            }
            Console.WriteLine(plr.ToString());
            Console.ReadLine();
        }
    }
}
