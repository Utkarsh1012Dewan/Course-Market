using backend.Models;
using backend.Models.DTOs;
using backend.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class UserController : ControllerBase
    {
        private readonly IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpGet("/{id}")]
        public async Task<ActionResult<User>> GetUserByIdAsync(string id)
        {
            var user = await userService.GetUserByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        [HttpPost("/{createProject}")]
        public async Task<ActionResult<User>> CreateUserAsync(UserDTO user)
        {
            var createdUser = await userService.CreateUserAsync(user);
            return Ok(createdUser);
        }

        [HttpPut]
        public async Task<ActionResult<User>> UpdateUserAsync(UserDTO user)
        {
            await userService.UpdateUserAsync(user);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<User>> DeleteUserAsync(string id)
        {
            await userService.DeleteUserByIdAsync(id);
            return Ok();
        }
    }
}
