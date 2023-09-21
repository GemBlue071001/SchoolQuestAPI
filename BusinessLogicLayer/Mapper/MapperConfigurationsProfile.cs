using AutoMapper;
using BusinessLogicLayer.RequestModel.Subject;
using BusinessLogicLayer.ResponseModel.Subject;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Mapper
{
    public class MapperConfigurationsProfile  : Profile
    {
        public MapperConfigurationsProfile()
        {
            CreateMap<Subject, NewSubjectRequest>().ReverseMap();
            CreateMap<Subject, SubjectResponse>().ReverseMap();
        }
    }
}
