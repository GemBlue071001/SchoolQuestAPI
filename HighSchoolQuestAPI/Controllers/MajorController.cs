using BusinessLogicLayer.IService;
using BusinessLogicLayer.RequestModel.Major;
using Domain.Enums;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HighSchoolQuestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MajorController : ControllerBase
    {
        private readonly IMajorService _service;

        public MajorController(IMajorService service)
        {
            _service = service;
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> GetMajorPaging([FromQuery] int pageSize = MagicNumber.PageSize,
                                                    [FromQuery] int pageIndex = MagicNumber.PageIndex,
                                                   [FromQuery] string search = null)
        {
            var result = await _service.GetMajorPagingAsync(pageIndex, pageSize, search);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

        [Authorize]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMajorDetailAsync(Guid id)
        {
            var result = await _service.GetMajorDetailAsync(id);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }


        [Authorize]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMajorAsync(Guid id)
        {
            var result = await _service.DeleteMajorAsync(id);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> AddMajorAsync(NewMajorRequest request)
        {
            var result = await _service.AddMajorAsync(request);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }
        [Authorize]
        [HttpPut]
        public async Task<IActionResult> UpdateMajorAsync([FromQuery] Guid majorId, UpdateMajorRequest request)
        {
            var result = await _service.UpdateMajorAsync(majorId, request);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }
    }
}