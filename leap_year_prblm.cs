using System;
namespace leap_year_prblm
{
	class program
	{
	    static void Main(string[] args)
		{
			//variable
			bool is_leap_year = false;
			int Year = int.Parse(Console.ReadLine());
			if (Year % 4 == 0)
			{
				Console.WriteLine("its leap year");
				
			}
			else
            {
				Console.WriteLine("its not leap year");
			}
				
		}
	}

}

