using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.IRepository
{
    public interface ISubjectRepository : IGenericRepository<Subject> 
    {
        Task<List<Subject>> PagingAsync(int pageIndex, int pageSize, string search);
        Task<int> CountPagingAsync(int pageIndex, int pageSize, string search);
        Task<Subject?> GetSubjectDetailAsync(Guid id);
    }
}
