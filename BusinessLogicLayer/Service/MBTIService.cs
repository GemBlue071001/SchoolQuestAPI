using AutoMapper;
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
    public class MBTIService
    {
        public IUnitOfWork _unitOfWork;
        public IMapper _mapper;

        public MBTIService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ApiResponse> GetDepartmentByMBTICriteria(string mbti)
        {
            var response = new ApiResponse();
            var departments = await _unitOfWork.MBITs.GetDepartmentByMBTI(mbti);
            var listOfDepartment = _mapper.Map<List<MBTIResponse>>(departments);
            return response.SetOk(listOfDepartment);
        }
    }
}
