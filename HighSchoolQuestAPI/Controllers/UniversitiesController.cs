using BusinessLogicLayer.IService;
using BusinessLogicLayer.RequestModel.University;
using Domain.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HighSchoolQuestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UniversitiesController : ControllerBase
    {
        public IUniversityService _service;
        public UniversitiesController(IUniversityService service)
        {
            _service = service;
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> AddNewUniversity(NewUniversityRequest request)
        {
            var result = await _service.AddUniversity(request);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> GetUniversitiesByDepartment()
        {
            var result = await _service.GetUniversities();
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

        //[Authorize]
        [Authorize]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetUniversityDetail(Guid id)
        {
            var result = await _service.GetUniversityDetail(id);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

        //[Authorize]
        [Authorize]
        [HttpGet("paging")]
        public async Task<IActionResult> GetUniversitiesByDepartmentPagination(
                                                 [FromQuery] int pageIndex = 1,
                                                 [FromQuery] int pageSize = 5,
                                                 [FromQuery] string search = null)
        {
            var result = await _service.GetUniversityPagingAsync(pageIndex, pageSize, search);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

        [Authorize]
        [HttpPut("{universityId}")]
        public async Task<IActionResult> UpdateUniversity(
                                            Guid universityId, 
                                            [FromBody] NewUniversityRequest updatedUniversity)
        {
            var result = await _service.UpdateUniversityAsync(universityId, updatedUniversity);
            return result.IsSuccess ? NoContent() : BadRequest(result);
        }

        //[Authorize]
        [Authorize]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUniversityAsync(Guid id)
        {
            var result = await _service.DeleteUniversityAsync(id);
            return result.IsSuccess ? NoContent() : BadRequest(result);
        }
    }
}
