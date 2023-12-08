using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLayer.RequestModel.Major;
using BusinessLogicLayer.ResponseModel.ApiResponse;

namespace BusinessLogicLayer.IService
{
    public interface IMajorService
    {
        Task<ApiResponse> AddMajorAsync(NewMajorRequest newMajor);
        Task<ApiResponse> GetMajorPagingAsync(int pageIndex, int pageSize, string search);
        Task<ApiResponse> UpdateMajorAsync(Guid majorId, UpdateMajorRequest newMajor);
        Task<ApiResponse> GetMajorDetailAsync(Guid majorId);
        Task<ApiResponse> DeleteMajorAsync(Guid majorId);
    }
}
