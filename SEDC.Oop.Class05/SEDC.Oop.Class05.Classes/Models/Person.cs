﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Oop.Class05.Classes.Models
{
    //sekogas dodavaj ACCESS MODIFIER!!!!    
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        private long SSN { get; set; }

        public Person()
        {
            SSN = GenerateSSN();
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            SSN = GenerateSSN();

        } 
        
        private long GenerateSSN()
        {
            Random rand = new Random();
            long ssn = rand.Next(100_000, 999_999);
            return ssn;
        }
        
        public void Talk(string text)
        {
            Console.WriteLine($"The human named {Name} (SSN:{SSN}) is saying:{text} "); 
        }

    }
}