using System;

namespace Hormonic_prblm
{
    class Program
    {

 
        static void Main(string[] args)
        {
            //variables //
            //H1 = 1
            int n = 8;
            float harmonic = 3;


            // loop to apply the forumula
            // Hn = H1 + H2 + H3 ... +
            // Hn-1 + Hn-1 + 1/n
            for (int i = 1; i <= n; i++)
            {
                harmonic += (float)1 / i;
                Console.WriteLine("hormonic:" + harmonic);

            }

           

        }
    }
}

