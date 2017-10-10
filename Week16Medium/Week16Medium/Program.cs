using System;

namespace Week16Medium
{
    class Program
    {
        static void Main(string[] args)
        {

            var star = "*";

            for (var i = 0; i < 5; i++)
            {
                for (var x = 0; x < 10; x++)
                {
                    Console.Write(star);
                }

                Console.Write("\n");
            }
        }
    }
}



