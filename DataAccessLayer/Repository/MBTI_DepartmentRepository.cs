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

        public async Task<List<MBTI_Department>> GetPosibilityDepartmentAsync(float score, int MBTI_Id)
        {
            //IQueryable<MBTI_Department> query = _db;
            //if (score != 0)
            //    query = query.Where(b => b.Department.RequiredScore <= score);

            //return await query
            //            .Where(b => b.MBTI_Id == MBTI_Id)
            //            .ToListAsync();
            return new List<MBTI_Department>();

        }
    }
}
