using System;

namespace quotient_remainder_prblm
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            int dividend = 50;
            int divisor = 4;

            int quotient = dividend / divisor;
            int remainder = dividend % divisor;
            Console.WriteLine("Dividend{0}: Divisor{1}:", dividend, divisor);
            Console.WriteLine("Quotient = " + quotient);
            Console.WriteLine("Remainder = " + remainder);
            Console.ReadLine();
        }
    }
}

