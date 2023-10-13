using AutoMapper;
using BusinessLogicLayer.RequestModel.Attemp;
using BusinessLogicLayer.RequestModel.AttempDetail;
using BusinessLogicLayer.RequestModel.Examination;
using BusinessLogicLayer.RequestModel.ExaminationQuestion;
using BusinessLogicLayer.RequestModel.Subject;
using BusinessLogicLayer.RequestModel.Topic;
using BusinessLogicLayer.RequestModel.University;
using BusinessLogicLayer.ResponseModel.Examination;
using BusinessLogicLayer.ResponseModel.Question;
using BusinessLogicLayer.ResponseModel.Subject;
using BusinessLogicLayer.ResponseModel.Topic;
using BusinessLogicLayer.ResponseModel.User;
using Domain.Models;

namespace BusinessLogicLayer.Mapper
{
    public class MapperConfigurationsProfile : Profile
    {
        public MapperConfigurationsProfile()
        {
            #region Subject
            CreateMap<Subject, NewSubjectRequest>().ReverseMap();
            CreateMap<Subject, SubjectResponse>().ReverseMap();
            #endregion

            #region Topic
            CreateMap<Topic, NewTopicRequest>().ReverseMap();
            CreateMap<Topic, TopicResponse>().ForMember(
                            dest => dest.NumberOfQuestion,
                            opt => opt.MapFrom(src => src.Questions.Count()))
                        .ReverseMap();
            #endregion

            #region University
            CreateMap<University, NewUniversityRequest>().ReverseMap();
            #endregion

            #region User
            CreateMap<User, UserResponse>().ReverseMap();
            #endregion

            #region Question
            CreateMap<Question, QuestionResponse>().ReverseMap();
            #endregion

            #region Examination
            CreateMap<Examination, NewExaminationRequest>().ReverseMap();
            CreateMap<Examination, ExaminationRequest>().ReverseMap();
            CreateMap<Examination, ExamDetailResponse>().ReverseMap();
            CreateMap<Examination, ExamResponse>().ReverseMap();
            #endregion

            #region ExaminationQuestion
            CreateMap<ExaminationQuestion, NewExaminationQuestionRequest>().ReverseMap();
            CreateMap<ExaminationQuestion, ExamQuestionResponse>().ReverseMap();
            #endregion

            #region Attemp
            CreateMap<Attempt, NewAttemptRequest>().ReverseMap();
            #endregion

            #region AttempDetail
            CreateMap<AttemptDetail, AttemptDetailRequest>().ReverseMap();
            #endregion

        }
    }
}
