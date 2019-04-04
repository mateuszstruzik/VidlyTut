using System;
using System.Collections.Generic;
using System.Linq;
using TemporaryRepository.Models;

namespace TemporaryRepository
{
    public class TempRepo
    {
        public List<UserModel> UsersCollection = new List<UserModel>
        {
            new UserModel
            {
                UserName = "Mateusz",
                Password = "123456"
            },
            new UserModel
            {
                UserName = "John",
                Password = "qwert"
            }
        };

        public bool GetUser(string name, string pass)
        {
            var matchingUser = UsersCollection.FirstOrDefault(f => f.UserName == name && f.Password == pass);

            if (matchingUser != null)
                return true;
            else
                return false;
        }
    }
}
