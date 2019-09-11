using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page111Drill
{
    public class Calculations
    {
        public static int Additions(int userInput)
        {
            int answer1 = userInput + 10;
            return answer1;
            
        }

        public static int Multiply(int userInput)
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 100);
            int answer1 = userInput * randomNumber;
            return answer1;
        }

        public static int wholeLottaMath(int userInput)
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 100);
            if (randomNumber <= userInput)
            {
                int tempNum = userInput * randomNumber;
                tempNum = tempNum * randomNumber;
                int answer1 = tempNum / 15;
                return answer1;
            }
            else
            {
                int tempNum2 = userInput / randomNumber;
                tempNum2 = tempNum2^3;
                int answer2 = tempNum2;
                return answer2;
            }

            
        }
    }
}
