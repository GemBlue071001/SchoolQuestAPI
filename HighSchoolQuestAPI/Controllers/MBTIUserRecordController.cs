using BusinessLogicLayer.IService;
using BusinessLogicLayer.RequestModel.MBTIUserRecord;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HighSchoolQuestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MBTIUserRecordController : ControllerBase
    {
        private IMBTI_UserRecordService _service;

        public MBTIUserRecordController(IMBTI_UserRecordService service)
        {
            _service = service;
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> AddNewUserRecord(MBTIUserRecordRequest request)
        {
            var result = await _service.AddUserRecord(request);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
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


    }
}
