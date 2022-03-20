using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write the word if you want to check if the word is a palindrome");

            string inputFromScreen = Console.ReadLine();
            //so malce pomos od youtube, se iznamaciv dodeka svatam deka treba da proveri karakter po karakter :D
            char[] normal = inputFromScreen.ToCharArray();
            char[] reversed = inputFromScreen.ToCharArray();
            Array.Reverse(reversed);


            TheWordFromInput( normal, reversed);
        }

        public static void TheWordFromInput(char[] normal, char[] reversed)
        {
            bool palindrome = true;
           
            for (int i = 0; i < normal.Length; i++)
            {   //&& normal.ToString().ToLower() != reversed.ToString().ToLower() uste edna proverka zosto palindormot ako e napisan
                //so prvata bukva golema booleanot izlagase false sekogas, a zborot e palindrom
                 
                if (normal[i] != reversed[i] && normal[i].ToString().ToLower() != reversed[i].ToString().ToLower())
                {
                   
                    palindrome = false;
                }


            }
            Console.WriteLine($"Is the word a palindrome? : {palindrome}");

        }
    }
}


