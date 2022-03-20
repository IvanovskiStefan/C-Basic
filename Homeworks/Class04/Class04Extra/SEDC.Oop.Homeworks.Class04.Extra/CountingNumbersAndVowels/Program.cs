using System;

namespace CountingNumbersAndVowels
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write the text that you want to find out how many characters has and how many vowels it contains");

            string inputFromConsole = Console.ReadLine().ToLower();
            countingChars(inputFromConsole);
            countingVowels(inputFromConsole);
        }
        public static void countingChars(string inputFromConsole)
        {
            int count = inputFromConsole.Length;
            Console.WriteLine($"The number of digits is : {count}");
        }
        public static void countingVowels(string inputFromConsole)
        {
            int totalVowels = 0;
            foreach ( char vowel in inputFromConsole)
            {
                switch (vowel)
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        totalVowels++;
                        break;
                    
                }

            }
            Console.WriteLine("The total numbers of vowels is: {0}", totalVowels);
        }
            
        }
    }

