using BusinessLogicLayer.IService;
using BusinessLogicLayer.RequestModel.Examination;
using DataAccessLayer.UnitOfWork;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HighSchoolQuestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExaminationsController : ControllerBase
    {
        public IExaminationService _service;
        public IUnitOfWork _unitOfWork;
        public ExaminationsController(IExaminationService examinationService)
        {
            _service = examinationService;
        }

        [HttpPost]
        public async Task<IActionResult> AddExaminationAsync(NewExaminationRequest request)
        {
            var result = await _service.AddExaminationAsync(request);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

        [HttpPost("random")]
        public async Task<IActionResult> RandomExaminationAsync(Guid subjectId)
        {
            var result = await _service.RandomExaminationAsync(subjectId);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

        [HttpPost("Questions")]
        public async Task<IActionResult> AddExaminationAsync(ExaminationRequest request)
        {
            var result = await _service.AddExaminationAsync(request);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetExaminationDetailAsync(Guid id)
        {
            var result = await _service.GetExamDetailAsync(id);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetExaminationAsync([FromQuery] int pageIndex = 1,
                                                         [FromQuery] int pageSize = 5,
                                                         [FromQuery] string search = null)
        {
            var result = await _service.GetExamPagingAsync(pageIndex, pageSize, search);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }
    }
}
