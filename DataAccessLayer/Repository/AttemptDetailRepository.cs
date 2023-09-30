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
    public class AttemptDetailRepository : GenericRepository<AttemptDetail>, IAttemptDetailRepository
    {
        public AttemptDetailRepository(HighSchoolQuestContext context) : base(context)
        {
        }
    }
}
