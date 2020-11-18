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
        private List<Card> _cards;

        public Deck(int nrOfDecks)
        {
            _nrOfDecks = nrOfDecks;
        }

        public void ResetAndShuffle()
        {

        }

        public void Shuffle()
        {

        }

        public Card Draw()
        {
            return new Card(0, SuitType.Club);
        }
    }
}
