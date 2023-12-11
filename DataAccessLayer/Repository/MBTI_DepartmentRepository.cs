using ApplicationContext;
using DataAccessLayer.IRepository;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace DataAccessLayer.Repository
{
    public class MBTI_DepartmentRepository : GenericRepository<MBTI_Department>, IMBTI_DepartmentRepository
    {
        public MBTI_DepartmentRepository(HighSchoolQuestContext context) : base(context)
        {
        }

        public async Task<List<MBTI_Department>> GetMBTIDepartment(int pageIndex, int pageSize, int mbtiId)
        {
            IQueryable<MBTI_Department> query = _db;

            return await query
                        .Where(b => b.MBTI_Id == mbtiId)
                        .Skip((pageIndex - 1) * pageSize)
                        .Take(pageSize)
                        .Include(x => x.Department)
                        .ToListAsync();

        }
    }
}
