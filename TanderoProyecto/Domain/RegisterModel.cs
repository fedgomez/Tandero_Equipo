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
            try
            {
                return userRegister.Register(Name, Email, Password);
            }
            catch (InvalidCastException e)
            {
                if (e.Source != null)
                    Console.WriteLine("IOException source: {0}", e.Source);
                throw;
            }
            
        }
    }
}
