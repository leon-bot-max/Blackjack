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
            Game game = new Game();
            game.DealerDraw();
            Console.WriteLine("Dealer Hand: " + game.Dealer.ToString() + "("+ game.Dealer.HighValue +")");
            game.PlayerDraw();
            game.PlayerDraw();
            Console.WriteLine("Your Hand: " + game.Player.ToString() + "(" + game.Player.BestValue + "/"+game.Player.HighValue +")");

            Console.ReadLine();

            
        }

        
    }

    
}
