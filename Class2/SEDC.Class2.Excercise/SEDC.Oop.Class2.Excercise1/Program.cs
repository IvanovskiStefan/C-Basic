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

            string firstIntager = Console.ReadLine();
            string secondIntager = Console.ReadLine();

            int parsedFirtstIntager = int.Parse(firstIntager);
            int parsedSecondIntager = int.Parse(secondIntager);

            if (parsedFirtstIntager > parsedSecondIntager)
            {
                Console.WriteLine(parsedFirtstIntager);
            }
            else if (parsedFirtstIntager < parsedSecondIntager)
            {
                Console.WriteLine(parsedSecondIntager);
            }
            else if ()
            {

            }
        }

    }
}

