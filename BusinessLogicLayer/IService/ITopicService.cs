using BusinessLogicLayer.RequestModel.Topic;
using BusinessLogicLayer.ResponseModel.ApiResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.IService
{
    public interface ITopicService
    {
        Task<ApiResponse> AddTopicAsync(NewTopicRequest newTopic);
        Task<ApiResponse> GetTopicPagingAsync(int pageIndex, int pageSize, string search);
    }
}
