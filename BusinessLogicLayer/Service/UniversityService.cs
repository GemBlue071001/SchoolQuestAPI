﻿using AutoMapper;
using BusinessLogicLayer.IService;
using BusinessLogicLayer.RequestModel.University;
using BusinessLogicLayer.ResponseModel.ApiResponse;
using BusinessLogicLayer.ResponseModel.UniversityDepartment;
using DataAccessLayer.UnitOfWork;
using Domain.Models;

namespace BusinessLogicLayer.Service
{
    public class UniversityService : IUniversityService
    {
        public IUnitOfWork _unitOfWork;
        public IMapper _mapper;

        public UniversityService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ApiResponse> AddUniversity(NewUniversityRequest newUniversity)
        {
            ApiResponse response = new ApiResponse();
            var university = _mapper.Map<University>(newUniversity);

            await _unitOfWork.Universities.AddAsync(university);
            await _unitOfWork.SaveChangeAsync();

            response.SetOk();
            return response;
        }

        public async Task<ApiResponse> GetUniversitíeByDepartment(Guid departmentId)
        {
            var response = new ApiResponse();

            var universities = await _unitOfWork.UniversityDepartments.GetUniversitíeByDepartment(departmentId);

            var universityList = _mapper.Map<List<UniversityDepartmentResponse>>(universities);
            return response.SetOk(universityList);
        }

    }
}
