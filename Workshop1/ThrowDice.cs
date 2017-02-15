using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop1
{
    class ThrowDice
    {
        public static void Main() {
            Dice diceObj = new Dice();
            double success = 0;
            for (int i = 0; i < 1000; i++)
            {
                diceObj.Throw();
                int firstThrow = System.Convert.ToInt32(diceObj.StrFace);
                diceObj.Throw();
                int secondThrow = System.Convert.ToInt32(diceObj.StrFace);
                Console.WriteLine("   --- dice value --- : First throw : "+firstThrow+"   Second throw  : "+secondThrow+" --  " + (firstThrow+secondThrow));
                if(firstThrow+secondThrow == 8)
                {
                    success++;
                }
            }
            Console.WriteLine("Success is :" + success);
            Console.WriteLine("Probability of getting 8 in 1000 attempts  : " + (double)(success / 1000));
         
        }


    }
}
