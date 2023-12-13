using BusinessLogicLayer.RequestModel.University;
using BusinessLogicLayer.ResponseModel.ApiResponse;

namespace BusinessLogicLayer.IService
{
    public interface IUniversityService
    {
        Task<ApiResponse> AddUniversity(NewUniversityRequest newUniversity);
        Task<ApiResponse> GetUniversities();
        Task<ApiResponse> GetUniversityPagingAsync(int pageIndex, int pageSize, string search);
        Task<ApiResponse> UpdateUniversityAsync(Guid universityId, NewUniversityRequest updatedUniversity);
        Task<ApiResponse> DeleteUniversityAsync(Guid universityId);
        Task<ApiResponse> GetUniversityDetail(Guid id);
    }
}
