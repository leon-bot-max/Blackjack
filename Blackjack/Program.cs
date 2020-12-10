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
            Console.WriteLine("Your Hand: " + game.Player.ToString() + "(" + game.Player.BestValue + "/" + game.Player.HighValue + ")");

            bool playerTurn = true;
            while (playerTurn && game.Status == GameStatus.Playing)
            {
                if (game.Player.LowValue > 21)
                {
                    playerTurn = false;
                    break;
                }
                Console.Write("Draw (D) or Stay (S): ");
                string answer = Console.ReadLine();

                if (answer.ToLower().StartsWith("d"))
                {
                    game.PlayerDraw();
                    Console.WriteLine("Your Hand: " + game.Player.ToString() + "(" + game.Player.BestValue + "/" + game.Player.HighValue + ")");
                }
                else
                {
                    playerTurn = false;
                }
            }
            while (game.Status == GameStatus.Playing)
            {
                game.DealerDraw();
                Console.WriteLine("Dealer Hand: " + game.Dealer.ToString() + "(" + game.Dealer.HighValue + ")");
            }
            switch (game.Status)
            {
                case GameStatus.Blackjack:
                    Console.WriteLine("You won (Blackjack)");
                    break;
                case GameStatus.Won:
                    Console.WriteLine("You won");
                    break;
                case GameStatus.Tie:
                    Console.WriteLine("You tied");
                    break;
                case GameStatus.Lost:
                    Console.WriteLine("You lost");
                    break;
            }
            Console.ReadLine();


        }

        public static string Test()
        {
            
            return "";
        }


    }


}
