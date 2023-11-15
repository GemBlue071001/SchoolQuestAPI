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
    }
}
