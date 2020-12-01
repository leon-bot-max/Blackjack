using System;
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

        public Deck(int nrOfDecks)
        {
            _nrOfDecks = nrOfDecks;
            ResetAndShuffle();
        }

        public void ResetAndShuffle()
        {
            for (int i = 0; i < _nrOfDecks; i++)//nr of decks
            {
                foreach (SuitType suit in Enum.GetValues(typeof(SuitType)))//all suits
                {
                    for (int value = 1; value <= 13; value++)//all values
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

            int n = _cards.Count - 1;
            Random rnd = new Random();
            for (int i = _cards.Count-1; i > 1; i--)
            {
                int k = rnd.Next(0, i + 1);
                Card temp = _cards[k];
                _cards[k] = _cards[i];
                _cards[i] = temp;
            }
        }

        public Card Draw()
        {
            Random rnd = new Random();
            int index = rnd.Next(_cards.Count); //Random index
            Card card = _cards[index];
            _cards.RemoveAt(index);

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
