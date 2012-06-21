using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tinycodebits
{

    public class Card
    {
        public CardDeck.Suite Suite { get; set; }
        public int Value { get; set; }
    }

    public class CardDeck
    {
        public enum Suite
        {
            Spade,
            Heart,
            Diamond,
            Club
        }

        private Card[] _cards;

        public CardDeck()
        {
            //populate the deck with new cards in sequence
            _cards = new Card[52];

            for (int i = 0; i < 13; i++)
            {
                _cards[i] = new Card { Suite = Suite.Spade, Value = i + 1 };
                _cards[i + 13] = new Card { Suite = Suite.Heart, Value = i + 1 };
                _cards[i + 26] = new Card { Suite = Suite.Diamond, Value = i + 1 };
                _cards[i + 39] = new Card { Suite = Suite.Club, Value = i + 1 };
            }
        }

        public void Shuffle()
        {
            //quick and dirty:  swap pairs of cards randomly for all cards - maybe overdoing it?  could 
            //do half the deck?
            Random random = new Random();
            for (int i = 0; i < 52; i++)
            {
                int swapIndex = random.Next(0, 51);
                Card swapCard = _cards[i];
                _cards[i] = _cards[swapIndex];
                _cards[swapIndex] = swapCard;
            }
        }

        public Card this[int index]
        {
            get { return _cards[index]; }
            set { _cards[index] = value; }
        }
    }
}
