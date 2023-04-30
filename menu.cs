﻿using System;
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
                    BogoShuffle shuffle = new BogoShuffle();
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
