using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class QuotientRemainder
    {
        public static void CalculateQuotientAndRemainder()
        {
            int dividend = 100, divisor = 10;

            int quotient = dividend / divisor;
            int remainder = dividend % divisor;
            Console.WriteLine("Dividend : " + dividend + " Divisor : " + divisor);
            Console.WriteLine("Quotient : " + quotient);
            Console.WriteLine("Remainder : " + remainder);

        }
    }
}
