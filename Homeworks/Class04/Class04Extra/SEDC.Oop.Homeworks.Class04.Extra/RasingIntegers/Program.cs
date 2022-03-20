using System;

namespace RasingIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Number to be raised(isparsirani)
            Console.WriteLine("enter the number that you want to raise :D");
            string numberToBeRaised = Console.ReadLine();
            bool parsedNumToBeRaised = int.TryParse(numberToBeRaised, out int parsedNumber1);
            //2.Number to raise the first Num!(isparsirani)
            Console.WriteLine("enter how much do you want  to raise the first number :D");
            string numberToRaiseFirst = Console.ReadLine();
            bool parsedNumberToRaiseFirst = int.TryParse(numberToRaiseFirst, out int parsedNumber2);
            NumbersToBeRaised(parsedNumber1, parsedNumber2);
        }
        public static void NumbersToBeRaised(int parsedNumber1, int parsedNumber2)
        {
            int sum = 0;
            sum = (int)Math.Pow(parsedNumber1, parsedNumber2);
            Console.WriteLine($"The number : {parsedNumber1}, raised by {parsedNumber2} is : {sum}");


        }

    }  
    
}
