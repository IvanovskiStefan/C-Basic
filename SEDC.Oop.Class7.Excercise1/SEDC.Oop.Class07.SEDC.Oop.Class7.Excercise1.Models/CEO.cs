using SEDC.Oop.Class07.SEDC.Oop.Class7.Excercise1.Models.Enums;
using SEDC.Oop.Class7.Excercise1.ExcerciseApp;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Oop.Class7.SEDC.Oop.Class7.Excercise1.Models
{
   public class CEO :Employee
    {
        public Employee[] Employees { get; set; }
        public int Shares { get; set; }
        public double SharesPrice ;

        public CEO(string firstName, string lastName, int salary, Role role, Employee[] employees, int shares)
            : base(firstName, lastName, role, salary)
        {
            Employees = employees;
            Shares = shares;
        }

        public double AddSharesPrice(double value)
        {
            SharesPrice = value;
            return SharesPrice;
        }

        public void PrintEmployees()
        {
            //for (int i = 0; i < Employees.Length; i++)
            //{
            //    Console.WriteLine($"{Employees[i].FirstName} {Employees[i].LastName}");
            //}

            foreach (Employee employee in Employees)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName}");
            }
        }

        public override double GetSalary()
        {
            double result = Salary + Shares * SharesPrice;
            return result;
        }
    }



}
