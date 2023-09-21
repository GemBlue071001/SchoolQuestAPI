using BusinessLogicLayer.IService;
using BusinessLogicLayer.RequestModel.User;
using BusinessLogicLayer.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HighSchoolQuestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        public IUserService UserService { get; set; }
        public UsersController(IUserService userService)
        {
            UserService = userService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(UserRegisterRequest user)
        {
            var result = await UserService.RegisterAsync(user);
            
            return Ok(result);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginRequest user)
        {
            var token = await UserService.LoginAsync(user);
            return Ok(token);
        }


    }
}
