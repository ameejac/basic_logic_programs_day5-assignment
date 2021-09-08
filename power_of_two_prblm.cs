using System;

namespace power_of_2_prblm
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            int N = 5;//Convert.ToInt32(Console.ReadLine());

            for (int i = 0 ; i <= N; i++)
            {
                int value = 2;
                //long values = (long)Math.Pow(2, i);
                for(int j = 0; j < i; j++)
                {
                    value = value * 2;
                }
                Console.WriteLine("values :" + value);
            }
            
                           
        }
    }
}

