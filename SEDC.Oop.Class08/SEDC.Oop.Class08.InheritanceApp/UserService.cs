using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Oop.Class08.InheritanceApp
{
    class UserService :BaseService
    {

        public void Login()
        {
            ValididateInteger(1);
        }

        public void Register()
        {
            validateString("");
        }


    }

}
