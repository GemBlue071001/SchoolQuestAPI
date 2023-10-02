using AutoMapper;
using BusinessLogicLayer.IService;
using DataAccessLayer.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Service
{
    public class AttemptService : IAttemptService
    {
        public IMapper _mapper;
        public IUnitOfWork _unitOfWork;

        public AttemptService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        //public 
    }
}
