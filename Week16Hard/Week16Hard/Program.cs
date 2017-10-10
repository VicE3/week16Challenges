using System;

namespace Week16Hard
{
    class Program
    {
        static void Main(string[] args)
        {
            var star = "*";
            var space = " ";
            //This will go 5 times, gives you 5 rows
            for (var x = 0; x < 6; x++) 
            {
                //This says make some number of spaces, keep going while the spaces are greater than the number of 
                //rows. That way when you get the last row(row 5), space counter will be at 0 so there will
                //not be anymore spaces
                for (var y = 5; y > x; y--)
                {
                    Console.Write(space);
                }
                //This says start at one (gonna print one star), everytime after that
                for (var z = 1; z <= (2 * x - 1); z++)
                {
                    Console.Write(star);
                }
                Console.WriteLine();
            }

            }
        }
    }
