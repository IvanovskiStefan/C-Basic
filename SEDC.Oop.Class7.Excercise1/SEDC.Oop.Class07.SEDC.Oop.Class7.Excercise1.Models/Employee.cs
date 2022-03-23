using SEDC.Oop.Class07.SEDC.Oop.Class7.Excercise1.Models;
using SEDC.Oop.Class7.Excercise1.ExcerciseApp.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Oop.Class7.Excercise1.ExcerciseApp
{
     public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Role Role { get; set; }
        protected double Salary { get; set; }

        public virtual double GetSalary()
        {
            return Salary;
        }

        public Employee()
        {

        }
        public void GetInfo()
        {
            Console.WriteLine($"{FirstName}, {LastName}, {Salary}");
        }
    }
    
   

}
