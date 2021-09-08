using System;

namespace per_head_tail_cal
{
        class Program
        {
        static void Main(string[] args)
        {
            //variables
            int head = 0;
            int tail = 0;
            int i = 0;

            Random randobj = new Random();
            //computaions
            for (i = 0; i < 5; i++)
            {
                int Val = randobj.Next(0, 3);
                Console.WriteLine("Val is  :" +Val);
                if (Val == 1)
                {
                    head++;
                }
                else
                {
                    tail = tail + 1;
                    Console.WriteLine("tail "+ tail);
                }
            }
            Console.WriteLine("head: " + head);
            Console.WriteLine("tail: " + tail);
        }
        }
 
}

