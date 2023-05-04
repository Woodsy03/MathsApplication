using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using MathsApplication;

class Menu
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Application Starting. Welcome.");
        bool validOption = false;

        while (!validOption)
        {
            Console.WriteLine("Please choose one of the following options:");
            Console.WriteLine("Instructions");
            Console.WriteLine("Play");
            Console.WriteLine("Play5");
            Console.WriteLine("Quit");
            string menuOption = Console.ReadLine();
            menuOption = menuOption.ToLower();

            switch (menuOption)
            {
                case "instructions":
                    Instruction tutorial = new Instruction();
                    tutorial.Introduction();
                    Thread.Sleep(4000);
                    validOption = false;
                    break;
                case "play":
                    validOption = false;
                    pack shuffle = new pack();
                    List<string> deck = shuffle.GenerateDeck();
                    shuffle.Shuffle(deck);

                    List<int> numberStack = deck.Select(card => int.Parse(card.Split(' ')[0])).ToList();
                    string suites = deck[2];
                    string[] suitesSplit = suites.Split(' ');
                    string operand = suitesSplit[2];

                    List<string> operandStack = new List<string> { operand };
                    Stacks stacks = new Stacks { NumberStack = numberStack, OperandStack = operandStack };

                    InteractiveSolving solving = new InteractiveSolving();
                    solving.Quiz(stacks);
                    break;
                case "play5":
                    validOption = false;
                    pack shuffle5 = new pack();
                    List<string> deck5 = shuffle5.GenerateDeck();
                    shuffle5.Shuffle(deck5);

                    List<int> numberStack5 = deck5.Select(card => int.Parse(card.Split(' ')[0])).ToList();
                    string suites5 = deck5[2];
                    string[] suitesSplit5 = suites5.Split(' ');
                    string operand5 = suitesSplit5[2];

                    List<string> operandStack5 = new List<string> { operand5 };
                    Stacks stacks5 = new Stacks { NumberStack = numberStack5, OperandStack = operandStack5 };

                    Play5InteractiveSolving Play5Solving = new Play5InteractiveSolving();
                    Play5Solving.Quiz(stacks5);
                    break;

                case "quit":
                    validOption = true;
                    Instruction instructionQuit = new Instruction();
                    instructionQuit.Exit();
                    break;
                default:
                    Console.WriteLine("That is not a valid option.");
                    break;

            }
        }
    }
}
