using System;

namespace SEDC.Oop.Class02.Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello SEDC");
            //brojki
            int number = 3;

            long bigNumber = 1234556823211231;

            short shortNumber = 12000;

            byte smallNumber = 8;



            double doubleePrecisoinNumber = 12.091234;
            float singlePrecisionNumber = 123.1F;

            string str = "Trajan Stevkovski";
            char character = 'a';

            bool isSomethingTrue = false;

            DateTime currentDate = new DateTime();
            // nema da go kucame var na basic !!!!
            var a = 3;

            //Console.WriteLine("=======================================DATA ENTRY====================");

            //string input = Console.ReadLine();

            //Console.WriteLine("This is the input value: " + input);

            //int parsedToIntager = int.Parse(input);

            //Console.WriteLine("This is the input value: " + parsedToIntager);


            //bool parsedToBoolean = Convert.ToBoolean(input);
            //int parsedtoBoolean = Convert.ToInt32(input);

            //Console.WriteLine("This is the parsed input value: " + parsedToBoolean);

            //long parsedToLong = 0;
            //bool isValidInput = long.TryParse(input, out parsedToLong);
            //Console.WriteLine("is parsing valid:" + isValidInput);
            //Console.WriteLine("This is the parsed input value: " + parsedToLong);

            Console.WriteLine("====================BRANCHING======================");

            string input = Console.ReadLine();

            bool isValidInteger = int.TryParse(input, out int parsedInput);


            if (isValidInteger)
            {
                Console.WriteLine("the parsed number is  : " + parsedInput);

            } else
            {
                Console.WriteLine("Not valid input!");
            }

            int firstNumber = 5;
            int secondNumber = 10;
            int thirdNumber = 15;
            int forthNumber = 20;

            if (firstNumber < secondNumber && firstNumber > thirdNumber)
            {
                Console.WriteLine("the if statement is true !");
            } else if ( thirdNumber < forthNumber || secondNumber > forthNumber)
            {
                Console.WriteLine("the first statement is true!");
            } else if ( firstNumber <secondNumber)
            {
                Console.WriteLine("the first statement is true!");

            } else if (!(firstNumber < secondNumber))
            {
                Console.WriteLine("the first statement is true!"); 
            } 
            else
            {
                Console.WriteLine("we are in else");

            }

            Console.WriteLine("+++++++++++++++++++ SWITCH+++++++++++++++");

            int someNumber = 3;

            switch(someNumber)
            {
                case 1:
                    Console.WriteLine("We are at case 1");
                    break;
                //case 'a':
                //    break;
                //case "Something":
                //   break;
                case 2:
                    Console.WriteLine("We are at case 2");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("This is case 3,4,5");
                    break;

                default:
                    Console.WriteLine("If none ");
                    break;
                    
            }
            Console.ReadLine();
       
        }
       
    }



    }

