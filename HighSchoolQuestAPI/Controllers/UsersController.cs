using BusinessLogicLayer.IService;
using BusinessLogicLayer.RequestModel.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using MailKit.Net.Smtp;
using Azure;


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


        [HttpPost("mail")]
        public async Task<IActionResult> Mail(string user)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("healthsystemcare", "healthsystemcare0@gmail.com"));
            message.To.Add(new MailboxAddress("", "trinhtam2001@gmail.com"));
            message.Subject = "hello !!";
            var bodyBuilder = new BodyBuilder();

            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "EmailTemplate", "index.html");
            if (!System.IO.File.Exists(filePath))
            {
                return BadRequest("file not found");
            }
            string content = System.IO.File.ReadAllText(filePath);

            var name = "tam";

            // Replace ${name} with the actual value
            content = content.Replace("${name}", name);

            bodyBuilder.HtmlBody = content;

            message.Body = bodyBuilder.ToMessageBody();
            using (var client = new SmtpClient())
            {
                await client.ConnectAsync("smtp.gmail.com", 465, true);
                await client.AuthenticateAsync("trinhtam2001@gmail.com", "srtb iprw hiwv htpj");
                await client.SendAsync(message);
                await client.DisconnectAsync(true);
            }

            return Ok();
        }


        [HttpGet]
        public async Task<IActionResult> GetUserPagingAsync([FromQuery] bool isStudent,
                                                            [FromQuery] bool isSorted,
                                                            [FromQuery] int pageIndex = 1,
                                                            [FromQuery] int pageSize = 5,
                                                            [FromQuery] string search = null
                                                            )
        {
            var result = await _service.GetUserPagingAsync(pageIndex, pageSize, search, isStudent, isSorted);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

        [Authorize]
        [HttpGet("total")]
        public async Task<IActionResult> GetTotalUserAsync()
        {
            var result = await _service.GetTotalOfUser();
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

        [Authorize]
        [HttpPut("profile")]
        public async Task<IActionResult> UpdateProfileAsync(UpdateProfileRequest request)
        {
            var result = await _service.UpdateProfileAsync(request);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

    }
}
