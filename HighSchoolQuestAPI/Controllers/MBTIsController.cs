using Azure.Core;
using BusinessLogicLayer.IService;
using BusinessLogicLayer.ResponseModel.ApiResponse;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace HighSchoolQuestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MBTIsController : ControllerBase
    {
        public IMBTIService _service;
        public MBTIsController(IMBTIService serivce)
        {
            _service = serivce;
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> GetMBTI_DepartmentAsync(string mbti)
        {
            var result = await _service.GetDepartmentByMBTICriteria(mbti);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> AddMBTI_Exam(string mbti)
        {
            return Ok(mbti);
        }
    }
}
