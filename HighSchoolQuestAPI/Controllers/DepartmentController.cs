﻿using BusinessLogicLayer.IService;
using BusinessLogicLayer.RequestModel.Department;
using BusinessLogicLayer.RequestModel.Subject;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HighSchoolQuestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        public IDepartmentService _service;

        public DepartmentController(IDepartmentService service)
        {
            _service = service;
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> AddNewSubjectAsync(NewDepartmentRequest request)
        {
            var result = await _service.AddNewDepartment(request);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

        [Authorize]
        [HttpPost("University")]
        public async Task<IActionResult> AddUniDepartmentAsync(UniDepartmentRequest request)
        {
            var result = await _service.AddUniversityDepartment(request);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> GetDepartmentAsync([FromQuery] int pageIndex = 1,
                                                         [FromQuery] int pageSize = 5,
                                                         [FromQuery] string search = null)
        {
            var result = await _service.GetDepartmentPagingAsync(pageIndex, pageSize, search);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

        [Authorize]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetDeparmentDetailAsync(Guid id)
        {
            var result = await _service.GetDepartmentDetailAsync(id);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

        [Authorize]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDeparmentAsync(Guid id)
        {
            var result = await _service.DeleteDepartmentAsync(id);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }


        [Authorize]
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateDeparmentAsync(Guid id, NewDepartmentRequest request)
        {
            var result = await _service.UpdateDepartmentAsync(id, request);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }
    }
}
