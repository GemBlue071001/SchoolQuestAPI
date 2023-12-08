using AutoMapper;
using BusinessLogicLayer.IService;
using BusinessLogicLayer.ResponseModel.ApiResponse;
using BusinessLogicLayer.ResponseModel.MBTI;
using DataAccessLayer.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Service
{
    public class MBTIService : IMBTIService
    {
        public IUnitOfWork _unitOfWork;
        public IMapper _mapper;

        public MBTIService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ApiResponse> GetMBTI(string mbtiCode)
        {
            var response = new ApiResponse();
            var mbti = await _unitOfWork.MBITs.GetAsync(x => x.Code.Equals(mbtiCode));

            return response.SetOk(mbti);
        }
    }
}
