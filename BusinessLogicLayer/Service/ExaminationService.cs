using AutoMapper;
using BusinessLogicLayer.IService;
using BusinessLogicLayer.Properties;
using BusinessLogicLayer.RequestModel.Examination;
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
            await _unitOfWork.Examinations.AddAsync(examination);
            await _unitOfWork.SaveChangeAsync();

            var response = new ApiResponse();
            response.SetOk();

            return response;
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
