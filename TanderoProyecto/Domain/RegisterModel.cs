using System;
using DataAccess;

namespace Domain
{
    public class RegisterModel
    {
        private readonly UserRegister userRegister = new UserRegister();

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
