using System;

namespace Week16Easy
{
    class Program
    {
        static void Main(string[] args)
        {
			try
			{

				while (true)
				{
					Console.WriteLine("Enter a number");
					int userInput = Convert.ToInt32(Console.ReadLine());


					if (userInput < 10)
					{
						Console.WriteLine("Too low, try again!");
					}
					else if (userInput >= 10)
					{
						Console.WriteLine("Yes, this number will do just fine. Good job");
					}

				}

            } catch (Exception) {
			
				Console.WriteLine("You must enter a valid number");
			}

		}
    }
}
