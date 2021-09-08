using System;

namespace swap_two_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp,number1, number2;

           
            Console.WriteLine("First Number : ");
            number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Second Number : ");
            number2 = int.Parse(Console.ReadLine());

            temp = number1;
            number1 = number2;
            number2 = temp;

            Console.Write("After Swapping : ");
            Console.Write("First Number : " + number1);

            Console.Write("Second Number : " + number2);
           



        }
    }
}

