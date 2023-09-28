using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.IRepository
{
    public interface IExaminationRepository : IGenericRepository<Examination>
    {
        Task<Examination?> GetExamDetailAsync(Guid id);
        Task<List<Examination>> PagingAsync(int pageIndex, int pageSize, string search);
        Task<int> CountPagingAsync(string search);
    }
}
