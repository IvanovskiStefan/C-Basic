using System;

namespace UpperToLowerViceVersa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write the sentence that you want to be converted," +
                "from uppercase to lowercase and vice versa");
            string inputFromConsole = Console.ReadLine();
            char[] arrayFromConsole = inputFromConsole.ToCharArray();
            conversion(inputFromConsole);
        }

        public static void conversion(string arrayFromConsole)
        {
            string convertedString = string.Empty;

            for(int i = 0; i < arrayFromConsole.Length; i++)
            {
                if (char.IsUpper(arrayFromConsole[i]))
                {
                    convertedString += char.ToLower(arrayFromConsole[i]);
                } else
                    convertedString += char.ToUpper(arrayFromConsole[i]);

            }
            Console.WriteLine($"The converted sentence is : {convertedString}");

        }
        }
    }

