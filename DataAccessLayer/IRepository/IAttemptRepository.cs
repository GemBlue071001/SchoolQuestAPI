using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.IRepository
{
    public interface IAttemptRepository : IGenericRepository<Attempt>
    {
        Task<List<Attempt>> GetStudentAttemptsPagingAsync(int pageIndex, int pageSize, string search, Guid userId);
        Task<int> GetStudentAttemptCountAsync(string search, Guid userId);
        Task<List<Attempt>> GetAllAttemptsPagingAsync(int pageIndex, int pageSize, string search);
        Task<int> GetAllAttemptCountAsync(string search);
        Task<int?> GetHighestScore(Guid userId);
        Task<Attempt?> GetDetail(Guid id);
    }
}
