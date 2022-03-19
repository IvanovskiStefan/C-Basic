using System;

namespace SEDC.Oop.Homework.Class04.AgeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please input your birth date in one of this formats");
            Console.WriteLine("MM.DD.YYYY,MM/DD/YYYY");
            Console.WriteLine("MM/DD/YY,dec.DD.YY,MM-DD-YYYY");

            string birthDay = Console.ReadLine();
            DateTime parsedbirthDay = DateTime.Parse(birthDay);


            AgeCalculator(parsedbirthDay);




        }

        public static void AgeCalculator(DateTime birthday)
        {
            DateTime todayDate = DateTime.Today;

            int yourAge = todayDate.Year - birthday.Year;

            if (todayDate.Month < birthday.Month)
            {
                yourAge -= 1;
            }

            if (todayDate.Month == birthday.Month && todayDate.Day < birthday.Day)
            {
                yourAge -= 1;

            };

            Console.WriteLine(yourAge);
        }
    }
}
