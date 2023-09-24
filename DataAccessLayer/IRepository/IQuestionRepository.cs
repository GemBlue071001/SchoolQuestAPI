using Domain.Models;

namespace DataAccessLayer.IRepository
{
    public interface IQuestionRepository : IGenericRepository<Question>
    {
        Task<int> CountPagingAsync(int pageIndex, int pageSize, string search);
        Task<List<Question>> PagingAsync(int pageIndex, int pageSize, string search);
    }
}
