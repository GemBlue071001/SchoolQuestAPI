using BusinessLogicLayer.IService;
using BusinessLogicLayer.RequestModel.Subject;
using Microsoft.AspNetCore.Authorization;
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

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> AddNewSubjectAsync(NewSubjectRequest request)
        {
            var result = await _service.AddSubjectAsync(request);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

        //[Authorize]
        [HttpGet]
        public async Task<IActionResult> GetSubjectAsync([FromQuery]int pageIndex = 1,
                                                         [FromQuery] int pageSize = 5,
                                                         [FromQuery] string search = null)
        {
            var result = await _service.GetSubjectPagingAsync(pageIndex, pageSize, search);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

        //[Authorize]
        [HttpPut]
        public async Task<IActionResult> UpdateSubjectAsync([FromQuery] Guid subjectId, NewSubjectRequest request)
        {
            var result = await _service.UpdateSubjectAsync(subjectId, request);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }
    }
}
