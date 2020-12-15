using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Blackjack.model;
namespace Blackjack
{
    class Program
    {

        static void Main(string[] args)
        {
            Game game = new Game();

            //Cards to start game (Dealer has one hidden thats drawn on dealerturn instead)
            game.DealerDraw();
            game.PlayerDraw();
            game.PlayerDraw();

            PlayerTurn(game);
            DealerTurn(game);

            //Write out to show hands
            Console.Clear();
            WriteHands(game);

            //Show result
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

        private static void WriteHands(Game game)
        {
            Console.WriteLine("Dealer Hand: " + game.Dealer.ToString() + "(" + game.Dealer.HighValue + ")");
            Console.WriteLine("Your Hand: " + game.Player.ToString() + "(" + game.Player.BestValue + "/" + game.Player.HighValue + ")");
        }


        private static void PlayerTurn(Game game)
        {
            bool playerTurn = true;

            while (playerTurn && game.Status == GameStatus.Playing)
            {
                Console.Clear();
                WriteHands(game);
                Console.WriteLine("Draw (D) or Stay (S)");
                //Get input
                ConsoleKeyInfo input = Console.ReadKey();

                if (input.Key == ConsoleKey.D)
                {
                    game.PlayerDraw();
                }
                else if (input.Key == ConsoleKey.S)
                {
                    playerTurn = false;
                }
            }
        }

        private static void DealerTurn(Game game)
        {
            game.DealerDraw(); //Dealer had hidden card in beginning
            while (game.Status == GameStatus.Playing)
            {
                Console.Clear();
                Console.WriteLine("...");
                Console.WriteLine("Dealer shows: " + game.Dealer.LastDrawnCard.ToString());
                WriteHands(game);
                
                Thread.Sleep(2000); //Wait 2000ms between draws
                game.DealerDraw();
            }
        }


    }


}
