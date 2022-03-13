using System;

namespace SEDC.Homeworks.Oop.sumOfEven
{
    class Program
    {
        static void Main(string[] args)
        {
            //Homework 1
            //Array
            int[] numbers = new int[6] ;
            int lenghtOfArray = numbers.Length;
                       
            //for the result
            int result = 0;
            // the loop
        for (int i =0 ; i < lenghtOfArray; i++)
            {
                //persing
                string inputFromConsole = Console.ReadLine();
                bool parsedInputFromConsole = int.TryParse(inputFromConsole, out int parsedInput);


                if (parsedInput % 2 == 0)
                {
                    result += parsedInput;
                }
            
            }
            Console.WriteLine(result);
               
        
        
        
        
        
        
        }
    }
}
