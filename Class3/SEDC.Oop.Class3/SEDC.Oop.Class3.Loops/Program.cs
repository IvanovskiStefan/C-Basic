using System;

namespace SEDC.Oop.Class3.Loops
{
    class Program
    {
        static void Main(string[] args)
        {

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}


            //int timestToItterate = 100;

            //for (int index = timestToItterate;index >0; index --)

            //{
            //    Console.WriteLine(index);
            //}


            //int index = 0;
            //while (index < 10)
            //{
            //    Console.WriteLine(index);
            //    index += 1;
            //}


            //string str = "Stefan";
            //int counter = 0;
            //while (str == "Stefan")
            //{
            //    if (counter == 10)
            //    {
            //        str = "something else";
            //        Console.WriteLine(str);
            //    }

            //    Console.WriteLine(str);
            //    counter += 2;

            //}

            //bool isActive = true;
            //while (isActive)
            //{
            //    //Console.Clear();
            //    Console.WriteLine("1.Say Hello");
            //    Console.WriteLine("2.Say goodbye");
            //    Console.WriteLine("3.say something else");
            //    Console.WriteLine("0.Exit application");
            //    string input = Console.ReadLine();

            //    bool isValidInput = int.TryParse(input, out int selection);


            //    if (!isValidInput)
            //    {
            //        Console.WriteLine("please enter a valid ipnut");
            //        continue;
            //    }

            //    if (selection == 1)
            //    {
            //        Console.WriteLine("Hello");
            //    }

            //    else if (selection == 2)

            //    {
            //        Console.WriteLine("Goodbye");
            //    }
            //    else if (selection == 3)
            //    {
            //        Console.WriteLine("Say smthg else");
            //    }
            //    else if (selection == 0)
            //    {
            //        Console.WriteLine("Thanks for using our app");
            //        isActive = !isActive;
            //    }
            //    else

            //        Console.WriteLine("please enter a valid ipnut");

            //}


            //int counter = 0;

            //do
            //{
            //    Console.WriteLine("We will be executed always minimum once");
            //} while (counter != 0);

            while (true)
            {
                Console.WriteLine("Enter a valid number");
                Console.WriteLine("To exit the app enter A");
                Console.WriteLine("To exit the app enter 0");


                string input = Console.ReadLine();
                if (input == "A")
                {
                    break;
                }
                bool isValidInput = int.TryParse(input, out int selection);
                     if (!isValidInput)
                {
                    Console.WriteLine("not valid number");
                    continue;
                }
                if (selection == 0) 
                {
                    break;
                }
                int result = selection * 10;
                Console.WriteLine("the result is :" + result);

                while (true)
                {
                    while (true)
                    {

                    }
                }
                
                
            }









            Console.ReadLine();
        }
    }
}
