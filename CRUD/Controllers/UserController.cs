
using CRUD.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRUD.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private static List<User> Users()
        {
            return new List<User>{
                new User {Id = 483, Name = "Marcelo", birthDate = new DateTime(2001, 04, 22)},
                new User {Id = 12, Name = "Gledson", birthDate = new DateTime(1980, 12, 28)}
            };
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Users());
        }

        [HttpPost]
        public IActionResult Post(User user)
        {
            var users = Users();
            users.Add(user);
            return Ok(users);
        }
    }
}