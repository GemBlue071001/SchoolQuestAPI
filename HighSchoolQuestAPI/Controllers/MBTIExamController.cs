using BusinessLogicLayer.IService;
using BusinessLogicLayer.RequestModel.MBTI_Exam;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HighSchoolQuestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MBTIExamController : ControllerBase
    {
        private IMBTI_ExamService _service;

        public MBTIExamController(IMBTI_ExamService service)
        {
            _service = service;
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> AddNewExam(NewMBTIExam request)
        {
            var response = await _service.AddNewExam(request);
            return response.IsSuccess ? Ok(response) : BadRequest(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetExam(int index = 1, int pageSize = 5)
        {
            var response = await _service.GetExam(index, pageSize);
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetExamDetail(int id)
        {
            var response = await _service.GetExamDetail(id);
            return response.IsSuccess ? Ok(response) : BadRequest(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteExam(int id)
        {
            var response = await _service.DeleteExam(id);
            return response.IsSuccess ? Ok(response) : BadRequest(response);
        }
    }
}
