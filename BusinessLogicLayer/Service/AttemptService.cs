using AutoMapper;
using BusinessLogicLayer.IService;
using BusinessLogicLayer.RequestModel.Attemp;
using BusinessLogicLayer.RequestModel.AttempDetail;
using BusinessLogicLayer.ResponseModel.ApiResponse;
using DataAccessLayer.UnitOfWork;
using Domain.Models;
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

        public AttemptService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ApiResponse> AddAttemptAsync(NewAttemptRequest newAttempt)
        {
            var response = new ApiResponse();
            var attemp = _mapper.Map<Attempt>(newAttempt);

            foreach (var userChoice in newAttempt.AttemptDetails)
            {
                userChoice.IsCorrect = true;
                attemp.Score += 1;
            }

            await _unitOfWork.Attempts.AddAsync(attemp);
            await _unitOfWork.SaveChangeAsync();

            return response.SetOk();
        }
    }
}
