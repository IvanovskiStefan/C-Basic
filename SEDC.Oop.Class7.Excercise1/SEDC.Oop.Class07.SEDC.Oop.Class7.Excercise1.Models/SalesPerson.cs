using SEDC.Oop.Class7.Excercise1.ExcerciseApp;
using SEDC.Oop.Class07.SEDC.Oop.Class7.Excercise1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Oop.Class07.SEDC.Oop.Class7.Excercise1.Models
{
    public class SalesPerson  : Employee
    {
        private double SuccessSaleRevenue { get; set; }


        
        public SalesPerson()
        
        {
            Role = Role.Sales;
            Salary = 500;

        }
        public SalesPerson( string firstName, string lastName, Role role, double salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Role = role;
            Salary = salary;
        }

        public void  AddSuccessRevenue( double value)
        {
            SuccessSaleRevenue = value;
        }

        public override double GetSalary()
        {
            double bonus = 0;
           
            if (SuccessSaleRevenue <= 200)
            {
                bonus = 500;
            }
            
            if(SuccessSaleRevenue > 2000  && SuccessSaleRevenue <= 5000)
            {
                bonus += 1000;
            }

            if (SuccessSaleRevenue > 5000)
            {
                bonus = 1500;
            }

            return bonus;
       
        }
       
    }

}
