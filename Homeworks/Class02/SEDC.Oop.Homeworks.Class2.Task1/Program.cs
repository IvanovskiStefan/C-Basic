using System;

namespace SEDC.Oop.Homeworks.Class2.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the first number");
            string inputFromConsoleOne = Console.ReadLine();
            bool parsedInputFromConsoleOne = int.TryParse(inputFromConsoleOne, out int parsedInputOne);

            Console.WriteLine("Please enter the second number");
            string inputFromConsoleTwo = Console.ReadLine();
            bool parsedInputFromConsoleTwo = int.TryParse(inputFromConsoleTwo, out int parsedInputTwo);

            Console.WriteLine(" Select + for addition of the two numbers ");
            Console.WriteLine(" Select - for substracting the two numbers");
            Console.WriteLine(" Select * for multiplying the two numbers ");
            Console.WriteLine(" Select / for dividing the two numbers");
                       
            string operatorInput = Console.ReadLine();
            
            int firstNumber = parsedInputOne;
            int secondNumber = parsedInputTwo;

            if (operatorInput == "+") 
            {
                int sum = parsedInputOne + parsedInputTwo;
                Console.WriteLine(sum); 
            };
            if (operatorInput == "-")
            {
                int sum = parsedInputOne - parsedInputTwo;
                Console.WriteLine(sum);
            };
           
            if (operatorInput == "/")
            {
               int sum = parsedInputOne / parsedInputTwo;
                Console.WriteLine(sum);

            };

            if (operatorInput == "*")
            {
                int sum = parsedInputOne * parsedInputTwo;
                Console.WriteLine(sum);
            };
        }
    }
}
