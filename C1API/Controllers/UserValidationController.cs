using C1API.Data.Interfaces;
using C1API.Data.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C1API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserValidationController : ControllerBase
    {
        private IUserRepository users = new UserRepository();

        [HttpGet]
        public bool ValidateUser(string uName, string pss)
        {
            var credentials = users.GetAllUsers();
            foreach (var credential in credentials)
            {
                if (uName==credential.UserName && pss==credential.Pass)
                {
                    return true;
                }
                return false;
            }
            return false;
        }
    }
}
