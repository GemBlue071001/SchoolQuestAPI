using Azure.Core;
using BusinessLogicLayer.IService;
using BusinessLogicLayer.RequestModel.MBTI_Department;
using BusinessLogicLayer.RequestModel.MBTI_Question;
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

        //[Authorize]
        [HttpGet]
        public async Task<IActionResult> GetMBTI(string mbti)
        {
            var result = await _service.GetMBTI(mbti);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

        //[Authorize]
        [HttpGet("all")]
        public async Task<IActionResult> GetAllMBTI()
        {
            var result = await _service.GetAllMBTI();
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

        //[Authorize]
        [HttpPost("department")]
        public async Task<IActionResult> AddMBTIDepartment(MBTIDepartmentRequest request)
        {
            var result = await _service.AddMBTIDepartment(request);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

        [HttpGet("department/{mbtiId}")]
        public async Task<IActionResult> GetMBTIDepartment(
                                                           int mbtiId,
                                                           [FromQuery] int pageIndex = 1,
                                                           [FromQuery] int pageSize = 5
                                                           )
        {
            var result = await _service.GetMBTIDepartment(pageIndex, pageSize, mbtiId);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }
    }



}
