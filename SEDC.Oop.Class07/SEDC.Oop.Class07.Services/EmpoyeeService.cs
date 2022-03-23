using SEDC.Oop.Class07.Models;
using SEDC.Oop.Class07.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Oop.Class07.Services
{
    public class EmpoyeeService
    {
        public void CreateAndWriteInConsole()
        {
            Employee employee = new Employee() { Id = 1, Name = "bob", Role = Role.Guest };
            Console.WriteLine($"Employee {employee.Name} is Created");
        }

    }
}
