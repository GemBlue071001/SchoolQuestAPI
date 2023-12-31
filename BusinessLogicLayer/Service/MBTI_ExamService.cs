﻿using AutoMapper;
using BusinessLogicLayer.DTO;
using BusinessLogicLayer.IService;
using BusinessLogicLayer.Properties;
using BusinessLogicLayer.RequestModel.ExaminationQuestion;
using BusinessLogicLayer.RequestModel.MBTI_Exam;
using BusinessLogicLayer.ResponseModel.ApiResponse;
using BusinessLogicLayer.ResponseModel.MBTIExamResponse;
using DataAccessLayer.UnitOfWork;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Service
{
    public class MBTI_ExamService : IMBTI_ExamService
    {
        private IUnitOfWork _uniOfWork;
        private IMapper _mapper;
        private IClaimsService _claimsService;

        public MBTI_ExamService(IUnitOfWork uniOfWork, IMapper mapper, IClaimsService claimsService)
        {
            _uniOfWork = uniOfWork;
            _mapper = mapper;
            _claimsService = claimsService;
        }

        public async Task<ApiResponse> AddNewExam(NewMBTIExam newExam)
        {
            var response = new ApiResponse();

            var examDetails = new List<MBTI_ExamQuestion>();

            foreach (var questionId in newExam.QuestionIds)
            {
                examDetails.Add(new MBTI_ExamQuestion { QuestionId = questionId });
            }

            var exam = new MBTI_Exam
            {
                Note = newExam.Note ?? "",
                CreatedBy = _claimsService.GetUserIdInRequest(),
                NumberOfQuestion = newExam.QuestionIds.Count(),
                MBTI_ExamQuestions = examDetails
            };

            await _uniOfWork.MBTI_Exams.AddAsync(exam);
            await _uniOfWork.SaveChangeAsync();

            return response.SetOk(Resources.CreateSuccess);
        }

        public async Task<List<MBTIExamResponse>> GetExam(int index, int pageSize)
        {
            var response = new ApiResponse();
            var exams = await _uniOfWork.MBTI_Exams.GetExam(index, pageSize);
            var numberOfExam = await _uniOfWork.MBTI_Exams.CountAsync();
            var examList = _mapper.Map<List<MBTIExamResponse>>(exams);

            var examPagingList = new Pagination<MBTIExamResponse>(examList, numberOfExam, index, pageSize);


            return examList;
        }

        public async Task<ApiResponse> GetExamDetail(int id)
        {
            var response = new ApiResponse();
            var exams = await _uniOfWork.MBTI_Exams.GetExamDetail(id);

            if (exams == null)
                return response.SetBadRequest(Resources.NullObject);

            var examResponse = _mapper.Map<MBTIExamResponse>(exams);

            return response.SetOk(examResponse);
        }

        public async Task<ApiResponse> DeleteExam(int id)
        {
            var response = new ApiResponse();

            var exams = await _uniOfWork.MBTI_Exams.GetAsync(x => x.Id == id);
            if (exams == null) return response.SetBadRequest(Resources.NullObject);

            await _uniOfWork.MBTI_Exams.RemoveByIdAsync(id);
            await _uniOfWork.SaveChangeAsync();

            return response.SetOk(Resources.DeleteSuccess);
        }
    }
}
