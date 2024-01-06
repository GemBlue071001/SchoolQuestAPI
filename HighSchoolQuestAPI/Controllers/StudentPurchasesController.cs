﻿using BusinessLogicLayer.IService;
using BusinessLogicLayer.RequestModel.StudentPurchased;
using BusinessLogicLayer.RequestModel.Subject;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HighSchoolQuestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentPurchasesController : ControllerBase
    {
        private IStudentPurchasedService _service;
        public StudentPurchasesController(IStudentPurchasedService service)
        {
            _service = service;
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> AddNewSubjectAsync(StudentPurchasedRequest request)
        {
            var result = await _service.Purchases(request);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> GetSubjectAsync()
        {
            var result = await _service.GetStudentPurches();
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }
    }
}
