using System;

namespace Week16VeryHard
{
    class Program
    {
        static void Main(string[] args)
        {
            try 
            {
                Console.Write("Enter the amount you would like to convert \n");
                int userInputNumber = Convert.ToInt32(Console.ReadLine());

                Console.Write("unit of measurment \n");
                var userInputMeasurement = Console.ReadLine();



                var inches = (userInputNumber * 2.54);
                var gallon = (userInputNumber * 3.78541);
                var mile = (userInputNumber * 1.609);
                var pound = (userInputNumber * 0.454);

                switch (userInputMeasurement) 
                {
                    case "I":
                        Console.Write(userInputNumber + " " + userInputMeasurement + " is equal to " + inches + " centimeters");
                        break;

					case "G":
						Console.Write(userInputNumber + " " + userInputMeasurement + " is equal to " + gallon + " liters");
						break;

					case "M":
						Console.Write(userInputNumber + " " + userInputMeasurement + " is equal to " + mile + " kilometers");
						break;

					case "P":
						Console.Write(userInputNumber + " " + userInputMeasurement + " is equal to " + pound + " kilogram");
						break;

                    default:
                        Console.WriteLine("default case");
                        break;
                }


            
            
            } catch(Exception) {
                
            }
        }
    }
}
