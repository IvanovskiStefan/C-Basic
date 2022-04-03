using SEDC.Oop.Class07.SEDC.Oop.Class7.Excercise1.Models.Enums;
using SEDC.Oop.Class7.Excercise1.ExcerciseApp;
using System;
namespace SEDC.Oop.Class07.SEDC.Oop.Class7.Excercise1.Models
{
    public class Manager : Employee
    {
        private double Bonus { get; set; }

        public Department Department { get; set; }

        public Manager( string firstName, string lastName, double salary, Department department)
            : base (firstName,lastName,Enums.Role.Manager, salary)

        {
            Department = department;
            Bonus = 0;
        }

        public void AddBonus(double value)
        {
            Bonus += value;
        }

        public override double GetSalary()
        {
            double result = Salary + Bonus;
            Console.WriteLine(result);
            return result;
        }
    }
}
