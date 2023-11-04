using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.IRepository
{
    public interface IUniversityDepartmentRepository : IGenericRepository<UniversityDepartment>
    {
        Task<List<UniversityDepartment>> GetUniversitíeByDepartment(Guid departmentId);
    }
}
