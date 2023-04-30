using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathsApplication
{
    public class Recursion : InteractiveSolving
    {
        public bool QuizRecursion()
        {
            Console.WriteLine("would you like to play again? Yes/No");
            string PlayAgain = Console.ReadLine();
            PlayAgain = PlayAgain.ToLower();

            if (PlayAgain == "yes")
            {
                Quiz();
                return true;
            }
            else if (PlayAgain == "no")
            {
                Console.WriteLine("Thanks for playing! Returning to menu.");
                return false;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter 'yes' or 'no'.");
                return QuizRecursion();
            }
        }
        public void Quiz()
        {
            base.Quiz(stacks);
        }

    }
}
