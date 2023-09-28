using ApplicationContext;
using DataAccessLayer.IRepository;
using DataAccessLayer.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private HighSchoolQuestContext _context;
        public IUserRepository Users { get; }
        public ISubjectRepository Subjects { get; }
        public ITopicRepository Topics { get; }
        public IUniversityRepository Universities { get; }
        public IQuestionRepository Questions { get; }
        public IExaminationRepository Examinations { get; }
        public IExaminationQuestionRepository ExaminationQuestions { get; }

        public UnitOfWork(HighSchoolQuestContext context)
        {
            _context = context;
            Users = new UserRepository(context);
            Subjects = new SubjectRepository(context);
            Topics = new TopicRepository(context);
            Universities = new UniversityRepository(context);
            Questions = new QuestionRepository(context);
            Examinations = new ExaminationRepository(context);
            ExaminationQuestions = new ExaminationQuestionRepository(context);
        }
        public async Task SaveChangeAsync()
        {
            await _context.SaveChangesAsync();
        }

    }
}
