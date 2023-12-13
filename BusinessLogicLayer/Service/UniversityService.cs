using AutoMapper;
using BusinessLogicLayer.DTO;
using BusinessLogicLayer.IService;
using BusinessLogicLayer.Properties;
using BusinessLogicLayer.RequestModel.University;
using BusinessLogicLayer.ResponseModel.ApiResponse;
using BusinessLogicLayer.ResponseModel.University;

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

        public async Task<ApiResponse> GetUniversities()
        {
            var response = new ApiResponse();

            var universities = await _unitOfWork.Universities.GetUniversities();

            var universityList = _mapper.Map<List<UniversityResponse>>(universities);
            return response.SetOk(universityList);
        }

        public async Task<ApiResponse> GetUniversityDetail(Guid id)
        {
            var response = new ApiResponse();

            var university = await _unitOfWork.Universities.GetUniversityDetail(id);

            var universityResponse = _mapper.Map<UniversityResponse>(university);
            return response.SetOk(universityResponse);
        }

        public async Task<ApiResponse> GetUniversityPagingAsync(int pageIndex, int pageSize, string search)
        {
            ApiResponse apiResponse = new ApiResponse();
            var listOfUniversity = await _unitOfWork.Universities.PagingAsync(pageIndex, pageSize, search);
            var listOfUniversityResponse = _mapper.Map<List<UniversityResponse>>(listOfUniversity);
            var totalOfUniversity = await _unitOfWork.Universities.CountPagingAsync(pageIndex, pageSize, search);
            Pagination<UniversityResponse> response = new Pagination<UniversityResponse>(listOfUniversityResponse, totalOfUniversity, pageIndex, pageSize);

            return apiResponse.SetOk(response);
        }

        public async Task<ApiResponse> UpdateUniversityAsync(Guid universityId, NewUniversityRequest updatedUniversity)
        {
            ApiResponse apiResponse = new ApiResponse();

            var university = await _unitOfWork.Universities.GetAsync(x => x.Id == universityId);
            if (university == null)
            {
                return apiResponse.SetNotFound(Resources.NullObject);
            }

            _mapper.Map(updatedUniversity, university);
            await _unitOfWork.SaveChangeAsync();

            return apiResponse.SetOk(Resources.UpdateSuccess);
        }

        public async Task<ApiResponse> DeleteUniversityAsync(Guid universityId)
        {
            ApiResponse apiResponse = new();

            var university = await _unitOfWork.Universities.GetAsync(x => x.Id == universityId);
            if (university == null)
            {
                return apiResponse.SetNotFound(Resources.NullObject);
            }

            await _unitOfWork.Universities.RemoveByIdAsync(universityId);

            return apiResponse.SetOk(Resources.DeleteSuccess);
        }
    }
}
