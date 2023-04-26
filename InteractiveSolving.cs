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
            }

            Console.WriteLine(stacks.NumberStack[0] + " " + stacks.OperandStack[0] + " " + stacks.NumberStack[1]);
            string UserAnswer = Console.ReadLine();
            //while (answer != )

        }


    }

}
