using System;
using DataAccess;


namespace Domain
{
    public class UserModel
    { 
        UserData userData = new UserData();

        public bool LoginUser(string Email, string Password)
        {
            return userData.Login(Email, Password);
        }
    }
}
