using Domain.Models;

namespace DataAccessLayer.IRepository
{
    public interface IUserRepository : IGenericRepository<User>
    {
        Task<List<User>> PagingAsync(int pageIndex, int pageSize, string search);
        Task<int> CountPagingAsync(int pageIndex, int pageSize, string search);
    }
}
