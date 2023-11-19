using BusinessLogicLayer.RequestModel.University;
using BusinessLogicLayer.ResponseModel.ApiResponse;

namespace BusinessLogicLayer.IService
{
    public interface IUniversityService
    {
        Task<ApiResponse> AddUniversity(NewUniversityRequest newUniversity);
        Task<ApiResponse> GetUniversities();
    }
}
