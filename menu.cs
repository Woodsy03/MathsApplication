using MathsApplication;
using System;

class menu
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Application Starting. Welcome.");
        Boolean ValidOption = false;
        Boolean ContinuePlaying = true;

        while (ValidOption = false);    
            Console.WriteLine("please choose one of the following options: ");
            Console.WriteLine("Instructions");
            Console.WriteLine("Play");
            Console.WriteLine("Quit");
        string MenuOption = Console.ReadLine();


        Tutorial tutorial = new Tutorial();
        tutorial.Introduction();

        CardDeck deck = new CardDeck();
        Stacks stacks = deck.GenerateDeck();

        
        if (ContinuePlaying = true)
        {
            InteractiveSolving solving = new InteractiveSolving();
            solving.quiz(stacks);
        }
        
        }
}
