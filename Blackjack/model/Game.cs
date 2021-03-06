﻿using System;
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
        public Player Player { get; private set; }
        public Player Dealer { get; private set; }
        public Deck Deck { get; private set; }
        public GameStatus Status { get; set; }

        public Game()
        {
            Deck = new Deck(4); //nr of decks
            Player = new Player();
            Dealer = new Player();
            Reset();
        }

        public void Reset()
        {
            Deck.ResetAndShuffle();
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
            else if(Player.BestValue > 21) //This means player always lose on >21 even if dealer also is >21
            {
                Status = GameStatus.Lost;
            }

        }

        public void DealerDraw(bool hidden = false)
        {
            if (Dealer.HighValue >= 17) //Dont draw more cards
            {
                SetWinner();
                return;
            }
            Card drawnCard = Deck.Draw();
            drawnCard.IsHidden = hidden; //Card hidden?
            
            Dealer.AddCard(drawnCard);

        }

        /// <summary>
        /// Sets winner assuming all cards have been drawn
        /// </summary>
        private void SetWinner()
        {
            if (Dealer.HighValue > 21) //Dealer over 21
            {
                if (Player.BestValue > 21) //Both over 21, will never be reached because player loses on over 21 in PlayerDraw
                {
                    Status = GameStatus.Tie;
                }
                else   //Player won
                {
                    Status = GameStatus.Won;
                }
            }
            else if (Player.BestValue > 21)
            {
                Status = GameStatus.Lost;  //Player over 21, Dealer not. will never be reached because player loses on over 21 in PlayerDraw
            }
            else if (Dealer.HighValue == Player.BestValue) //Both same value
            {
                if (Dealer.HighValue >= 17 && Dealer.HighValue <= 19) //Dealer win
                {
                    Status = GameStatus.Lost;
                }
                else                                                  //Tie
                {
                    Status = GameStatus.Tie;
                }
            }
            else if (Dealer.HighValue > Player.BestValue) //Dealer has higher value than player, but not over 21
            {
                Status = GameStatus.Lost;
            }
            else if (Player.BestValue > Dealer.HighValue) //Player has higher value than dealer, but not over 21
            {
                Status = GameStatus.Won;
            }
            
        }
    }
}
