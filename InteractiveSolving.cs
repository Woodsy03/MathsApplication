using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathsApplication;

public class InteractiveSolving
{
    protected Stacks stacks;

    public void Quiz(Stacks inputStacks)
    {
        stacks = inputStacks;

        if (stacks == null || stacks.NumberStack == null || stacks.OperandStack == null)
        {
            Console.WriteLine("Stack object has been incorrectly manipulated, handling exception");
            return;
        }

        Console.WriteLine("Please solve the following");
        if (stacks.OperandStack[0] == "Clubs") //targeted at 6-7 year olds so all decimals have been removed
        {
            while (stacks.NumberStack[0] % stacks.NumberStack[1] != 0)
            {
                stacks.NumberStack.RemoveAt(0);
            }
        }

        string Operand = string.Empty;
        switch (stacks.OperandStack[0])
        {
            case "Diamonds": //plus
                Operand = "+";
                break;
            case "Hearts": //minus
                Operand = "-";
                break;
            case "Spades": //multiply
                Operand = "*";
                break;
            case "Clubs": //divide
                Operand = "/";
                break;
        }

        Console.WriteLine(stacks.NumberStack[0] + " " + Operand + " " + stacks.NumberStack[1]);

        int correctAnswerInt = AnswerCalculation(stacks);
        string correctAnswer = correctAnswerInt.ToString();
        string UserAnswer = "N/A"; //OOB value
        bool IsAnswerANumber;
        int ParsedValue;

        while (correctAnswer != UserAnswer)
        {
            Console.WriteLine("Please enter your answer below");
            UserAnswer = Console.ReadLine();
            IsAnswerANumber = int.TryParse(UserAnswer, out ParsedValue);

            if (IsAnswerANumber == false)
            {
                Console.WriteLine("That's not a number sorry, please try again.");
            }
            else
            {
                if (correctAnswer != UserAnswer)
                {
                    Console.WriteLine("I'm sorry, that wasn't the correct answer");
                }
                else
                {
                    Console.WriteLine("That's correct, good job!");
                    QuizRecursion();
                }
            }
        }
    }

    private bool QuizRecursion()
    {
        Recursion recursion = new Recursion();
        return recursion.QuizRecursion();
    }

    private int AnswerCalculation(Stacks stacks)
    {
        int CorrectAnswer = 0;
        switch (stacks.OperandStack[0])
        {
            case "Diamonds": //plus
                CorrectAnswer = stacks.NumberStack[0] + stacks.NumberStack[1];
                break;
            case "Hearts": //minus
                CorrectAnswer = stacks.NumberStack[0] - stacks.NumberStack[1];
                break;
            case "Spades": //multiply
                CorrectAnswer = stacks.NumberStack[0] * stacks.NumberStack[1];
                break;
            case "Clubs": //divide
                CorrectAnswer = stacks.NumberStack[0] / stacks.NumberStack[1];
                break;
        }
        return CorrectAnswer;
    }
}
