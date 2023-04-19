using System;
using System.Collections.Generic;

class Deck //responsibe for deck generation and shuffling
{
    private List<string> Cards { get; set; }
    public Deck()
    {
        GenerateDeck();
        Shuffle();
    }

    private void GenerateDeck()
    {
        List<string> numbers = new List<string>() { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "King", "Queen", "Ace" };
        List<string> suites = new List<string>() { "Hearts", "Spades", "Clubs", "Diamonds" };

        Cards = new List<string>();
        foreach (string suite in suites)
            foreach (string number in numbers)
                Cards.Add(number + " of " + suite);
    }

    private void Shuffle()
    {
        Random rnd = new Random();
        for (int i = Cards.Count - 1; i > 0; i--)
        {
            int randomIndex = rnd.Next(0, i + 1);
            string temp = Cards[i];
            Cards[i] = Cards[randomIndex];
            Cards[randomIndex] = temp;
        }
    }

}
