using BusinessLogicLayer.RequestModel.Department;
using BusinessLogicLayer.ResponseModel.ApiResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.IService
{
    public interface IDepartmentService
    {
        Task<ApiResponse> AddNewDepartment(NewDepartmentRequest newDepartment);
        Task<ApiResponse> GetDepartmentPagingAsync(int pageIndex, int pageSize, string search);
        Task<ApiResponse> UpdateDepartmentAsync(Guid DepartmentId, NewDepartmentRequest newDepartment);
        Task<ApiResponse> DeleteDepartmentAsync(Guid DepartmentId);
        Task<ApiResponse> GetDepartmentDetailAsync(Guid DepartmentId);
        Task<ApiResponse> AddUniversityDepartment(UniDepartmentRequest newUniDepartment);
    }
}
