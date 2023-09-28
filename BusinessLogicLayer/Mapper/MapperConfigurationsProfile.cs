using AutoMapper;
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            CreateMap<Topic, TopicResponse>().ReverseMap();
            #endregion

            #region University
            CreateMap<University, NewUniversityRequest>().ReverseMap();
            #endregion

            #region User
            CreateMap<User, UserResponse>().ReverseMap();
            #endregion

            CreateMap<Question, QuestionResponse>().ReverseMap();

            CreateMap<Examination, NewExaminationRequest>().ReverseMap();

            CreateMap<ExaminationQuestion, NewExaminationQuestionRequest>().ReverseMap();

            CreateMap<ExaminationQuestion, ExamQuestionResponse>().ReverseMap();
            CreateMap<Examination, ExamDetailResponse>().ReverseMap();

        }
    }
}
