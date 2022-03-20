using System;

namespace GreatestValue
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = { 356421 , 12, 15, 1, 886, 900, 11020 };
            int biggestValue = values[0];

            ReturnBiggest(values,biggestValue);
        }
        public static  void ReturnBiggest(int[] values, int biggestValue)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > biggestValue)
                {
                    biggestValue = values[i];
                }
            }
            Console.WriteLine(biggestValue); ;
        }
    
    }
}
