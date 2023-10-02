using AutoMapper;
using BusinessLogicLayer.IService;
using BusinessLogicLayer.RequestModel.AttempDetail;
using BusinessLogicLayer.ResponseModel.ApiResponse;
using DataAccessLayer.UnitOfWork;
using Domain.Models;

namespace BusinessLogicLayer.Service
{
    public class AttemptDetailService : IAttemptDetailService
    {
        public IMapper _mapper;
        public IUnitOfWork _unitOfWork;

        public AttemptDetailService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<ApiResponse> AddAttemptDetailAsync(AttemptDetailRequest userAttempt)
        {
            var response = new ApiResponse();
            var attemptDetail = _mapper.Map<AttemptDetail>(userAttempt);

            await _unitOfWork.AttemptDetails.AddAsync(attemptDetail);
            await _unitOfWork.SaveChangeAsync();

            return response.SetOk();
        }  
    }
}
