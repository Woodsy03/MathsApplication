using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathsApplication
{
    public class InteractiveSolving
    {

        public void Quiz(Stacks stacks)
        {

            if (stacks == null || stacks.NumberStack == null || stacks.OperandStack == null)
            {
                Console.WriteLine("Stack object has been incorrectly manipulated, handling exception");
                return;
            }

            Console.WriteLine("Please solve the following");
            if (stacks.OperandStack[0] == "/") //targeted at 6-7 year olds so all decimals have been removed
            {
                while (stacks.NumberStack[0] % stacks.NumberStack[1] != 0)
                {
                    stacks.NumberStack.RemoveAt(0);
                }

            }
            Console.WriteLine(stacks.NumberStack[0] + " " + stacks.OperandStack[0] + " " + stacks.NumberStack[1]);

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

        private int AnswerCalculation(Stacks stacks)
        {
            int CorrectAnswer = 0;
            switch (stacks.OperandStack[0])
            {
                case "+":
                    CorrectAnswer = stacks.NumberStack[0] + stacks.NumberStack[1];
                    break;
                case "-":
                    CorrectAnswer = stacks.NumberStack[0] - stacks.NumberStack[1];
                    break;
                case "*":
                    CorrectAnswer = stacks.NumberStack[0] * stacks.NumberStack[1];
                    break;
                case "/":
                    CorrectAnswer = stacks.NumberStack[0] / stacks.NumberStack[1];
                    break;
            }
            return CorrectAnswer;
        }

        private void QuizRecursion()
        {
            Console.WriteLine("would you like to play again? Yes/No");
            string PlayAgain = Console.ReadLine();
            PlayAgain = PlayAgain.ToLower();

            if (PlayAgain == "yes")
            {
                Stacks stacks = new Stacks();
                Quiz(stacks);
            }
            else if (PlayAgain == "no")
            {
                Console.WriteLine("Thanks for playing! Returning to menu.");
                return;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter 'yes' or 'no'.");
                QuizRecursion();
            }
        }


    }

}
