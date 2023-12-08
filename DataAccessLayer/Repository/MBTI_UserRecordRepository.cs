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
    public class MBTI_UserRecordRepository : GenericRepository<MBTI_UserRecord>, IMBTI_UserRecordRepository
    {
        public MBTI_UserRecordRepository(HighSchoolQuestContext context) : base(context)
        {
        }

        public async Task<List<MBTI_UserRecord>> GetUserRecords(Guid userId)
        {
            IQueryable<MBTI_UserRecord> query = _db;

            query = query.Where(b => b.UserId == userId);

            return await query
                    .Include(x=>x.RecordDetails)
                        .ThenInclude(x=>x.MBTI_ExamQuestion)
                            .ThenInclude(x=>x.MBTI_Question)
                    .ToListAsync();
        }
        public async Task<MBTI_UserRecord?> GetUserRecordDetail(int id)
        {
            IQueryable<MBTI_UserRecord> query = _db;

            query = query.Where(b => b.Id == id);

            return await query
                    .Include(x => x.RecordDetails)
                        .ThenInclude(x => x.MBTI_ExamQuestion)
                            .ThenInclude(x => x.MBTI_Question)
                    .SingleOrDefaultAsync();
        }
    }
}
