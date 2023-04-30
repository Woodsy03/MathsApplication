using System;
using System.Collections.Generic;

namespace MathsApplication
{
    public abstract class DeckGeneration
    {
        public abstract void Shuffle(List<string> deck);

        public List<string> GenerateDeck()
        {
            List<string> Numbers = new List<string>() { "2", "3", "4", "5", "6", "7", "8", "9", "10" };
            List<string> Suites = new List<string>() { "Hearts", "Spades", "Clubs", "Diamonds" };

            // Ordered Deck Creation
            List<string> Deck = new List<string>();
            foreach (string x in Suites)
                foreach (string y in Numbers)
                    Deck.Add(y + " of " + x);

            return Deck;
        }
    }
}
