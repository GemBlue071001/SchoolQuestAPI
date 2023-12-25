using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.IRepository
{
    public interface IMBTI_UserRecordRepository : IGenericRepository<MBTI_UserRecord>
    {
        Task<List<MBTI_UserRecord>> GetUserRecords(Guid userId);
        Task<MBTI_UserRecord?> GetUserRecordDetail(int id);
        Task<Dictionary<string, int>> GenerateMbtiReport();
    }
}
