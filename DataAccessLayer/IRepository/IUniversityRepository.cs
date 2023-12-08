using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.IRepository
{
    public interface IUniversityRepository : IGenericRepository<University>
    {
        Task<List<University>> GetUniversities(
            //int pageIndex, 
            //int pageSize, 
            //string department, string name
            );
        Task<List<University>> PagingAsync(int pageIndex, int pageSize, string search);
        Task<int> CountPagingAsync(int pageIndex, int pageSize, string search);

    }
}
