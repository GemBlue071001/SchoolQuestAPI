using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.IRepository
{
    public interface ITopicRepository : IGenericRepository<Topic>
    {
        Task<int> CountPagingAsync(int pageIndex, int pageSize, string search);
        Task<List<Topic>> PagingAsync(int pageIndex, int pageSize, string search);
        Task<List<Topic>> GetTopicBySubjectAsync(Guid subjectId);
        Task<Topic?> GetTopicDetailAsync(Guid id);
    }
}
