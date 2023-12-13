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
            exam.TotalNumberOfQuestion += 1;
            await _unitOfWork.SaveChangeAsync();


            return response.SetOk();
        }

        public async Task<ApiResponse> RemoveExaminationQuestionAsync(Guid id)
        {
            var apiResponse = new ApiResponse();
            try
            {
                var examQuestion = await _unitOfWork.ExaminationQuestions.GetAsync(x => x.Id == id);

                if (examQuestion == null)
                    return apiResponse.SetBadRequest(Resources.NullObject);

                var exam = await _unitOfWork.Examinations.GetAsync(x => x.Id == examQuestion.ExaminationId);
                exam.TotalNumberOfQuestion -= 1;

                await _unitOfWork.ExaminationQuestions.RemoveByIdAsync(id);
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
