using MathsApplication;
using System;

class Menu
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Application Starting. Welcome.");
        bool validOption = false;
        bool continuePlaying = true;

        while (!validOption)
        {
            Console.WriteLine("Please choose one of the following options:");
            Console.WriteLine("Instructions");
            Console.WriteLine("Play");
            Console.WriteLine("Quit");
            string menuOption = Console.ReadLine();
            menuOption = menuOption.ToLower();

            switch (menuOption)
            {
                case "instructions":
                    Tutorial tutorial = new Tutorial();
                    tutorial.Introduction();
                    Thread.Sleep(4000);
                    validOption = false;
                    break;
                case "play":
                    validOption = true;
                    CardDeck deck = new CardDeck();
                    Stacks stacks = deck.GenerateDeck();

                    if (continuePlaying)
                    {
                        InteractiveSolving solving = new InteractiveSolving();
                        solving.Quiz(stacks);
                    }
                    break;
                case "quit":
                    validOption = true;
                    Tutorial tutorialQuit = new Tutorial();
                    tutorialQuit.Exit();
                    break;
                default:
                    Console.WriteLine("That is not a valid option.");
                    break;
            }
        }
    }
}
