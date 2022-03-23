using SEDC.Oop.Class07.Inheritance.Models;
using System;

namespace SEDC.Oop.Class07.Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            Animal animal = new Animal() { Name = "Dambo", Id = 5, Type ="Elephant" ,Race = "Whiteones" };
            animal.Eat();
            Console.WriteLine();
            Dog dog = new Dog() { Name = "Sparky", Id = 2, Type = "Dog", Race = "Bulldog", IsPlayfull = true };
            //dog.Eat();
           
            Console.WriteLine();
            Cat cat = new Cat() { Name = "Garfield", Id = 4, Type = "YellowCat", Race= "Cat",IsLazy = true};
            cat.Eat();
            cat.CatEat();
            Console.WriteLine();
            //Dog dog2 = new Dog("sparky2", "dog");

            //Cat cat2 = new Cat("Cat2", "cat", "norace", true);
                        
            
            
            
            Console.ReadLine();
            
        }
    }
}
