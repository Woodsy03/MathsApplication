using MathsApplication;
using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Application Starting. Welcome.");

        Tutorial tutorial = new Tutorial();
        tutorial.Introduction();

        Deck deck = new Deck();
        object[] Cards = deck.GenerateDeck();

        InteractiveSolving solving = new InteractiveSolving();
        solving.quiz();
    }
}
