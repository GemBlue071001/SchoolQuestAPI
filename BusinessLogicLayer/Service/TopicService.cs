using AutoMapper;
using BusinessLogicLayer.IService;
using BusinessLogicLayer.Properties;
using BusinessLogicLayer.RequestModel.Topic;
using BusinessLogicLayer.ResponseModel.ApiResponse;
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
                response.SetBadRequest(message:Resources.SubjectNotFound);
                return response;
            }

            topic.Subject = subject;
            topic.Subject.IsDeleted = false;

            await _unitOfWork.Topics.AddAsync(topic);
            await _unitOfWork.SaveChangeAsync();

            response.SetOk();
            return response;
        }
    }
}
