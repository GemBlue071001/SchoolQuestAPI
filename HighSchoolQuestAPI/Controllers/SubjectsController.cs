using BusinessLogicLayer.IService;
using BusinessLogicLayer.RequestModel.Subject;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HighSchoolQuestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectsController : ControllerBase
    {
        ISubjectService _service;
        public SubjectsController(ISubjectService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> AddNewSubjectAsync(NewSubjectRequest request)
        {
            var result = await _service.AddSubjectAsync(request);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetSubjectAsync([FromQuery]int pageIndex = 1,
                                                         [FromQuery] int pageSize = 5,
                                                         [FromQuery] string search = null)
        {
            var result = await _service.GetSubjectAsync(pageIndex, pageSize, search);
            return Ok(result);
        }
    }
}
