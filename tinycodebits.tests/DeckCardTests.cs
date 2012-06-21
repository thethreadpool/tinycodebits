using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using tinycodebits;

namespace tinycodebits.Tests
{
    [TestFixture]
    public class DeckCardTests
    {
        [Test]
        public void DeckInitTest()
        {
            Deck cardDeck = new Deck();
            Assert.AreEqual(cardDeck[1].Suit, CardSuit.Spade);
            Assert.AreEqual(cardDeck[1].Value, 1);
            Assert.AreEqual(cardDeck[13].Suit, CardSuit.Spade);
            Assert.AreEqual(cardDeck[13].Value, 13);
            Assert.AreEqual(cardDeck[14].Suit, CardSuit.Heart);
            Assert.AreEqual(cardDeck[14].Value, 1);
            Assert.AreEqual(cardDeck[24].Suit, CardSuit.Heart);
            Assert.AreEqual(cardDeck[24].Value, 11);
        }
    }
}
