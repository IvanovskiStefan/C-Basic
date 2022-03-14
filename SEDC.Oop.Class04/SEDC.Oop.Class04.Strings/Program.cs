using System;

namespace SEDC.Oop.Class04.Strings
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = "Trajan";

            string hello1 = "Hello " + name;


            string hello2 = string.Format("Hello {0}", name);

            string hello3 = $"Hello {name}";

            Console.WriteLine(hello1);
            Console.WriteLine(string.Format("Hello {0}", name));
            Console.WriteLine(hello3);

            //escape chars
            string path = "Check your c:\\ drive";
            string a = "We will have \"fair\"  elections";
            string b = "the \\n sign means  : new line";

            Console.WriteLine(path);
            Console.WriteLine(a);
            Console.WriteLine(b);

            string path1 = @"Check your c:\ drive";
            string aa = @"We will have ""fair"" elections";
            string bb = @"The \n sign means : new line";

            Console.WriteLine(path1);
            Console.WriteLine(aa);
            Console.WriteLine(bb);

            string filePath = @"system\windows";
            string cc = $@"Check your c:\{filePath} drive";

            Console.WriteLine(cc);


            string myStringCurrency = string.Format("{0:C}", 105, 5);
            Console.WriteLine(myStringCurrency);


            string ourString = "          We are learning c#and it is FUN and EASY, okay maybe just FUN.                            ";

            string lowerLetters = ourString.ToLower();
            Console.WriteLine(lowerLetters);
            string upperLetters = ourString.ToUpper();
            Console.WriteLine(upperLetters);

            string[] splited = ourString.Trim().Split(' ');
            Console.WriteLine("The lenght is :" + splited.Length);

            foreach (string word in splited)
            {
                Console.WriteLine(word);
            }


            string substring = ourString.Substring(25, 50);
            Console.WriteLine(substring);
            Console.ReadLine();


            Console.WriteLine("Please enter a number");
            string parsedInput1 = Console.ReadLine();
            bool parsedInputFromConsole = int.TryParse(parsedInput1, out int ParsedInputFromUser);
            ExcStrings(ParsedInputFromUser);

        }
        public static void ExcStrings(int number)
        {
            string message = "Hello from SEDC Codecademy 2021";



            if (number > message.Length)
            {
                Console.WriteLine("The number is too large ");
                return;
            }
            string message1 = message.Substring(0, number);

            Console.WriteLine(message1);

        }


    }
    



}

