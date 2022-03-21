using System;

namespace SEDC.Oop.Class06.NumberStats
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number to check it's status :D");
            string inputFromUser = Console.ReadLine();
            bool parsedInput = double.TryParse(inputFromUser, out double ParsedInputFromUser);
            infoModel model = new infoModel(ParsedInputFromUser);
            model.CalculateNumber();
            model.PrintStats();
        }

        
    }

   
}
