using BusinessLogicLayer.IService;
using BusinessLogicLayer.RequestModel.Attemp;
using BusinessLogicLayer.RequestModel.AttempDetail;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HighSchoolQuestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttemptDetailsController : ControllerBase
    {
        private IAttemptDetailService _service;

        public AttemptDetailsController(IAttemptDetailService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> AddNewAttemptAsync(AttemptDetailRequest request)
        {
            var result = await _service.AddAttemptDetailAsync(request);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }
    }
}
