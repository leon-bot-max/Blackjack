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

        }

        public void Reset()
        {

        }

        public void PlayerDraw()
        {

        }

        public void DealerDraw()
        {

        }

    }
}
