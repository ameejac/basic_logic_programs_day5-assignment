using System;

namespace factors_prblm
{
    class Program
    {
        static void Main(string[] args)
        {
           //variables
            int num;
            int x;
            bool is_prime = true;
            Console.WriteLine("please enter the number:");
            num = int.Parse(Console.ReadLine());

            //Console.WriteLine("factors are:");
            for (x = 2; x <= num; x = (x * x))
            {
                if (num % x == 0)
                {
                   
                    is_prime = false;
                    break;
                }
                //x = x * x;
                Console.WriteLine(x);
            }

            if (is_prime == false)
            {
                Console.WriteLine("Not a prime number");
            } else
            {
                Console.WriteLine("its a prime no :" + num);
            }
       
        }
    }
}

