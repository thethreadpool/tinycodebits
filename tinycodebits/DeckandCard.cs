using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Design a Deck class and a Card class and write a function to shuffle a deck of cards.


namespace tinycodebits
{
    public enum CardSuit
    {
        Spade,
        Heart,
        Diamond,
        Club
    }

    public class Card
    {
        public CardSuit Suit { get; internal set; }
        public int Value { get; internal set; }
    }

    public class Deck
    {
        private Card[] _cards;

        public Deck()
        {
            _cards = new Card[52];
            //initialize the deck
            for (int i = 0; i < 13; i++)
            {
                _cards[i] = new Card { Suit = CardSuit.Spade, Value = i + 1 };
                _cards[i + 13] = new Card{ Suit = CardSuit.Heart, Value = i + 1 };
                _cards[i + 26] = new Card { Suit = CardSuit.Diamond, Value = i + 1};
                _cards[i + 39] = new Card { Suit = CardSuit.Club, Value = i + 1 };
            }
        }

        public Card this[int index]
	    {
		    get 
            { 
                if (index > 52 || index < 1) throw new ArgumentException("Index must be between 1 and 52", "index");

                return _cards[index - 1];
            }

	    }

        public void Shuffle()
        {
            Card[] shuffledCards = new Card[52];

            //for each card in the current deck, randomly generated a new position to that card
            Random randomGenerator = new Random();
            for (int i = 0; i < 52; i++)
            {
                int cardPosition = randomGenerator.Next(0, 51);
                //generate a new number until we find a position in the new order that is available
                while (shuffledCards[cardPosition] != null)
                {
                    cardPosition = randomGenerator.Next(0, 51);
                }
                shuffledCards[cardPosition] = _cards[i];
            }
            _cards = shuffledCards;
        }

    }
}
