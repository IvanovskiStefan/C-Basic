using System;

namespace WhatTypeIsTheChar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a character to find out if the char is an alphabet");
            string inputFromCons= Console.ReadLine();
            char[] arrayFromCons = inputFromCons.ToCharArray();
            isTheCharAlpha(inputFromCons);
        }

        public static void isTheCharAlpha( string arrayFromCons)
        {
            for(int i = 0; i < arrayFromCons.Length; i++)
            {
                bool isCharacterAlpha = true;
                bool isCharacterDigit = true;

                if (Char.IsLetter(arrayFromCons[i]) == isCharacterAlpha)
                {
                    Console.WriteLine($"The character is alphabet");
                } 
                
                else if (Char.IsDigit(arrayFromCons[i]) == isCharacterDigit)
                
                {
                    Console.WriteLine($"The character is digit");
                }

                if(Char.IsLetter(arrayFromCons[i]) != isCharacterAlpha && 
                    Char.IsDigit(arrayFromCons[i]) != isCharacterDigit)
                {
                    Console.WriteLine($"Enter a valid character");

                }

            }

        }
    }
}
