using SEDC.Oop.Class7.Excercise1.ExcerciseApp;
using SEDC.Oop.Class07.SEDC.Oop.Class7.Excercise1.Models;
using System;
using System.Collections.Generic;
using System.Text;
using SEDC.Oop.Class07.SEDC.Oop.Class7.Excercise1.Models.Enums;

namespace SEDC.Oop.Class07.SEDC.Oop.Class7.Excercise1.Models
{
    public class SalesPerson  : Employee
    {
        private double SuccessSaleRevenue { get; set; }


        
        //public SalesPerson()
        
        //{
        //    Role = Role;
        //    Salary = 500;

        //}
        public SalesPerson( string firstName, string lastName, double salary = 500)
            :base(firstName,lastName,Role.Sales, salary)
        {
            
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
