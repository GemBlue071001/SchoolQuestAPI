using Azure.Core;
using BusinessLogicLayer.IService;
using BusinessLogicLayer.RequestModel.MBTI_Question;
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

        [HttpPost]
        public async Task<IActionResult> AddNewMBTIQuestion(MBTI_QuestionRequest request)
        {
            var response = await _service.AddNewQuestion(request);
            return response.IsSuccess ? Ok(response) : BadRequest(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetQuestion()
        {
            var response = await _service.GetQuestion();
            return response.IsSuccess ? Ok(response) : BadRequest(response);
        }
    }
}
