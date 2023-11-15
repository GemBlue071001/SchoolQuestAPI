using ApplicationContext;
using DataAccessLayer.IRepository;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class UniversityDepartmentRepository : GenericRepository<UniversityDepartment>, IUniversityDepartmentRepository
    {
        public UniversityDepartmentRepository(HighSchoolQuestContext context) : base(context)
        {
        }

        public async Task<List<UniversityDepartment>> GetUniversitiesByDepartment(Guid departmentId)
        {
            IQueryable<UniversityDepartment> query = _db;

            query = query.Include(x => x.University);

            return await query
                    .Where(b => !b.IsDeleted && b.DepartmentId == departmentId)
                    //.Skip((pageIndex - 1) * pageSize)
                    //.Take(pageSize)
                    .ToListAsync();

        }
    }
}
