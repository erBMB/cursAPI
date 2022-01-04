using C1API.Data.Interfaces;
using C1API.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace C1API.Data.Repository
{
    public class UserRepository:IUserRepository
    {
        public List<User> users = new List<User>()
        {
            new User{Id=1,UserName="pValentin",Pass="123"},
            new User{Id=2,UserName="Emil", Pass="5!3"},
            new User{Id=3,UserName="Cornel",Pass="512"},
            new User{Id=4,UserName="Pilot",Pass="b!c"},
        };

        public List<User> GetAllUsers()
        {
            return users;
        }

        public User GetUser(int id)
        {
            return users.FirstOrDefault(u => u.Id == id);
        }
    }
}
