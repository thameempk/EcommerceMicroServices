using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserManagement.Models;
using UserManagement.Repository;

namespace UserManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserServices _userServices;
        public UserController(IUserServices userServices) 
        {
            _userServices = userServices;
        }

        [HttpGet]
        public async Task<ActionResult> GetUsers()
        {
            return Ok(await _userServices.GetUsers());
        }

        [HttpGet("user-by-id")]
        public async Task<ActionResult> GetUserById(int id)
        {
            return Ok(await _userServices.GetUsersById(id));
        }

        [HttpPost]

        public async Task<ActionResult> AddUsers(Users users)
        {
            if (users == null)
            {
                return BadRequest();
            }

            return Ok(await _userServices.AddUser(users));
        }
    }
}
