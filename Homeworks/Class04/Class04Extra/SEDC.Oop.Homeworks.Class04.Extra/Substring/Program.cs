using System;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence");
            string inputFromCon = Console.ReadLine();
            Console.WriteLine("enter the data that you want to see how many times it appears in the string");
            string inputForCounting = Console.ReadLine();
           
            substringCount(inputFromCon, inputForCounting);
        }
        public static void substringCount(string inputFromCon, string inputForCounting)
        {
            int strt = 0;
            int cnt = -1;
            int idx = -1;
            

            while( strt != -1)
            {
                strt = inputFromCon.IndexOf(inputForCounting, idx + 1);
                    cnt += 1;
                    idx = strt;
            }
            Console.Write("The string '{0}' occurs " + cnt , inputForCounting);
            // ovaa ne ja razbrav, copy paste e od w3schools, i ne ja smetam za resena !!! :D

        }
    }
}


