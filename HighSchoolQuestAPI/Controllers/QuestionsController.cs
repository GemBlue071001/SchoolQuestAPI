using Azure.Core;
using BusinessLogicLayer.IService;
using BusinessLogicLayer.RequestModel.Question;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HighSchoolQuestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionsController : ControllerBase
    {
        public IQuestionService _service;
        public QuestionsController(IQuestionService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetQuestionPagingAsync([FromQuery] int pageIndex = 1,
                                                          [FromQuery] int pageSize = 5,
                                                          [FromQuery] string search = null)
        {
            var result = await _service.GetQuestionPagingAsync(pageIndex, pageSize, search);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

        [HttpPost]
        public async Task<IActionResult> AddQuestionAsync(NewQuestionRequest request)
        {
            var result = await _service.AddQuestionAsync(request);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }


        [HttpPost("Topic")]
        public async Task<IActionResult> AddQuestionTopicAsync(QuestionTopicRequest request)
        {
            var result = await _service.AddListOfQuestionsWithTopicAsync(request);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

        [HttpPost("list")]
        public async Task<IActionResult> AddListQuestionAsync(List<NewQuestionContentRequest> request)
        {
            var result = await _service.AddListOfQuestionsAsync(request);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }


        [HttpPut("{questionId}")]
        public async Task<IActionResult> UpdateQuestionAsync(Guid questionId , NewQuestionContentRequest request)
        {
            var result = await _service.UpdateQuestionAsync(questionId, request);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetQuestionDetailAsync(Guid id)
        {
            var result = await _service.GetQuestionDetailAsync(id);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

        [Authorize]
        [HttpGet("total")]
        public async Task<IActionResult> GetTotalQuestionAsync()
        {
            var result = await _service.GetTotalOfQuestion();
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

        //[Authorize]
        [HttpGet("ids")]
        public async Task<IActionResult> GetQuestionIdsAsync()
        {
            var result = await _service.GetQuestionsId();
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }
    }
}
