using System;
using System.Collections.Generic;

namespace MathsApplication
{
    public class BogoShuffle : DeckGeneration
    {
        public override void Shuffle(List<string> deck)
        {
            var random = new Random();
            int x = deck.Count;
            while (x > 1)
            {
                x--;
                int y = random.Next(x + 1);
                string value = deck[y];
                deck[y] = deck[x];
                deck[x] = value;
                
            }
        }
    }
}
