using ApplicationContext;
using DataAccessLayer.IRepository;
using Domain.Models;
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
    }
}
