using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.IRepository
{
    public interface IMajorRepository : IGenericRepository<Major>
    {
        Task<int> CountPagingAsync(int pageIndex, int pageSize, string search);
        Task<List<Major>> PagingAsync(int pageIndex, int pageSize, string search);
        Task<Major?> GetMajorDetailAsync(Guid id);
    }
}
