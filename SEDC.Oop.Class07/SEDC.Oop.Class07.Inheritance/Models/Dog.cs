using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Oop.Class07.Inheritance.Models
{
   public class Dog : Animal
    {

        
        public bool IsPlayfull { get; set; }

        public Dog()
        {
            Console.WriteLine("A new dog instance of dog is created by the parent constructor");
        }

        public Dog( string name, string type)
            :base(name, type, "Doggy")
        {
            IsPlayfull = false;
            Console.WriteLine("A new dog instance of dog is created by the parent constructor with parameters.");

        }
    }

}
