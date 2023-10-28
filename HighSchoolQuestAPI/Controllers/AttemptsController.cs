using BusinessLogicLayer.IService;
using BusinessLogicLayer.RequestModel.Attemp;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HighSchoolQuestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttemptsController : ControllerBase
    {
        private IAttemptService _service;

        public AttemptsController(IAttemptService service)
        {
            _service = service;
        }
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> AddNewAttemptAsync(NewAttemptRequest request)
        {
            var result = await _service.AddAttemptAsync(request);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }
    }
}
