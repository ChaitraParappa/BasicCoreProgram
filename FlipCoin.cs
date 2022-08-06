using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public static class FlipCoin
    {
        public static void CalculatePercentage()
        {
            int head = 0;
            int tail = 0;
            int headcount = 0;
            int tailcount = 0;
            double headpercentage;
            double tailpercentage;

            Console.WriteLine("Please enter the value for number of flip");
            int flipCoin = Convert.ToInt32(Console.ReadLine());

        

            if(flipCoin>0)
            {
                for(int i=0;i< flipCoin;i++)
                {
                    Random random = new Random();
                    int number = random.Next(2);

                    Console.WriteLine("The flip is " + number);

                    if (number==1)
                    {
                        headcount++;
                    }
                    else
                    {
                        tailcount++;
                    }
                }

                headpercentage = headcount * 100 / flipCoin;
                tailpercentage = tailcount * 100 / flipCoin;

                Console.WriteLine("The Head Percentage is " + headpercentage);
                Console.WriteLine("The tail Percentage is " + tailpercentage);

            }
            else
            {
                Console.WriteLine("Please enter the positive Number");
            }
            
        }
    }
}
