using BusinessLogicLayer.IService;
using BusinessLogicLayer.RequestModel.MBTIUserRecord;
using Microsoft.AspNetCore.Authorization;
using MimeKit;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using Domain.Models;

namespace HighSchoolQuestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MBTIUserRecordController : ControllerBase
    {
        private IMBTI_UserRecordService _service;
        public IClaimsService _claimsService;
        public IUserService _userService;

        public MBTIUserRecordController(IMBTI_UserRecordService service, IClaimsService claimsService, IUserService userService)
        {
            _service = service;
            _claimsService = claimsService;
            _userService = userService;
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> AddNewUserRecord(MBTIUserRecordRequest request)
        {
            var result = await _service.AddUserRecord(request);
            if (result.IsSuccess)
            {
                #region get user info
                var userId = _claimsService.GetUserIdInRequest();
                var user = await _userService.GetUserProfile(userId);
                var name = user.FirstName + user.LastName;
                var userEmail = user.Email;
                #endregion





                #region setup content mail
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("healthsystemcare", "healthsystemcare0@gmail.com"));
                message.To.Add(new MailboxAddress("", userEmail));
                message.Subject = "hello !!";
                var bodyBuilder = new BodyBuilder();

                var filename = $"{((result.Result) as MBTI)!.Code}.html";

                string filePath = Path.Combine(Directory.GetCurrentDirectory(), "EmailTemplate", filename);
                if (!System.IO.File.Exists(filePath))
                {
                    return BadRequest("file not found");
                }
                //string content = System.IO.File.ReadAllText(filePath);
                string content = EmailConstant.INTJ;

                #endregion






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
                return Ok(result);
            }
            return BadRequest(result);
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> GetUserRecord()
        {
            var result = await _service.GetUserRecord();
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

        [Authorize]
        [HttpGet("admin/{studentId}")]
        public async Task<IActionResult> GetUserRecordForAdmin(Guid studentId)
        {
            var result = await _service.GetUserRecordForAdmin(studentId);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

        [Authorize]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserRecordDetail(int id)
        {
            var result = await _service.GetUserRecordDetail(id);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

        //[Authorize]
        [HttpGet("report")]
        public async Task<IActionResult> GetMbtiReport()
        {
            var result = await _service.GenerateMbtiReport();
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }
    }
}
