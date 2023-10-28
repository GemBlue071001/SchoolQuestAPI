using AutoMapper;
using BusinessLogicLayer.DTO;
using BusinessLogicLayer.IService;
using BusinessLogicLayer.Properties;
using BusinessLogicLayer.RequestModel.Examination;
using BusinessLogicLayer.ResponseModel.ApiResponse;
using BusinessLogicLayer.ResponseModel.Examination;
using BusinessLogicLayer.ResponseModel.Subject;
using DataAccessLayer.UnitOfWork;
using Domain.Models;
using System.Text.Json;

namespace BusinessLogicLayer.Service
{
    public class ExaminationService : IExaminationService
    {
        public IUnitOfWork _unitOfWork;
        public IMapper _mapper;
        public ExaminationService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ApiResponse> AddExaminationAsync(NewExaminationRequest newExamination)
        {
            var examination = _mapper.Map<Examination>(newExamination);

            if (newExamination.newListOfQuestion != null)
            {
                var listExamQuestion = new List<ExaminationQuestion>();
                foreach (var newQuestion in newExamination.newListOfQuestion)
                {
                    var examQuestion = new ExaminationQuestion();
                    examQuestion.Question = new Question();
                    examQuestion.Question.Content = JsonSerializer.Serialize(newQuestion);
                    listExamQuestion.Add(examQuestion);
                }
                examination.ExaminationQuestions = listExamQuestion;
                examination.TotalNumberOfQuestion = newExamination.newListOfQuestion.Count();
            }

            await _unitOfWork.Examinations.AddAsync(examination);
            await _unitOfWork.SaveChangeAsync();

            var response = new ApiResponse();
            response.SetOk();

            return response;
        }

        public async Task<ApiResponse> RandomExaminationAsync(RandomExamRequest request)
        {
            var response = new ApiResponse();

            var listOfTopic = await _unitOfWork.Topics.GetTopicBySubjectAsync(request.SubjectId);

            if (listOfTopic != null)
            {
                var listOfQuestion = new List<Question>();
                foreach (var topic in listOfTopic)
                {
                    listOfQuestion.AddRange(topic.Questions);
                }

                listOfQuestion = listOfQuestion.OrderBy(r => Guid.NewGuid()).Take(40).ToList();

                var examination = new Examination();

                var listExamQuestion = new List<ExaminationQuestion>();
                foreach (var question in listOfQuestion)
                {
                    listExamQuestion.Add(new ExaminationQuestion()
                    {
                        QuestionId = question.Id,
                    });
                }

                examination.ExaminationQuestions = listExamQuestion;
                examination.TotalNumberOfQuestion = listOfQuestion.Count();
                examination.Description= request.Description;
                examination.Name= request.Name;

                await _unitOfWork.Examinations.AddAsync(examination);
                await _unitOfWork.SaveChangeAsync();
                return response.SetOk();
            }

            return response.SetBadRequest("missing data");
        }

        public async Task<ApiResponse> AddExaminationAsync(ExaminationRequest newExamination)
        {
            var response = new ApiResponse();
            if (newExamination.Questions != null)
            {
                var examination = _mapper.Map<Examination>(newExamination);

                if (newExamination.Questions != null)
                {
                    var listExamQuestion = new List<ExaminationQuestion>();
                    foreach (var newQuestionId in newExamination.Questions)
                    {
                        listExamQuestion.Add(new ExaminationQuestion()
                        {
                            QuestionId = newQuestionId,
                        });
                    }
                    examination.ExaminationQuestions = listExamQuestion;
                    examination.TotalNumberOfQuestion = newExamination.Questions.Count();
                }

                await _unitOfWork.Examinations.AddAsync(examination);
                await _unitOfWork.SaveChangeAsync();

                return response.SetOk(); ;
            }

            return response.SetBadRequest();
        }

        public async Task<ApiResponse> GetExamPagingAsync(int pageIndex, int pageSize, string search)
        {
            ApiResponse apiResponse = new ApiResponse();
            var listOfExam = await _unitOfWork.Examinations.PagingAsync(pageIndex, pageSize, search);
            var listOfExamResponse = _mapper.Map<List<ExamDetailResponse>>(listOfExam);
            var totalOfExam = await _unitOfWork.Examinations.CountPagingAsync(search);
            Pagination<ExamDetailResponse> response = new Pagination<ExamDetailResponse>(listOfExamResponse, totalOfExam, pageIndex, pageSize);

            return apiResponse.SetOk(response);
        }

        public async Task<ApiResponse> GetExamDetailAsync(Guid id)
        {
            ApiResponse response = new ApiResponse();
            var exam = await _unitOfWork.Examinations.GetExamDetailAsync(id);
            if (exam == null)
            {
                return response.SetBadRequest(message: Resources.ExamNotFound); ;
            }

            var examResponse = _mapper.Map<ExamDetailResponse>(exam);

            return response.SetOk(examResponse);
        }
    }
}
