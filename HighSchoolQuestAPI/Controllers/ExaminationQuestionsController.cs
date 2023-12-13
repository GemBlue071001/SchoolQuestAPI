using BusinessLogicLayer.IService;
using BusinessLogicLayer.RequestModel.Examination;
using BusinessLogicLayer.RequestModel.ExaminationQuestion;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HighSchoolQuestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExaminationQuestionsController : ControllerBase
    {
        public IExaminationQuestionService _service;

        public ExaminationQuestionsController(IExaminationQuestionService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> AddQuestionToExamAsync(NewExaminationQuestionRequest request)
        {
            var result = await _service.AddExaminationQuestionAsync(request);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveQuestionToExamAsync(Guid id)
        {
            var result = await _service.RemoveExaminationQuestionAsync(id);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }
    }
}
