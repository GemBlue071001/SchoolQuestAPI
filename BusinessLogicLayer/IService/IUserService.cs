﻿using BusinessLogicLayer.RequestModel.User;
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
        Task<ApiResponse> LoginAsync(LoginRequest account);
        Task<ApiResponse> RegisterAsync(UserRegisterRequest user);
        Task<ApiResponse> GetUserPagingAsync(int pageIndex, int pageSize, string search, bool isStudent, bool isSorted);
        Task<ApiResponse> GetTotalOfUser();
        Task<ApiResponse> UpdateProfileAsync(UpdateProfileRequest userProfile);
    }
}
