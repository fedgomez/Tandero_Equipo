using System;
using System.Collections.Generic;
using System.Text;
using DataAccess;

namespace Domain
{
    public class RegisterModel
    {
        UserRegister userRegister = new UserRegister();

        public bool RegisterUser(string Name, string Email, string Password)
        {
            return userRegister.Register(Name, Email, Password);
            
        }
    }
}
