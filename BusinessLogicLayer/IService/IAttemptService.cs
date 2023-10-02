﻿using BusinessLogicLayer.RequestModel.Attemp;
using BusinessLogicLayer.ResponseModel.ApiResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.IService
{
    public interface IAttemptService 
    {
        Task<ApiResponse> AddAttemptAsync(NewAttemptRequest newAttempt);
    }
}
