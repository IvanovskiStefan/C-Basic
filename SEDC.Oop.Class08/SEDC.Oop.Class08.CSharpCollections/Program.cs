using System;
using System.Collections;
using System.Collections.Generic;

namespace SEDC.Oop.Class08.CSharpCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Arrays
            string[] strArray = new string[4];
            string[] strArray2 = new string []{ "Hello", "World" };
            GoThruCollection(strArray2, "Array");

                Array.Resize(ref strArray2, strArray2.Length + 1);
            strArray2[strArray2.Length - 1] = "!";
            GoThruCollection(strArray2, "Array");
            #endregion


            #region list

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

            #endregion


            #region dictionary
            Dictionary<string, string> dicionaryOne = new Dictionary<string, string>();
            dicionaryOne.Add("song1", "winds of change");
            dicionaryOne.Add("song2", "Enter Sandman");
            dicionaryOne.Add("animal", "dog");
            //dicionaryOne.Add("animal", "Cat");// key always must be unique!!
            Dictionary<int, string> dictionaryTwo = new Dictionary<int, string>
            {
                {4, "Hello" },
                {5, "world"},
                {6, "!"}

            };
            GoThruCollection(dicionaryOne, "Dictionary");

            Dictionary<int, MyType> myTypeDictionary = new Dictionary<int, MyType>();
            Dictionary<string, List<string>> bandSongsDictionary = new Dictionary<string, List<string>>();
                       
            foreach(KeyValuePair<int,string> keyValue in dictionaryTwo)
            {
                
                Console.WriteLine(dictionaryTwo[keyValue.Key]);          
            }

            dictionaryTwo.Remove(4);
            #endregion

            #region Stack and Queue
            Console.WriteLine("++++++++++++QUEUE++++++++++++");
            Queue <int>  someQueue = new Queue<int>();
            someQueue.Enqueue(25);
            someQueue.Enqueue(2);
            someQueue.Enqueue(3);
            someQueue.Enqueue(46);
            int firstElement = someQueue.Dequeue();
            Console.WriteLine(firstElement);
            GoThruCollection(someQueue, "queue");
            Console.WriteLine(someQueue.Peek());
            Console.WriteLine("Lenght :" + someQueue.Count);

            Console.WriteLine("++++++++++++STACK++++++++++++");

            Stack<string> someStack = new Stack<string>();
            someStack.Push("hey");
            someStack.Push("Hello");
            someStack.Push("hi");
            someStack.Push("Zdravo");

            string item = someStack.Pop();
            Console.WriteLine("POP"+ item);
            Console.WriteLine("PEEK:" + someStack.Peek());


            GoThruCollection(someStack, "STACK");




            #endregion
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

        public class MyType
        {

        }
    }
}
