using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace tinycodebits.UnitTests
{
    [TestClass]
    public class CardDeckExerciseTest
    {
        [TestMethod]
        public void TestDeckShuffle()
        {
            CardDeck deck = new CardDeck();
            deck.Shuffle();

            //TODO:  what is an acceptable criteria for proper shuffling? check the first few cards?
            //check the whole stack and expect x% to not be in the same spot?
            Assert.IsFalse(deck[0].Value == 1 && deck[0].Suite == CardDeck.Suite.Spade
                && deck[1].Value == 2 && deck[1].Suite == CardDeck.Suite.Spade
                && deck[2].Value == 3 && deck[2].Suite == CardDeck.Suite.Spade
                && deck[3].Value == 4 && deck[0].Suite == CardDeck.Suite.Spade
                && deck[4].Value == 5 && deck[0].Suite == CardDeck.Suite.Spade);
        }
    }
}
