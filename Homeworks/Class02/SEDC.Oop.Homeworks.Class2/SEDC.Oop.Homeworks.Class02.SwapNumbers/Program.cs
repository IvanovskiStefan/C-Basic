using System;

namespace SEDC.Oop.Homeworks.Class02.SwapNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter two numbers that will swap values");

            string firstNum = Console.ReadLine();
            string secondNum = Console.ReadLine();

            bool parsedFirstNum = int.TryParse(firstNum, out int firstValue);
            bool parsedSecondNum = int.TryParse(secondNum, out int secondValue);
            Console.WriteLine($"The first input is :{firstValue}, and the second input is :{secondValue}" );

            if (parsedFirstNum && parsedSecondNum)
            {
                int value = firstValue;
                firstValue = secondValue; 
                secondValue = value;

                Console.WriteLine($"After swaping the first input is :{firstValue}, and the second input is :{secondValue}");
                
            }

            Console.ReadLine();
        }
    }
}
