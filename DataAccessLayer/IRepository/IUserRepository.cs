using Domain.Models;

namespace DataAccessLayer.IRepository
{
    public interface IUserRepository : IGenericRepository<User>
    {
        Task<List<User>> PagingAsync(int pageIndex, int pageSize, string search, bool isStudent, bool isSorted);
        Task<int> CountPagingAsync(int pageIndex, int pageSize, string search, bool isStudent);
    }
}
