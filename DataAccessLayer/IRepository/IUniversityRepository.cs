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
    }
}
