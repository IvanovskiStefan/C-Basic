using System;
using System.Collections;
using System.Collections.Generic;

namespace SEDC.Oop.Class08.CSharpCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strArray = new string[4];
            string[] strArray2 = new string []{ "Hello", "World" };
            GoThruCollection(strArray2, "Array");

                Array.Resize(ref strArray2, strArray2.Length + 1);
            strArray2[strArray2.Length - 1] = "!";
            GoThruCollection(strArray2, "Array");

            List<int> numbers = new List<int>();
            numbers.Add(5);
            numbers.Add(7);
            numbers.Add(9);
            numbers.Add(3);
            numbers.Remove(9);
            Console.WriteLine("list count is :" + numbers.Count);
            Console.WriteLine(numbers[2]);
            numbers[2] = 5;
            GoThruCollection(numbers, "List of integers");
            


            Console.ReadLine();
        }

        public static void GoThruCollection(IEnumerable collecton, string name)
        {

            Console.WriteLine("Collection {0 }items ", name);

            foreach(var item in collecton)
            {
                Console.WriteLine("{0}", item);

            }
            Console.WriteLine();
        }
    }
}
