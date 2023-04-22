using System;
using System.Collections.Generic;

class Deck //responsibe for deck generation and shuffling
{
    private List<string> Cards { get; set; }
    public Deck()
    {
        GenerateDeck();
        //Shuffle();
    }

    public object[] GenerateDeck()
    {
        var random = new Random();

        List<string> numbers = new List<string>() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"};
        List<string> operand = new List<string>() { "*", "/", "-", "+" };

        int Rand1Index = random.Next(numbers.Count);
        int Rand2Index = random.Next(numbers.Count);
        int RandOperandIndex = random.Next(operand.Count);
        string ChosenOperand = operand[RandOperandIndex];

        string Rand1 = numbers[Rand1Index];
        string Rand2 = numbers[Rand2Index];

        object[] Cards = new object[]
        {
            Rand1,
            Rand2,
            ChosenOperand
        };

        return Cards;
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
