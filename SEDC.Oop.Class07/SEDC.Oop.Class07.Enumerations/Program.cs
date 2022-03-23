using SEDC.Oop.Class07.Enumerations.Models;
using SEDC.Oop.Class07.Enumerations.Enums;

using System;

namespace SEDC.Oop.Class07.Enumerations
{
    class Program
    {
        static void Main(string[] args)
        {

            Administrator admin = new Administrator("bob");
            admin.Role = Roles.SuperGuest;

            bool a = Enum.TryParse(typeof(Roles), "2" , out object role);

            Console.ReadLine();
        }
    }
}
