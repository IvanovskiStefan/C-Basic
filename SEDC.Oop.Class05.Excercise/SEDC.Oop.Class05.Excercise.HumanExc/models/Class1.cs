using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Oop.Class05.Excercise.HumanExc.models
{
    public class Human
    {
        public string FirstName { get; set; }
        
        public string LastName { get; set; }
        
        public int Age { get; set; }

        public Human (string fName, string lName , int age)
	{
            FirstName = fName;
            LastName = lName;
            Age = age;
	}

    }

    
    public void string GetPersonStats ()
    {

       return GetPersonsStats($"{FirstName}{LastName}{Age}");

    };
