using System;
using System.Collections.Generic;

public class Stacks
{
    public List<int> NumberStack { get; set; }
    public List<string> OperandStack { get; set; }
}

public class CardDeck // Responsible for deck generation and shuffling
{
    public Stacks GenerateDeck()
    {
        var random = new Random();

        List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        List<string> operands = new List<string>() { "*", "/", "-", "+" };
        List<int> NumberStack = new List<int>();
        List<string> OperandStack = new List<string>();

        // Generate random number stack
        for (int i = 0; i < 1000; i++)
        {
            int temp = random.Next(0, 10);
            NumberStack.Add(numbers[temp]);
        }

        // Generate random operand stack
        for (int i = 0; i < 500; i++)
        {
            int tempOperand = random.Next(0, 4);
            OperandStack.Add(operands[tempOperand]);
        }

        // Merging both stacks into a single return variable
        Stacks stacks = new Stacks
        {
            NumberStack = NumberStack,
            OperandStack = OperandStack
        };

        return stacks;
    }
}
