using C1API.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace C1API.Data.Interfaces
{
    public interface IUserRepository
    {
        List<User> GetAllUsers();
        User GetUser(int id);
    }
}
