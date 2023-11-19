using BusinessLogicLayer.IService;
using BusinessLogicLayer.RequestModel.MBTIUserRecord;
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

        [HttpPost]
        public async Task<IActionResult> AddNewUserRecord(MBTIUserRecordRequest request)
        {
            var result = await _service.AddUserRecord(request);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }
    }
}
