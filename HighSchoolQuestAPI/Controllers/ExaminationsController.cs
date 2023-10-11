using BusinessLogicLayer.IService;
using BusinessLogicLayer.RequestModel.Examination;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HighSchoolQuestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExaminationsController : ControllerBase
    {
        public IExaminationService _service;
        public ExaminationsController(IExaminationService examinationService)
        {
            _service = examinationService;
        }

        [HttpPost]
        public async Task<IActionResult> AddExaminationAsync (NewExaminationRequest request)
        {
            var result = await _service.AddExaminationAsync(request);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

        [HttpPost("Questions")]
        public async Task<IActionResult> AddExaminationAsync(ExaminationRequest request)
        {
            var result = await _service.AddExaminationAsync(request);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> AddExaminationAsync(Guid id)
        {
            var result = await _service.GetExamDetailAsync(id);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }
    }
}
