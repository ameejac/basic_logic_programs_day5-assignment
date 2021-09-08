using System;

namespace alphabet_vowel_or_constant_prblm
{
    public class program
    {
        static void Main(string[] args)
        {
            char ch;

            Console.Write("Input an Alphabet (A-Z or a-z) : ");
            ch = Convert.ToChar(Console.ReadLine());

            {
                int i = ch;
                if (i >= 48 && i <= 58)
                {
                    Console.Write("You entered a number, Please enter an alpahbet.");
                }
                else
                {
                    switch (ch)
                    {
                        case 'a':
                        case 'A':
                            Console.WriteLine("The Alphabet is vowel");
                            break;
                        case 'e':
                        case 'E':
                            Console.WriteLine("The Alphabet is vowel");
                            break;
                        case 'i':
                        case 'I':
                            Console.WriteLine("The Alphabet is vowel");
                            break;
                        case 'o':
                        case 'O':
                            Console.WriteLine("The Alphabet is vowel");
                            break;
                        case 'u':
                        case 'U':
                            Console.WriteLine("The Alphabet is vowel");
                            break;
                        case 'c':
                        case 'C':
                            Console.WriteLine("The Alphabet is constant");
                            break;
                        default:
                            Console.WriteLine("The Alphabet is CONSTANT");
                            break;
                    }
                }
            }
        }
    }
}
