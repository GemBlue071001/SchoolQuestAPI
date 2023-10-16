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
    public class MBITRepository : GenericRepository<MBTI>, IMBITRepository
    {
        public MBITRepository(HighSchoolQuestContext context) : base(context)
        {
        }
    }
}
