﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.model
{
    class Deck
    {
        private int _nrOfDecks;
        private List<Card> _cards = new List<Card>();
        private Random rnd = new Random(); //Used for shuffle

        public Deck(int nrOfDecks)
        {
            _nrOfDecks = nrOfDecks;
            ResetAndShuffle();
        }

        public void ResetAndShuffle()
        {
            _cards = new List<Card>();
            for (int i = 0; i < _nrOfDecks; i++)//nr of decks
            {
                for (int value = 1; value <= 13; value++)//all values
                {
                    foreach (SuitType suit in Enum.GetValues(typeof(SuitType)))//all suits 
                    {
                        _cards.Add(new Card(value, suit));
                    }
                }
            }

            Shuffle();
        }

        /// <summary>
        /// Fisher Yates Shuffle all cards
        /// </summary>
        public void Shuffle()
        {
            //fisherYatesShuffle
            /*-- To shuffle an array a of n elements (indices 0..n-1):
            for i from n−1 downto 1 do
                 j ← random integer such that 0 ≤ j ≤ i
                 exchange a[j] and a[i]*/

            for (int i = _cards.Count-1; i >= 1; i--)
            {
                int k = rnd.Next(0, i + 1);
                Card temp = _cards[k];
                _cards[k] = _cards[i];
                _cards[i] = temp;
            }
        }
        /// <summary>
        /// Draws card at index 0
        /// </summary>
        public Card Draw()
        {
            if (_cards.Count <= 0)
            {
                ResetAndShuffle();
            }
            Card card = _cards[0];
            _cards.RemoveAt(0);

            return card;
        }

        public override string ToString()
        {
            string info = "Count: " + _cards.Count;
            for (int i = 0; i < _cards.Count; i++)
            {
                info += "\n" + _cards[i].ToString();
            }
            return info; 
        }
    }
}
