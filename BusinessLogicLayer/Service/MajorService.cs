using AutoMapper;
using BusinessLogicLayer.DTO;
using BusinessLogicLayer.IService;
using BusinessLogicLayer.Properties;
using BusinessLogicLayer.RequestModel.Major;
using BusinessLogicLayer.ResponseModel.ApiResponse;
using BusinessLogicLayer.ResponseModel.Major;
using DataAccessLayer.UnitOfWork;
using Domain.Models;

namespace BusinessLogicLayer.Service
{
    public class MajorService : IMajorService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public MajorService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<ApiResponse> AddMajorAsync(NewMajorRequest newMajor)
        {
            var response = new ApiResponse();
            var major = _mapper.Map<Major>(newMajor);

            var groupDepartment = await _unitOfWork.GroupDepartments.GetAsync(x => x.DepartmentId == newMajor.DepartmentId);
            
            if(groupDepartment is null){
                response.SetBadRequest(message: Resources.DepartmentNotFound);
                return response;
            }

            major.Department = groupDepartment.Department;
            major.Department.IsDeleted = false;

            await _unitOfWork.Major.AddAsync(major);
            await _unitOfWork.SaveChangeAsync();

            response.SetOk();
            return response;
        }

        public async Task<ApiResponse> GetMajorDetailAsync(Guid majorId)
        {
            var response = new ApiResponse();

            var major = await _unitOfWork.Major.GetMajorDetailAsync(majorId);
            if(major is null){
                return response.SetNotFound(Resources.NullObject);
            }

            var majorResponse = _mapper.Map<MajorResponse>(major);

            return response.SetOk(majorResponse);
        }

        public async Task<ApiResponse> GetMajorPagingAsync(int pageIndex, int pageSize, string search)
        {
            var response = new ApiResponse();
            var listOfMajor = await _unitOfWork.Major.PagingAsync(pageIndex, pageSize, search);
            var listOfMajorResponse = _mapper.Map<List<MajorResponse>>(listOfMajor);
            var totalOfMajor = await _unitOfWork.Major.CountPagingAsync(pageIndex,pageSize, search);
            Pagination<MajorResponse> pagination = new Pagination<MajorResponse>(listOfMajorResponse,totalOfMajor,pageIndex,pageSize);

            response.SetOk(pagination);
            return response;
        }

        public async Task<ApiResponse> UpdateMajorAsync(Guid majorId, NewMajorRequest newMajor)
        {
            var response = new ApiResponse();

            var major = await _unitOfWork.Major.GetAsync(entry => entry.Id == majorId);
            if(major is null){
                return response.SetNotFound(Resources.NullObject);
            }

            _mapper.Map(newMajor, major);
            await _unitOfWork.SaveChangeAsync();

            return response.SetOk(Resources.UpdateSuccess);
        }
    }
}