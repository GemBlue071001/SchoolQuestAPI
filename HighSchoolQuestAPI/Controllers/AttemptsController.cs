﻿using BusinessLogicLayer.IService;
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

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> GetAttemptPagingAsync([FromQuery] int pageIndex = 1,
                                                             [FromQuery] int pageSize = 5,
                                                             [FromQuery] string search = null)
        {
            var result = await _service.GetStudentAttemptPagingAsync(pageIndex, pageSize, search);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

        [Authorize]
        [HttpGet("all")]
        public async Task<IActionResult> GetAllAttemptPagingAsync([FromQuery] int pageIndex = 1,
                                                             [FromQuery] int pageSize = 5,
                                                             [FromQuery] string search = null)
        {
            var result = await _service.GetAllAttemptPagingAsync(pageIndex, pageSize, search);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

        [Authorize]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAttemptDetail(Guid id)
        {
            var result = await _service.GetAttemptDetail(id);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }


        [Authorize]
        [HttpGet("/admin/{studentId}")]
        public async Task<IActionResult> GetStudentAttempt(Guid studentId)
        {
            var result = await _service.GetAttemptForAdmin(studentId);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }
    }
}
