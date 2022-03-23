using SEDC.Oop.Class07.Services;
using System;

namespace SEDC.Oop.Class07.ClassLibraries
{
    class Program
    {
        static void Main(string[] args)
        {

            EmpoyeeService employeeService = new EmpoyeeService();
            employeeService.CreateAndWriteInConsole();

            Console.ReadLine();
        }
    }
}
