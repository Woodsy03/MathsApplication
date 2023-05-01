using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathsApplication;

public class Play5InteractiveSolving : InteractiveSolving
{
    public override void Quiz(Stacks inputStacks)
    {
        stacks = inputStacks;

        if (stacks == null || stacks.NumberStack == null || stacks.OperandStack == null)
        {
            Console.WriteLine("Stack object has been incorrectly manipulated, handling exception");
            return;
        }

        Console.WriteLine("Please solve the following");
        while (stacks.NumberStack.Count < 5 || stacks.OperandStack.Count < 2)
        {
            stacks.NumberStack.Add(new Random().Next(1, 10));
            stacks.OperandStack.Add(GetRandomOperand());
        }

        string Operand1 = GetOperandString(stacks.OperandStack[0]);
        string Operand2 = GetOperandString(stacks.OperandStack[1]);

        Console.WriteLine(stacks.NumberStack[0] + " " + Operand1 + " " + stacks.NumberStack[1] + " " + Operand2 + " " + stacks.NumberStack[2]);

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

    private string GetRandomOperand()
    {
        string[] operands = { "Diamonds", "Hearts", "Spades", "Clubs" };
        return operands[new Random().Next(operands.Length)];
    }

    private string GetOperandString(string operand)
    {
        switch (operand)
        {
            case "Diamonds": //plus
                return "+";
            case "Hearts": //minus
                return "-";
            case "Spades": //multiply
                return "*";
            case "Clubs": //divide
                return "/";
            default:
                return "";
        }
    }

    protected override int AnswerCalculation(Stacks stacks)
    {
        int tempResult = 0;
        switch (stacks.OperandStack[0])
        {
            case "Diamonds": //plus
                tempResult = stacks.NumberStack[0] + stacks.NumberStack[1];
                break;
            case "Hearts": //minus
                tempResult = stacks.NumberStack[0] - stacks.NumberStack[1];
                break;
            case "Spades": //multiply
                tempResult = stacks.NumberStack[0] * stacks.NumberStack[1];
                break;
            case "Clubs": //divide
                tempResult = stacks.NumberStack[0] / stacks.NumberStack[1];
                break;
        }

        int finalResult = 0;
        switch (stacks.OperandStack[1])
        {
            case "Diamonds": //plus
                finalResult = tempResult + stacks.NumberStack[2];
                break;
            case "Hearts": //minus
                finalResult = tempResult - stacks.NumberStack[2];
                break;
            case "Spades": //multiply
                finalResult = tempResult * stacks.NumberStack[2];
                break;
            case "Clubs": //divide
                finalResult = tempResult / stacks.NumberStack[2];
                break;
        }

        return finalResult;
    }
}