using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Oop.Class06.NumberStats
{
    class InfoModel
    {
        public bool IsPositive { get; set; }
        public bool IsOddM { get; set; }
        public bool isDecimal { get; set; }

        public double Num { get; set; }

        public InfoModel(double num)
        {
            Num = num;
        }
        public  void CalculateNumber()
        {
            IsPositive = Num >= 0;
            IsOddM = Num % 2 == 0;
            isDecimal = Num % 1 == 0;
                        
        }

        public void PrintStats()
        {
            Console.WriteLine(IsPositive ? "Positive" : "Negative");
            Console.WriteLine(IsOddM ? "Even" : "Odd");
            Console.WriteLine(isDecimal ? "Integer" : "Decimal");

        }
    }


}
