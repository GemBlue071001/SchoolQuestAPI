using AutoMapper;
using BusinessLogicLayer.IService;
using BusinessLogicLayer.RequestModel.Attemp;
using BusinessLogicLayer.RequestModel.AttempDetail;
using BusinessLogicLayer.ResponseModel.ApiResponse;
using DataAccessLayer.UnitOfWork;
using Domain.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Service
{
    public class AttemptService : IAttemptService
    {
        public IMapper _mapper;
        public IUnitOfWork _unitOfWork;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public AttemptService(IUnitOfWork unitOfWork, IMapper mapper, IHttpContextAccessor httpContextAccessor)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
        }

        public Guid GetUserIdInRequest()
        {
            var _tokenUserId = _httpContextAccessor.HttpContext.User.FindFirst("UserId");
            if (_tokenUserId == null) throw new ArgumentNullException("User can not be found! ");
            var _userId = Guid.Parse(_tokenUserId?.Value.ToString()!);
            return _userId;
        }


        public async Task<ApiResponse> AddAttemptAsync(NewAttemptRequest newAttempt)
        {
            var _tokenUserId = GetUserIdInRequest();

            var response = new ApiResponse();
            var attempt = _mapper.Map<Attempt>(newAttempt);

            attempt.UserId = _tokenUserId;

            foreach (var userChoice in newAttempt.AttemptDetails)
            {
                userChoice.IsCorrect = true;
                attempt.Score += 1;
            }

            await _unitOfWork.Attempts.AddAsync(attempt);
            await _unitOfWork.SaveChangeAsync();

            return response.SetOk();
        }
    }
}
