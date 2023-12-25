using Azure.Core;
using BusinessLogicLayer.IService;
using BusinessLogicLayer.RequestModel.MBTI_Question;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HighSchoolQuestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MBTIQuestionController : ControllerBase
    {
        public IMBTI_QuestionService _service;
        public MBTIQuestionController(IMBTI_QuestionService service)
        {
            _service = service;
        }
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> AddNewMBTIQuestion(MBTI_QuestionRequest request)
        {
            var response = await _service.AddNewQuestion(request);
            return response.IsSuccess ? Ok(response) : BadRequest(response);
        }
        [Authorize]
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateMBTIQuestion(int id, MBTI_QuestionRequest request)
        {
            var response = await _service.UpdateQuestion(id, request);
            return response.IsSuccess ? Ok(response) : BadRequest(response);
        }
        [Authorize]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMBTIQuestion(int id)
        {
            var response = await _service.DeleteQuestion(id);
            return response.IsSuccess ? Ok(response) : BadRequest(response);
        }
        [Authorize]
        [HttpPost("list")]
        public async Task<IActionResult> AddNewMBTIQuestion(List<MBTI_QuestionRequest> request)
        {
            var response = await _service.AddNewListQuestion(request);
            return response.IsSuccess ? Ok(response) : BadRequest(response);
        }
        [Authorize]
        [HttpGet]
        public async Task<IActionResult> GetQuestion([FromQuery] int pageIndex = 1,
                                                     [FromQuery] int pageSize = 5)
        {
            var response = await _service.GetQuestion(pageIndex, pageSize);
            return response.IsSuccess ? Ok(response) : BadRequest(response);
        }
    }
}
