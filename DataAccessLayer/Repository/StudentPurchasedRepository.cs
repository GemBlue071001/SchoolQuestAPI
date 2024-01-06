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
    public class StudentPurchasedRepository : GenericRepository<StudentPurchased>, IStudentPurchasedRepository
    {
        public StudentPurchasedRepository(HighSchoolQuestContext context) : base(context)
        {
        }


        public async Task<List<Examination>> GetStudentPurches(Guid userId)
        {
            IQueryable<StudentPurchased> query = _db;

            return await query
                            .Where(sp => sp.UserId == userId)
                            .Select(sp => sp.Examination)
                            .ToListAsync();
        }
    }
}
