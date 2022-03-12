using System;

namespace SEDC.Oop.Class3.Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = new int[5];
            numbers[0] = 1;
            numbers[1] = 2;
            
            numbers[3] = 4;
            numbers[4] = 5;

            Console.WriteLine(numbers[2]);



            string[] names = new string[]
            {
                    "stefan",
                    "aneta",
                    "trajan",
                    "vlatko"
            };

            bool[] booleans = { true, false, true, false, false };




            double[] doubles = { 1.1, 1.2, 1.3 };

            string[] names1 = new string[]
            {
                    "stefan",
                    "aneta",
                    "trajan",
                    "vlatko"
            };


            int lenghtOfArray = names1.Length;

            for (int i = 0; i < names1.Length; i++)
            {
                Console.WriteLine(names1[i]);
            }


            int indexOnVlatko = Array.IndexOf(names1, "vlatko");
            Console.WriteLine("the index is  :" + indexOnVlatko);
            Console.WriteLine("the value is:" + names1[indexOnVlatko]);


            Array.Resize(ref names1, names1.Length + 2);

            names1[4] = "Bob";
            names1[5] = " Jill";

            for (int i = 0; i < names1.Length; i++)
            {
                Console.WriteLine(names1[i]);
            }

            foreach(string element in names1)
            {
                Console.WriteLine("for each with names :" + element);
            }






            foreach( string name in names1) { 
            {
                if (name == "trajan")
                    continue;
            }
           
                if (name == "aneta")
            {
                break;
            }
            }





            Console.ReadLine();
        }
    }
}
