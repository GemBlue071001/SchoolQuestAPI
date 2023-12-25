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
                    .Include(x => x.RecordDetails)
                        .ThenInclude(x => x.MBTI_ExamQuestion)
                            .ThenInclude(x => x.MBTI_Question)
                    .Include(x => x.User)
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

        public async Task<Dictionary<string, int>> GenerateMbtiReport()
        {
            var mbtiReport = new Dictionary<string, int>();

            // Group by MBTI result and count the number of users for each type
            var resultCounts = await _context.MBTI_UserRecords
                .GroupBy(result => result.Result)
                .Select(group => new
                {
                    MbtiType = group.Key,
                    UserCount = group.Count()
                })
                .ToListAsync();


            foreach (var mbtiType in GetAllMbtiTypes())
            {
                mbtiReport[mbtiType] = 0;
            }

            // Populate the report dictionary
            foreach (var resultCount in resultCounts)
            {
                if (resultCount.MbtiType != null)
                {
                    mbtiReport[resultCount.MbtiType] = resultCount.UserCount;
                }
            }

            return mbtiReport;
        }

        private IEnumerable<string> GetAllMbtiTypes()
        {
            // Replace this with your actual list of 16 MBTI types
            return new[]
            {
            "ISTJ", "ISFJ", "INFJ", "INTJ",
            "ISTP", "ISFP", "INFP", "INTP",
            "ESTP", "ESFP", "ENFP", "ENTP",
            "ESTJ", "ESFJ", "ENFJ", "ENTJ"
        };
        }

    }
}
