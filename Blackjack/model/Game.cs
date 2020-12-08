using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum GameStatus
{
    Won, Lost, Playing, Tie, Blackjack
}

namespace Blackjack.model
{
    class Game
    {
        public Player Player { get; set; }
        public Player Dealer { get; set; }
        public Deck Deck { get; set; }
        public GameStatus Status { get; set; }

        public Game()
        {
            Player = new Player();
            Dealer = new Player();
            Reset();
        }

        public void Reset()
        {
            Deck = new Deck(4); //nr of decks
            Status = GameStatus.Playing;
            Dealer.Reset();
            Player.Reset();
        }

        public void PlayerDraw()
        {
            Card drawnCard = Deck.Draw();
            Player.AddCard(drawnCard);
            //Update gamestatus
            if (Player.BestValue == 21)
            {
                Status = GameStatus.Blackjack;
            }
        }

        public void DealerDraw()
        {
            Card drawnCard = Deck.Draw();
            Dealer.AddCard(drawnCard);
            //Update gamestatus
        }

    }
}
