using AutoMapper;
using BusinessLogicLayer.IService;
using BusinessLogicLayer.Properties;
using BusinessLogicLayer.RequestModel.ExaminationQuestion;
using BusinessLogicLayer.ResponseModel.ApiResponse;
using BusinessLogicLayer.ResponseModel.Examination;
using DataAccessLayer.UnitOfWork;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Service
{
    public class ExaminationQuestionService : IExaminationQuestionService
    {
        public IUnitOfWork _unitOfWork;
        public IMapper _mapper;

        public ExaminationQuestionService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ApiResponse> AddExaminationQuestionAsync(NewExaminationQuestionRequest newExamQuestion)
        {
            ApiResponse response = new ApiResponse();
            var examQuestion = _mapper.Map<ExaminationQuestion>(newExamQuestion);

            var question = await _unitOfWork.Questions.GetAsync(x => x.Id == newExamQuestion.QuestionId);
            if (question == null)
            {
                return response.SetBadRequest(message: Resources.QuestionNotFound); ;
            }

            var exam = await _unitOfWork.Examinations.GetAsync(x => x.Id == newExamQuestion.ExaminationId);
            if (exam == null)
            {
                return response.SetBadRequest(message: Resources.ExamNotFound); ;
            }

            await _unitOfWork.ExaminationQuestions.AddAsync(examQuestion);
            await _unitOfWork.SaveChangeAsync();


            return response.SetOk();
        }


        

    }
}
