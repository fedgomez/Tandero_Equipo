using System;
using DataAccess;


namespace Domain
{
    public class UserModel
    { 
        UserData userData = new UserData();

        public bool LoginUser(string Email, string Password)
        {
            try
            {
                return userData.Login(Email, Password);
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
