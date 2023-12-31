﻿using BusinessLogicLayer.IService;
using BusinessLogicLayer.RequestModel.Momo;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HighSchoolQuestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IMomoService _momoService;

        public PaymentController(IMomoService momoService)
        {
            _momoService = momoService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrder(OrderRequestModel order)
        {
            var result = await _momoService.CreatePayment("abc", order);
            return Ok(result);
        }

        [HttpPost("ReceiveResponse")]
        [AllowAnonymous]
        public async Task<IActionResult> ReceiveResponse(MomoResponseModel moMoResponseModel)
        {
            var result = await _momoService.ReceiveResponse(moMoResponseModel);
            return NoContent();
        }
    }
}
