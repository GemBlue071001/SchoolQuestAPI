using BusinessLogicLayer.IService;
using BusinessLogicLayer.RequestModel.User;
using BusinessLogicLayer.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace HighSchoolQuestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        public IUserService _service { get; set; }
        public UsersController(IUserService userService)
        {
            _service = userService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(UserRegisterRequest user)
        {
            var result = await _service.RegisterAsync(user);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginRequest user)
        {
            var result = await _service.LoginAsync(user);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetUserPagingAsync([FromQuery] int pageIndex = 1,
                                                            [FromQuery] int pageSize = 5,
                                                            [FromQuery] string search = null)
        {
            var result = await _service.GetUserPagingAsync(pageIndex, pageSize, search);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

        [Authorize]
        [HttpGet("total")]
        public async Task<IActionResult> GetTotalUserAsync()
        {
            var result = await _service.GetTotalOfUser();
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }
    }
}
