using AutoMapper;
using BusinessLogicLayer.DTO;
using BusinessLogicLayer.IService;
using BusinessLogicLayer.Properties;
using BusinessLogicLayer.RequestModel.Topic;
using BusinessLogicLayer.ResponseModel.ApiResponse;
using BusinessLogicLayer.ResponseModel.Subject;
using BusinessLogicLayer.ResponseModel.Topic;
using DataAccessLayer.UnitOfWork;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Service
{
    public class TopicService : ITopicService
    {
        public IUnitOfWork _unitOfWork;
        public IMapper _mapper;
        public TopicService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ApiResponse> AddTopicAsync(NewTopicRequest newTopic)
        {
            var response = new ApiResponse();
            var topic = _mapper.Map<Topic>(newTopic);

            var subject = await _unitOfWork.Subjects.GetAsync(x => x.Id == newTopic.SubjectId);

            if (subject == null)
            {
                response.SetBadRequest(message: Resources.SubjectNotFound);
                return response;
            }

            topic.Subject = subject;
            topic.Subject.IsDeleted = false;

            await _unitOfWork.Topics.AddAsync(topic);
            await _unitOfWork.SaveChangeAsync();

            response.SetOk();
            return response;
        }

        public async Task<ApiResponse> GetTopicPagingAsync(int pageIndex, int pageSize, string search)
        {
            ApiResponse apiResponse = new ApiResponse();
            var listOfTopic = await _unitOfWork.Topics.PagingAsync(pageIndex, pageSize, search);
            var listOfTopicResponse = _mapper.Map<List<TopicResponse>>(listOfTopic);
            var totalOfTopic = await _unitOfWork.Topics.CountPagingAsync(pageIndex, pageSize, search);
            Pagination<TopicResponse> response = new Pagination<TopicResponse>(listOfTopicResponse, totalOfTopic, pageIndex, pageSize);

            apiResponse.SetOk(response);
            return apiResponse;
        }

        public async Task<ApiResponse> UpdateTopicAsync(Guid topicId, NewTopicRequest newTopic)
        {
            ApiResponse apiResponse = new ApiResponse();

            var topic = await _unitOfWork.Topics.GetAsync(x => x.Id == topicId);
            if (topic == null)
            {
                return apiResponse.SetNotFound(Resources.NullObject);
            }

            _mapper.Map(newTopic, topic);
            await _unitOfWork.SaveChangeAsync();

            return apiResponse.SetOk(Resources.UpdateSuccess);
        }

        public async Task<ApiResponse> GetTopicDetailAsync(Guid topicId)
        {
            ApiResponse apiResponse = new ApiResponse();

            var topic = await _unitOfWork.Topics.GetAsync(x => x.Id == topicId);
            if (topic == null)
            {
                return apiResponse.SetNotFound(Resources.NullObject);
            }

            var topicResponse = _mapper.Map<TopicResponse>(topic);

            return apiResponse.SetOk(topicResponse);
        }
    }
}
