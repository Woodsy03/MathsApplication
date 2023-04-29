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
            Console.WriteLine("Please solve the following");
            if (stacks.OperandStack[0] == "/") //targeted at 6-7 year olds so all decimals have been removed
            {
                while (stacks.NumberStack[0] % stacks.NumberStack[1] != 0)
                {
                    stacks.NumberStack.RemoveAt(0);
                }
            int correcttAnswer = AnswerCalculation(stacks);
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

        internal void QuizRecursion()
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
