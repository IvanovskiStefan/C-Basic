using SEDC.Oop.Class07.SEDC.Oop.Class7.Excercise1.Models.Enums;
using SEDC.Oop.Class7.Excercise1.ExcerciseApp;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Oop.Class07.SEDC.Oop.Class7.Excercise1.Models
{
    public class Contractor : Employee
    {
        public double WorkHours { get; set; }
        public int PayPerHour { get; set; }
        public Manager Responsible { get; set; }


        public Contractor(string firstName, string lastName, double salary, double workHours, int payPerHour, Manager responsible)
             : base(firstName, lastName, Role.Other,salary)
        {
            WorkHours = workHours;
            PayPerHour = payPerHour;
            Responsible = responsible;
        }
        public override double GetSalary()
        {
            double result = WorkHours * PayPerHour;
            Salary = result;
            return result;
        }

        public  Department CurrentPosition()
        {
            return Responsible.Department;
        }

    }
}
