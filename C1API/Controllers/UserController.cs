using C1API.Data.Interfaces;
using C1API.Data.Models;
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
    public class UserController : ControllerBase
    {
        private IUserRepository users = new UserRepository();

        [HttpGet]
        public ActionResult<IEnumerable<User>> GetAllUsers()
        {
            return users.GetAllUsers();
        }

        [HttpGet("{id}")]
        public ActionResult<User>GetUser(int id)
        {
            var user = users.GetUser(id);
            if (user==null)
            {
                return NotFound();
            }
            return user;
        }

    }
}
