    using System;

    namespace largest_three_num_program
    {
        class Program
        {
            static void Main(string[] args)
            {
                //variables
                int num1, num2, num3;
                //computaion

                //const int num1 = 5;
                Console.WriteLine("please eneter num1:");
                 num1 = int.Parse(Console.ReadLine());
                // const int num2 = 10;
                Console.WriteLine("please eneter num2:");
                num2 = int.Parse(Console.ReadLine());
                //const int num3 = 15;
                Console.WriteLine("please eneter num3:");
                num3 = int.Parse(Console.ReadLine());

              int largest_num = num1;
                if(largest_num < num2)
                {
                    largest_num = num2;
                
                }
                if(largest_num <num3);
                {
                    largest_num = num3;
                }
                Console.WriteLine("largest_num is:" +largest_num);
            }
        }
    }

