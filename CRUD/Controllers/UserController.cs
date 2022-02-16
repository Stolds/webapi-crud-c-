
using CRUD.Models;
using CRUD.Repository;
using Microsoft.AspNetCore.Mvc;

namespace CRUD.Controllers
{
    [ApiController]
    [Route("api/user")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository repository;

        public UserController(IUserRepository repository)
        {
            this.repository = repository;
        }



        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var users = await repository.SearchUsers();
            return users.Any()
                ? Ok(users)
                : NoContent();

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var user = await repository.SearchUser(id);
            if (user != null)
            {
                return Ok(user);
            }
            return NotFound($"The user with the id = {id} has not founded");
        }

        [HttpPost]
        public async Task<IActionResult> Post(User user)
        {
            repository.AddUser(user);
            return await repository.SaveChangesAsync()
            ? Ok("User added sucessfully")
            : BadRequest("Error at saving a new user");
        }
    }
}