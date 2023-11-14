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
    public class MBTI_ExamDetailRepository : GenericRepository<MBTI_ExamDetail>, IMBTI_ExamDetailRepository
    {
        public MBTI_ExamDetailRepository(HighSchoolQuestContext context) : base(context)
        {
        }
    }
}
