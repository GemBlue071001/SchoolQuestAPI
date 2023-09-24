using BusinessLogicLayer.RequestModel.User;
using BusinessLogicLayer.ResponseModel.ApiResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.IService
{
    public interface IUserService
    {
        public Task<ApiResponse> LoginAsync(LoginRequest account);
        Task<ApiResponse> RegisterAsync(UserRegisterRequest user);
        Task<ApiResponse> GetUserPagingAsync(int pageIndex, int pageSize, string search);
    }
}
