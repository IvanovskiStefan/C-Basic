using System;

namespace SEDC.Oop.Class05.Excercise2
{
    class Program
    {
        static void Main(string[] args)
        {


            Dog dog1 = new Dog
            {

                Name = "Churchill",
                Race = "English Bulldog",
                Color = "White"

            };

            dog1.ChaseTail();
            Console.WriteLine(dog1.ChaseTail());

        }
    }
}
