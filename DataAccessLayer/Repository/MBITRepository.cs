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
    public class MBITRepository : GenericRepository<MBTI>, IMBITRepository
    {
        public MBITRepository(HighSchoolQuestContext context) : base(context)
        {
        }

        public async Task<MBTI?> GetMBTIDetail(int id)
        {
            IQueryable<MBTI> query = _db;
            return await query
                   .Where(x => x.Id == id)
                   .Include(x => x.MBTI_Departments).ThenInclude(x => x.Department)
                   .FirstOrDefaultAsync();
        }

        public async Task<MBTI?> GetMBTIDetailByCode(string code)
        {
            IQueryable<MBTI> query = _db;
            return await query
                   .Where(x => x.Code.Equals(code) || x.Name.Equals(code))
                   .Include(x => x.MBTI_Departments).ThenInclude(x => x.Department)
                   .FirstOrDefaultAsync();
        }
    }
}
