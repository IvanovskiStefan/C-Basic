using System;

namespace SEDC.Oop.Class04.Dates
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime date = new DateTime();

            Console.WriteLine(date);

            DateTime customDate = new DateTime(1992,10,05);

            Console.WriteLine(customDate);

            string date1 = "12.15.2012";
            string date2 = "12/15/2012";
            string date3 = "12/15/15";
            string date4 = "dec.15.12";
            string date5 = "12-15-12";


            DateTime convertedDate1 = DateTime.Parse(date1);
            DateTime convertedDate2 = DateTime.Parse(date2);
            DateTime convertedDate3 = DateTime.Parse(date3);
            DateTime convertedDate4 = DateTime.Parse(date4);
            DateTime convertedDate5 = DateTime.Parse(date5);
            
            Console.WriteLine(convertedDate1);
            Console.WriteLine(convertedDate2);
            Console.WriteLine(convertedDate3);
            Console.WriteLine(convertedDate4);
            Console.WriteLine(convertedDate5);



            DateTime currentDay = DateTime.Today;

            //Console.WriteLine(currentDay);
            //DateTime currentDateAndTIme = DateTime.Now;
            //DateTime addedDays = currentDateAndTIme.AddDays(5);
            //DateTime removeDays = currentDateAndTIme.AddDays(-10);

            //ex1
            DateTime currentDateAndTIme = DateTime.Now;

            DateTime addedDays = currentDateAndTIme.AddDays(3);
            Console.WriteLine(addedDays);
            DateTime addedMonths = currentDateAndTIme.AddMonths(1);
            Console.WriteLine(addedMonths);
            DateTime addedMonthsAndDays = currentDateAndTIme.AddMonths(1).AddDays(3);
            Console.WriteLine(addedMonthsAndDays);
            DateTime addOneYearAndTwoDays = currentDateAndTIme.AddYears(1).AddMonths(2);
            Console.WriteLine(addOneYearAndTwoDays);
            int justthemonth = currentDateAndTIme.Month;
            Console.WriteLine(justthemonth);
            int justtheyear = currentDateAndTIme.Year;
            Console.WriteLine(justtheyear);



            Console.WriteLine(currentDateAndTIme);


            Console.ReadLine();
        }
    }
}
