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
        public Player Player;
        public Player Dealer;
        public Deck Deck;
        public GameStatus Status;

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
