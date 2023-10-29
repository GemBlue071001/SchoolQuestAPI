using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.IRepository
{
    public interface IAttemptRepository :IGenericRepository<Attempt>
    {
        Task<List<Attempt>> GetAttemptsPagingAsync(int pageIndex, int pageSize, string search, Guid userId);
        Task<int> GetAttemptCountAsync(string search, Guid userId);
    }
}
