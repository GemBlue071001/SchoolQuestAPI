using AutoMapper;
using BusinessLogicLayer.DTO;
using BusinessLogicLayer.IService;
using BusinessLogicLayer.Properties;
using BusinessLogicLayer.RequestModel.Department;
using BusinessLogicLayer.RequestModel.Subject;
using BusinessLogicLayer.ResponseModel.ApiResponse;
using BusinessLogicLayer.ResponseModel.Department;
using BusinessLogicLayer.ResponseModel.Subject;
using DataAccessLayer.UnitOfWork;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Service
{
    public class DepartmentService : IDepartmentService
    {
        public IUnitOfWork _unitOfWork;
        private IMapper _mapper;

        public DepartmentService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ApiResponse> AddNewDepartment(NewDepartmentRequest newDepartment)
        {
            ApiResponse apiResponse = new ApiResponse();
            var department = _mapper.Map<Department>(newDepartment);

            await _unitOfWork.Departments.AddAsync(department);
            await _unitOfWork.SaveChangeAsync();
            apiResponse.SetOk();

            return apiResponse;
        }

        public async Task<ApiResponse> GetDepartmentPagingAsync(int pageIndex, int pageSize, string search)
        {
            ApiResponse apiResponse = new ApiResponse();
            var listOfDepartment = await _unitOfWork.Departments.PagingAsync(pageIndex, pageSize, search);
            var listOfDepartmentResponse = _mapper.Map<List<DepartmentResponse>>(listOfDepartment);
            var totalOfSubject = await _unitOfWork.Departments.CountPagingAsync(search);
            Pagination<DepartmentResponse> response = new Pagination<DepartmentResponse>(listOfDepartmentResponse, totalOfSubject, pageIndex, pageSize);

            return apiResponse.SetOk(response);
        }

        public async Task<ApiResponse> UpdateDepartmentAsync(Guid DepartmentId, NewDepartmentRequest newDepartment)
        {
            ApiResponse apiResponse = new ApiResponse();

            var department = await _unitOfWork.Departments.GetAsync(x => x.Id == DepartmentId);
            if (department == null)
            {
                return apiResponse.SetNotFound(Resources.NullObject);
            }

            _mapper.Map(newDepartment, department);
            await _unitOfWork.SaveChangeAsync();

            return apiResponse.SetOk(Resources.UpdateSuccess);
        }

        public async Task<ApiResponse> DeleteDepartmentAsync(Guid DepartmentId)
        {
            ApiResponse apiResponse = new ApiResponse();

            var department = await _unitOfWork.Departments.GetAsync(x => x.Id == DepartmentId);
            if (department == null)
            {
                return apiResponse.SetNotFound(Resources.NullObject);
            }

            await _unitOfWork.Departments.RemoveByIdAsync(DepartmentId);
            await _unitOfWork.SaveChangeAsync();

            return apiResponse.SetOk(Resources.DeleteSuccess);
        }

        public async Task<ApiResponse> GetDepartmentDetailAsync(Guid DepartmentId)
        {
            ApiResponse apiResponse = new ApiResponse();

            var department = await _unitOfWork.Departments.GetDepartmentDetailAsync(DepartmentId);
            if (department == null)
            {
                return apiResponse.SetNotFound(Resources.NullObject);
            }

            var departmentResponse = _mapper.Map<DepartmentResponse>(department);

            return apiResponse.SetOk(departmentResponse);
        }

    }
}
