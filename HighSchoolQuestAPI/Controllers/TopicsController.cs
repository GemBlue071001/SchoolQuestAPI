using BusinessLogicLayer.IService;
using BusinessLogicLayer.RequestModel.Topic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace HighSchoolQuestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TopicsController : ControllerBase
    {
        public ITopicService _service;
        public TopicsController(ITopicService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> AddTopicAsync(NewTopicRequest request)
        {
            var result = await _service.AddTopicAsync(request);
            return result.IsSuccess? Ok(result) : BadRequest(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetTopicPagingAsync([FromQuery] int pageIndex = 1,
                                                             [FromQuery] int pageSize = 5,
                                                             [FromQuery] string search = null)
        {
            var result = await _service.GetTopicPagingAsync(pageIndex, pageSize, search);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }
    }
}
