using AutoMapper;
using BusinessLogicLayer.IService;
using BusinessLogicLayer.RequestModel.University;
using BusinessLogicLayer.ResponseModel.ApiResponse;
using DataAccessLayer.UnitOfWork;
using Domain.Models;

namespace BusinessLogicLayer.Service
{
    public class UniversityService : IUniversityService
    {
        public IUnitOfWork _unitOfWork;
        public IMapper _mapper;

        public UniversityService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ApiResponse> AddUniversity(NewUniversityRequest newUniversity)
        {
            ApiResponse response = new ApiResponse();
            var university = _mapper.Map<University>(newUniversity);

            await _unitOfWork.Universities.AddAsync(university);
            await _unitOfWork.SaveChangeAsync();

            response.SetOk();
            return response;
        }

    }
}
