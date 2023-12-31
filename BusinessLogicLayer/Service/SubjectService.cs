﻿using AutoMapper;
using Azure;
using BusinessLogicLayer.DTO;
using BusinessLogicLayer.IService;
using BusinessLogicLayer.Properties;
using BusinessLogicLayer.RequestModel.Subject;
using BusinessLogicLayer.ResponseModel.ApiResponse;
using BusinessLogicLayer.ResponseModel.Question;
using BusinessLogicLayer.ResponseModel.Subject;
using DataAccessLayer.UnitOfWork;
using Domain.Models;
namespace BusinessLogicLayer.Service
{
    public class SubjectService : ISubjectService
    {
        public IUnitOfWork _unitOfWork;
        private IMapper _mapper;

        public SubjectService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ApiResponse> AddSubjectAsync(NewSubjectRequest newSubjet)
        {
            ApiResponse apiResponse = new ApiResponse();
            Subject subject = _mapper.Map<Subject>(newSubjet);

            await _unitOfWork.Subjects.AddAsync(subject);
            await _unitOfWork.SaveChangeAsync();
            apiResponse.SetOk();

            return apiResponse;
        }

        public async Task<ApiResponse> GetSubjectPagingAsync(int pageIndex, int pageSize, string search)
        {
            ApiResponse apiResponse = new ApiResponse();
            var listOfSubject = await _unitOfWork.Subjects.PagingAsync(pageIndex, pageSize, search);
            var listOfSubjectResponse = _mapper.Map<List<SubjectResponse>>(listOfSubject);
            var totalOfSubject = await _unitOfWork.Subjects.CountPagingAsync(pageIndex, pageSize, search);
            Pagination<SubjectResponse> response = new Pagination<SubjectResponse>(listOfSubjectResponse, totalOfSubject, pageIndex, pageSize);

            return apiResponse.SetOk(response);
        }

        public async Task<ApiResponse> UpdateSubjectAsync(Guid subjectId, NewSubjectRequest newSubject)
        {
            ApiResponse apiResponse = new ApiResponse();

            var subject = await _unitOfWork.Subjects.GetAsync(x => x.Id == subjectId);
            if (subject == null)
            {
                return apiResponse.SetNotFound(Resources.NullObject);
            }

            _mapper.Map(newSubject, subject);
            await _unitOfWork.SaveChangeAsync();

            return apiResponse.SetOk(Resources.UpdateSuccess);
        }

        public async Task<ApiResponse> GetSubjectDetailAsync(Guid subjectId)
        {
            ApiResponse apiResponse = new ApiResponse();

            var subject = await _unitOfWork.Subjects.GetSubjectDetailAsync(subjectId);
            if (subject == null)
            {
                return apiResponse.SetNotFound(Resources.NullObject);
            }

            var subjectResponse = _mapper.Map<SubjectResponse>(subject);

            return apiResponse.SetOk(subjectResponse);
        }

        public async Task<ApiResponse> GetTotalOfSubject()
        {
            var apiResponse = new ApiResponse();
            var totalSubject = await _unitOfWork.Subjects.CountAsync();

            return apiResponse.SetOk(totalSubject);
        }

        public async Task<ApiResponse> DeleteSubject(Guid id)
        {
            var apiResponse = new ApiResponse();
            try
            {
                await _unitOfWork.Subjects.RemoveByIdAsync(id);
                await _unitOfWork.SaveChangeAsync();
                return apiResponse.SetOk(Resources.DeleteSuccess);

            }
            catch (Exception)
            {
                return apiResponse.SetBadRequest(Resources.NullObject);
            }

        }
    }
}
