using System;

namespace SEDC.Oop.Homeworks.Class02.AverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter four numbers that you want to find out the avarege of.");
            string firstNumber = Console.ReadLine();
            string secondNumber = Console.ReadLine();
            string thirdNumber = Console.ReadLine();
            string fourthNumber = Console.ReadLine();

            bool parsedFirstNum = int.TryParse(firstNumber, out int parsedOne);
            bool parsedSecondNum = int.TryParse(secondNumber, out int parsedTwo);
            bool parsedThirdNum = int.TryParse(thirdNumber, out int parsedThree);
            bool parsedFourthNum = int.TryParse(fourthNumber, out int parsedFour);



            if (parsedFirstNum && parsedSecondNum && parsedThirdNum && parsedFourthNum)
            {
                int sum = parsedOne + parsedTwo + parsedThree + parsedFour;
                int average = sum / 4;
                Console.WriteLine($"The average of {parsedOne},{parsedTwo},{parsedThree},{parsedFour} is : {average}");
            }
            Console.WriteLine("Input error.Please enter numbers :D");
        }
    }
}
