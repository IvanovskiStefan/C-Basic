using System;

namespace SEDC.Oop.Class04.Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //ex1
            Console.WriteLine("Please enter number 1");
            string parsedInput1 = Console.ReadLine();
            bool parsedInputFromConsole = int.TryParse(parsedInput1, out int ParsedInputFromUser1);
            Console.WriteLine("Please enter number 2");

            string parsedInput2 = Console.ReadLine();
            bool parsedInputFromConsole2 = int.TryParse(parsedInput2, out int ParsedInputFromUser2);

            Console.WriteLine( " if you want to multipy press *, if you want to substrac press -");
            string choice = Console.ReadLine();
            if(choice == "*")
            {
                Multiply(ParsedInputFromUser1, ParsedInputFromUser2);

            } 
            else if (choice == "-")
            {
                Substract(ParsedInputFromUser1, ParsedInputFromUser2);
            }

            //class
            //SayHello();
            //Sum(1, 2);
            //int result = Sum(1, 2);
            //Console.WriteLine(result);

            //string strResult = WelcomeUser("trajan", 33, true);
            //Console.WriteLine(strResult);

            //Console.ReadLine();
        }
        //public static void SayHello()
        //{
        //    Console.WriteLine("Hello SEDC!");
        //}
        //private static int Sum(int a, int b)
        //{
        //    int result = a + b;

        //    return result;
        //}
        //internal static string WelcomeUser(string userName, int age, bool shouldBeColored)
        //{

        //    if (shouldBeColored)
        //    {
        //        Console.ForegroundColor = ConsoleColor.DarkBlue;
        //    }
        //    string str = string.Empty;
        //    if (age > 30)
        //    {
        //        str = "Welcome  mr." + userName;
        //    }
        //    {
        //        str = "Welcome " + userName;
        //    }

        //    return str;

        //}
        //ex1
        private static int Multiply(int a, int b)

        {
            int result = a * b;
            Console.WriteLine(result);
            return result;
            
        }

        private static int Substract(int a, int b)
        {
            int result = a - b;
            Console.WriteLine(result);

            return result;
        }

        
    }
}
