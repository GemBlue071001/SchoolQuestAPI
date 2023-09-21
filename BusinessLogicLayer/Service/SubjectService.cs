using AutoMapper;
using BusinessLogicLayer.DTO;
using BusinessLogicLayer.IService;
using BusinessLogicLayer.RequestModel.Subject;
using BusinessLogicLayer.ResponseModel.ApiResponse;
using BusinessLogicLayer.ResponseModel.Subject;
using DataAccessLayer.UnitOfWork;
using Domain.Models;
namespace BusinessLogicLayer.Service
{
    public class SubjectService : ISubjectService
    {
        public IUnitOfWork _unitOfWork;
        private IMapper _mapper;

        public SubjectService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ApiResponse> AddSubjectAsync(NewSubjectRequest newSubjet)
        {
            ApiResponse apiResponse = new ApiResponse();
            Subject subject = _mapper.Map<Subject>(newSubjet);

            await _unitOfWork.Subjects.AddAsync(subject);
            await _unitOfWork.SaveChangeAsync();
            apiResponse.SetOk();
            
            return apiResponse;
        }

        public async Task<ApiResponse> GetSubjectAsync(int pageIndex,int pageSize,string search)
        {
            ApiResponse apiResponse = new ApiResponse();
            var listOfSubject = await _unitOfWork.Subjects.PagingAsync(pageIndex, pageSize, search);
            var totalOfSubject = await _unitOfWork.Subjects.CountPagingAsync(pageIndex, pageSize, search);
            Pagination<Subject> response = new Pagination<Subject> (listOfSubject, totalOfSubject, pageIndex, pageSize);

            apiResponse.SetOk(response);
            return apiResponse;
        }

    }
}
