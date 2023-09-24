using Azure.Core;
using BusinessLogicLayer.IService;
using BusinessLogicLayer.RequestModel.Question;
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
    }
}
