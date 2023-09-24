using AutoMapper;
using BusinessLogicLayer.RequestModel.Subject;
using BusinessLogicLayer.RequestModel.Topic;
using BusinessLogicLayer.RequestModel.University;
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
            CreateMap<Subject, NewSubjectRequest>().ReverseMap();
            CreateMap<Subject, SubjectResponse>().ReverseMap();

            CreateMap<Topic, NewTopicRequest>().ReverseMap();
            CreateMap<Topic, TopicResponse>().ReverseMap();

            CreateMap<University, NewUniversityRequest>().ReverseMap();

            CreateMap<User, UserResponse>().ReverseMap();

        }
    }
}
