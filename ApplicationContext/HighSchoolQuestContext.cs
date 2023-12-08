using ApplicationContext.Configurations;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationContext
{
    public class HighSchoolQuestContext : DbContext
    {
        public HighSchoolQuestContext(DbContextOptions options) : base(options)
        {
        }

        //Table
        public DbSet<Group> Groups { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<SubjectGroup> SubjectGroup { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Examination> Examinations { get; set; }
        public DbSet<ExaminationQuestion> ExaminationQuestions { get; set; }
        public DbSet<Attempt> Attempts { get; set; }
        public DbSet<AttemptDetail> AttemptDetails { get; set; }
        public DbSet<UniversityDepartment> UniversityDepartments { get; set; }
        public DbSet<GroupDepartment> GroupDepartments { get; set; }
        public DbSet<MBTI_Question> MBTI_Questions { get; set; }
        public DbSet<MBTI_Exam> MBTI_Exams { get; set; }
        public DbSet<MBTI_ExamQuestion> MBTI_ExamQuestions { get; set; }
        public DbSet<MBTI_UserRecord> MBTI_UserRecords { get; set; }
        public DbSet<RecordDetail> RecordDetails { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
            //modelBuilder.ApplyConfiguration(new BaseConfiguration());
            modelBuilder.ApplyConfiguration(new DepartmentConfiguration());
            modelBuilder.ApplyConfiguration(new SubjectConfiguration());
            modelBuilder.ApplyConfiguration(new SubjectGroupConfiguration());
            modelBuilder.ApplyConfiguration(new TopicConfiguration());
            modelBuilder.ApplyConfiguration(new ExaminationQuestionConfiguration());
            modelBuilder.ApplyConfiguration(new AttemptDetailConfiguration());
            modelBuilder.ApplyConfiguration(new GroupDepartmentConfiguration());
            modelBuilder.ApplyConfiguration(new MajorConfiguration());
            modelBuilder.ApplyConfiguration(new MBTIConfiguration());
            modelBuilder.ApplyConfiguration(new MBTI_DepartmentConfiguration());
            modelBuilder.ApplyConfiguration(new UniversityConfiguration());
            modelBuilder.ApplyConfiguration(new UniversityDepartmentConfiguration());
            modelBuilder.ApplyConfiguration(new QuestionConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new ExamConfiguration());
            modelBuilder.ApplyConfiguration(new AttemptConfiguration());
            modelBuilder.ApplyConfiguration(new MBTI_ExamQuestionConfiguration());
            modelBuilder.ApplyConfiguration(new MBTI_UserRecordConfiguration());
            modelBuilder.ApplyConfiguration(new MBTI_QuestionConfiguration());
            modelBuilder.ApplyConfiguration(new MBTI_ExamConfiguration());
            modelBuilder.ApplyConfiguration(new RecordDetailConfiguration());
            modelBuilder.ApplyConfiguration(new GroupConfiguration());


        }

    }
}
