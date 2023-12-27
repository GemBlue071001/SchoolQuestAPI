using BusinessLogicLayer.RequestModel.MBTI_Department;
using BusinessLogicLayer.ResponseModel.ApiResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.IService
{
    public interface IMBTIService
    {
        Task<ApiResponse> GetMBTIDetail(int id);
        Task<ApiResponse> GetAllMBTI();
        Task<ApiResponse> AddMBTIDepartment(MBTIDepartmentRequest mbtiDep);
        Task<ApiResponse> GetMBTIDepartment(int index, int pageSize, int mbtiId);
    }
}
