using System;

namespace number_is_even_or_odd_prblm
{
    class Program
    {
        static void Main(string[] args)
        {
            int ODD  = 1;
            int Number_check = 11;
            Random number = new Random();
            Number_check = number.Next(1, 50);
            Console.WriteLine("Numbercheck from rand :{0}", +Number_check);

            if ((Number_check % 2) == ODD)
            {
                Console.WriteLine("number is odd :");
            }
            else
            {
                Console.WriteLine("number is even");
            }
        }
            
    }
}


