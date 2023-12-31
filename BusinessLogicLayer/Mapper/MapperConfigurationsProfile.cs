﻿using AutoMapper;
using BusinessLogicLayer.RequestModel.Attemp;
using BusinessLogicLayer.RequestModel.AttempDetail;
using BusinessLogicLayer.RequestModel.Department;
using BusinessLogicLayer.RequestModel.Examination;
using BusinessLogicLayer.RequestModel.ExaminationQuestion;
using BusinessLogicLayer.RequestModel.Major;
using BusinessLogicLayer.RequestModel.MBTI_Department;
using BusinessLogicLayer.RequestModel.MBTI_Question;
using BusinessLogicLayer.RequestModel.MBTIUserRecord;
using BusinessLogicLayer.RequestModel.Subject;
using BusinessLogicLayer.RequestModel.Topic;
using BusinessLogicLayer.RequestModel.University;
using BusinessLogicLayer.RequestModel.User;
using BusinessLogicLayer.ResponseModel.Attempt;
using BusinessLogicLayer.ResponseModel.Department;
using BusinessLogicLayer.ResponseModel.Examination;
using BusinessLogicLayer.ResponseModel.Major;
using BusinessLogicLayer.ResponseModel.MBTI;
using BusinessLogicLayer.ResponseModel.MBTI_Department;
using BusinessLogicLayer.ResponseModel.MBTI_Question;
using BusinessLogicLayer.ResponseModel.MBTI_UserRecord;
using BusinessLogicLayer.ResponseModel.MBTIExamResponse;
using BusinessLogicLayer.ResponseModel.Question;
using BusinessLogicLayer.ResponseModel.Subject;
using BusinessLogicLayer.ResponseModel.Topic;
using BusinessLogicLayer.ResponseModel.University;
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
            CreateMap<Subject, SubjectResponse>().ForMember(
                                                dest => dest.NumberOfTopic,
                                                opt => opt.MapFrom(src => src.Topics.Count()))
                                                .ReverseMap();
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
            CreateMap<User, UpdateProfileRequest>().ReverseMap();
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
            CreateMap<Attempt, AttemptResponse>().ForMember(
                            dest => dest.DoneBy,
                            opt => opt.MapFrom(src => src.User.UserName + "/" + src.User.FirstName + " " + src.User.LastName)).ReverseMap();
            CreateMap<AttemptDetail, AttemptDetailResponse>().ReverseMap();
            CreateMap<AttemptDetail, AttemptDetailResponse>().ReverseMap();
            #endregion

            #region AttempDetail
            CreateMap<AttemptDetail, AttemptDetailRequest>().ReverseMap();
            #endregion

            #region MBTI
            CreateMap<MBTI, MBTIResponse>().ForMember(
                            dest => dest.NumberOfSuitableDepartment,
                            opt => opt.MapFrom(src => src.MBTI_Departments.Count())).ReverseMap();
            #endregion

            #region University
            CreateMap<University, UniversityResponse>().ReverseMap();
            CreateMap<UniversityDepartment, UniversityDepartmentResponse>().ReverseMap();
            #endregion

            #region MBTI_Question
            CreateMap<MBTI_Question, MBTI_QuestionRequest>().ReverseMap();
            CreateMap<MBTI_Question, MBTI_QuestionResponse>().ReverseMap();
            CreateMap<MBTI_QuestionResponse, MBTI_Question>().ReverseMap();
            #endregion

            #region MBTI_Exam
            CreateMap<MBTI_Exam, MBTIExamResponse>().ReverseMap();
            CreateMap<MBTI_ExamQuestion, MBTI_ExamQuestionResponse>().ReverseMap();
            #endregion

            #region MBTI_UserRecord
            CreateMap<MBTI_UserRecord, MBTIUserRecordRequest>().ReverseMap();
            CreateMap<MBTI_UserRecord, MBTI_UserRecordResponse>().ForMember(
                            dest => dest.DoneBy,
                            opt => opt.MapFrom(src => src.User.UserName + "/" + src.User.FirstName + " " + src.User.LastName)).ReverseMap();
            CreateMap<RecordDetail, RecordDetailRequest>().ReverseMap();
            CreateMap<RecordDetail, RecordDetailResponse>().ReverseMap();
            #endregion

            #region Major
            CreateMap<Major, NewMajorRequest>().ReverseMap();
            CreateMap<Major, MajorResponse>().ReverseMap();
            CreateMap<Major, UpdateMajorRequest>().ReverseMap();
            #endregion

            #region Department
            CreateMap<Department, DepartmentResponse>().ReverseMap();
            CreateMap<Department, NewDepartmentRequest>().ReverseMap();
            CreateMap<UniversityDepartment, UniDepartmentRequest>().ReverseMap();
            #endregion

            #region MBTI_Department
            CreateMap<MBTI_Department, MBTIDepartmentRequest>().ReverseMap();
            CreateMap<MBTI_Department, MBTI_DepartmentResponse>().ReverseMap();
            #endregion
        }
    }
}
