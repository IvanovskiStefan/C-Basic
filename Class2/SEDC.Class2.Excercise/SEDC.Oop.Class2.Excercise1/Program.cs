using System;

namespace SEDC.Oop.Class2.Excercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            //double firstVariable = 123.123456;
            //double secondVariable = 456.123456;


            //double devideVariables = firstVariable / secondVariable;
            //Console.WriteLine(devideVariables);

            //int firstIntager = 8;
            //int secondIntager = 4;

            //int devidedIntager = firstIntager / secondIntager;
            //Console.WriteLine(devidedIntager);

            //string firstString = "Stefan";
            //string secondString = "Ivanovski";

            //string conctaenate = firstString + " " + secondString;

            //Console.WriteLine(conctaenate);


            //string numberOne = "9";
            //string numberTwo = "3";

            //string concatenateNumbers = numberOne + numberTwo;

            //Console.WriteLine(concatenateNumbers);


            //int intagerOne = 4;
            //string stringOne = "Stefan";

            //string concatenateTwo = intagerOne + " " + stringOne;

            //Console.WriteLine(concatenateTwo);



            //int n = 12;
            //int m = 5;

            //int result = n / m;
            //Console.WriteLine(result);


            //int numberofApples = 8;
            //int basket= 5;

            //    int branches = 12;
            //    double resultofBranches = (branches * numberofApples) / basket;

            //Console.WriteLine(result);
            //EXCERCISE # 6
            //string firstIntager = Console.ReadLine();
            //string secondIntager = Console.ReadLine();

            //int parsedFirtstIntager = int.Parse(firstIntager);
            //int parsedSecondIntager = int.Parse(secondIntager);



            //if (parsedFirtstIntager > parsedSecondIntager)
            //{
            //    Console.WriteLine(parsedFirtstIntager + " " + "First number is biger!");
            //}
            //else if (parsedFirtstIntager < parsedSecondIntager)
            //{
            //    Console.WriteLine(parsedSecondIntager + " " + "Second number is biger!");
            //}


            //if (parsedFirtstIntager % 2 == 0 && parsedSecondIntager % 2 == 0)
            //{
            //    Console.WriteLine("The number is even");
            //}
            //else
            //{
            //    Console.WriteLine("The number is odd");
            //}


            //EX7
            Console.WriteLine("Select from the following numbers:");
            Console.WriteLine("1.Input  for a new car");
            Console.WriteLine("2.Input  for a new plane");
            Console.WriteLine("3.Input  for a new bike");

            string inputFrom = Console.ReadLine();
            bool parsedInputFromConsole = int.TryParse(inputFrom, out int parsedInput);
            switch (parsedInput)
            {
                case 1:
                    Console.WriteLine("You got a new car");
                    break;
                case 2:
                    Console.WriteLine("You got a new plane");
                    break;
                case 3:
                    Console.WriteLine("You got a new bike");
                    break;
                default:
                    Console.WriteLine("Input a correct number");
                    break;
            
        }

    }
}

