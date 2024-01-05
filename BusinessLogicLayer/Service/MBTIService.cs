using AutoMapper;
using BusinessLogicLayer.DTO;
using BusinessLogicLayer.IService;
using BusinessLogicLayer.Properties;
using BusinessLogicLayer.RequestModel.MBTI_Department;
using BusinessLogicLayer.ResponseModel.ApiResponse;
using BusinessLogicLayer.ResponseModel.MBTI;
using BusinessLogicLayer.ResponseModel.MBTI_Department;
using BusinessLogicLayer.ResponseModel.Topic;
using DataAccessLayer.UnitOfWork;
using Domain.Models;
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

        public async Task<ApiResponse> GetMBTIDetail(int id)
        {
            var response = new ApiResponse();
            var mbti = await _unitOfWork.MBITs.GetMBTIDetail(id);
            var mbtiResponse = _mapper.Map<MBTIResponse>(mbti);

            return response.SetOk(mbtiResponse);
        }

        public async Task<ApiResponse> GetMBTIDetailByCode(string code)
        {
            var response = new ApiResponse();
            var mbti = await _unitOfWork.MBITs.GetMBTIDetailByCode(code);
            var mbtiResponse = _mapper.Map<MBTIResponse>(mbti);

            return response.SetOk(mbtiResponse);
        }

        public async Task<ApiResponse> GetAllMBTI()
        {
            var response = new ApiResponse();
            var mbti = await _unitOfWork.MBITs.GetAllAsync(null);

            return response.SetOk(mbti);
        }

        public async Task<ApiResponse> AddMBTIDepartment(MBTIDepartmentRequest mbtiDep)
        {
            var response = new ApiResponse();
            await _unitOfWork.MBTI_Departments.AddAsync(_mapper.Map<MBTI_Department>(mbtiDep));
            await _unitOfWork.SaveChangeAsync();

            return response.SetOk(Resources.CreateSuccess);
        }

        public async Task<ApiResponse> GetMBTIDepartment(int index, int pageSize, int mbtiId)
        {
            var response = new ApiResponse();
            var departmentList = await _unitOfWork.MBTI_Departments.GetMBTIDepartment(index, pageSize, mbtiId);

            //map 
            var responseList = _mapper.Map<List<MBTI_DepartmentResponse>>(departmentList);
            var total = await _unitOfWork.MBTI_Departments.CountAsync();

            //paging
            var paging = new Pagination<MBTI_DepartmentResponse>(responseList, total, index, pageSize);

            return response.SetOk(paging);
        }
    }
}
