using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.IRepository
{
    public interface IDepartmentRepository : IGenericRepository<Department>
    {
        Task<List<Department>> PagingAsync(int pageIndex, int pageSize, string search);
        Task<int> CountPagingAsync(string search);
        Task<Department?> GetDepartmentDetailAsync(Guid id);
    }
}
