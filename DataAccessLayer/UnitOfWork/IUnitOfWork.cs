﻿using DataAccessLayer.IRepository;
using DataAccessLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.UnitOfWork
{
    public interface IUnitOfWork
    {
        public IUserRepository Users { get; }
        public ISubjectRepository Subjects { get; }
        public ITopicRepository Topics { get; }
        public IUniversityRepository Universities { get; }
        public IQuestionRepository Questions { get; }
        public IExaminationRepository Examinations { get; }
        public IExaminationQuestionRepository ExaminationQuestions { get; }
        public IMajorRepository Major { get; }
        public IUniversityDepartmentRepository UniversityDepartments { get; }
        public IGroupDepartmentRepository GroupDepartments { get; }
        public IGroupRepository Groups { get; }
        public ISubjectGroupRepository SubjectGroups { get; }
        public IAttemptDetailRepository AttemptDetails { get; }
        public IAttemptRepository Attempts { get; }
        public Task SaveChangeAsync();
    }
}
