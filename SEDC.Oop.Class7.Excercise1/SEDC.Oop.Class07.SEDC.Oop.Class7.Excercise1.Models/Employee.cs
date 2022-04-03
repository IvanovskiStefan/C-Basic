using SEDC.Oop.Class07.SEDC.Oop.Class7.Excercise1.Models.Enums;
using System;

namespace SEDC.Oop.Class7.Excercise1.ExcerciseApp
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Role Role { get; set; }
        protected double Salary { get; set; }

        public Employee()
        {

        }

        public Employee( string firstName, string lastName, Role role, double salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Role = role;
            Salary = salary;
        }
        

        public virtual double GetSalary()
        {
            Console.WriteLine($"The salary of {FirstName} {LastName} is : {Salary} ");
            return Salary;
        }

        
        public void GetInfo()
        {
            Console.WriteLine($"{FirstName}, {LastName}, {Salary}");
        }
    }
    
   

}
