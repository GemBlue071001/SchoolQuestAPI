﻿// <auto-generated />
using System;
using ApplicationContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ApplicationContext.Migrations
{
    [DbContext(typeof(HighSchoolQuestContext))]
    [Migration("20231028084502_userUpdate")]
    partial class userUpdate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain.Models.Attempt", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AttempType")
                        .HasColumnType("int");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ExamDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<Guid?>("ModifiedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Result")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Score")
                        .HasColumnType("int");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Attempts");
                });

            modelBuilder.Entity("Domain.Models.AttemptDetail", b =>
                {
                    b.Property<Guid>("AttemptId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ExaminationQuestionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsCorrect")
                        .HasColumnType("bit");

                    b.Property<string>("UserAnswered")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AttemptId", "ExaminationQuestionId");

                    b.HasIndex("ExaminationQuestionId");

                    b.ToTable("AttemptDetails");
                });

            modelBuilder.Entity("Domain.Models.Department", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<Guid?>("ModifiedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float?>("RequiredScore")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("Department");

                    b.HasData(
                        new
                        {
                            Id = new Guid("de305d54-75b4-431b-adb2-eb6b9e546013"),
                            Code = "SE",
                            Description = "lam ve may tinh",
                            IsDeleted = false,
                            Name = "Cong Nghe Thong Tin",
                            RequiredScore = 22f
                        },
                        new
                        {
                            Id = new Guid("b8034210-23fd-4af9-9d7f-f260a0cdef97"),
                            Code = "KT",
                            Description = "các ngành về kinh tế",
                            IsDeleted = false,
                            Name = "Kinh tế",
                            RequiredScore = 22f
                        },
                        new
                        {
                            Id = new Guid("4c7c3b5f-2a54-42ee-8a7f-0961273cd329"),
                            Code = "YH",
                            Description = "Các ngành y dược",
                            IsDeleted = false,
                            Name = "Y học",
                            RequiredScore = 27f
                        },
                        new
                        {
                            Id = new Guid("e35d862c-1f43-456b-a60b-1b2c7e44ab78"),
                            Code = "SP",
                            Description = "Các ngành sư phạm",
                            IsDeleted = false,
                            Name = "Sư phạm",
                            RequiredScore = 25f
                        },
                        new
                        {
                            Id = new Guid("bb3a10db-c4d4-4b45-9d15-0c38f41e8f5f"),
                            Code = "TK",
                            Description = "Các ngành thiết kế/nghệ thuật",
                            IsDeleted = false,
                            Name = "Thiết kế",
                            RequiredScore = 22f
                        });
                });

            modelBuilder.Entity("Domain.Models.Examination", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<Guid?>("ModifiedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TotalNumberOfQuestion")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Examinations");
                });

            modelBuilder.Entity("Domain.Models.ExaminationQuestion", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ExaminationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<Guid?>("ModifiedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("QuestionId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ExaminationId");

                    b.HasIndex("QuestionId");

                    b.ToTable("ExaminationQuestions");
                });

            modelBuilder.Entity("Domain.Models.Group", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<Guid?>("ModifiedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("Domain.Models.GroupDepartment", b =>
                {
                    b.Property<Guid>("DepartmentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("GroupId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("DepartmentId", "GroupId");

                    b.HasIndex("GroupId");

                    b.ToTable("GroupDepartments");
                });

            modelBuilder.Entity("Domain.Models.MBTI", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MBTI");
                });

            modelBuilder.Entity("Domain.Models.MBTI_Department", b =>
                {
                    b.Property<int>("MBTI_Id")
                        .HasColumnType("int");

                    b.Property<Guid>("DepartmentId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("MBTI_Id", "DepartmentId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("MBTI_Department");

                    b.HasData(
                        new
                        {
                            MBTI_Id = 2,
                            DepartmentId = new Guid("de305d54-75b4-431b-adb2-eb6b9e546013")
                        },
                        new
                        {
                            MBTI_Id = 2,
                            DepartmentId = new Guid("bb3a10db-c4d4-4b45-9d15-0c38f41e8f5f")
                        },
                        new
                        {
                            MBTI_Id = 9,
                            DepartmentId = new Guid("4c7c3b5f-2a54-42ee-8a7f-0961273cd329")
                        });
                });

            modelBuilder.Entity("Domain.Models.Major", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("DepartmentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("MajorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ModifiedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Major");
                });

            modelBuilder.Entity("Domain.Models.Question", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<Guid?>("ModifiedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("TopicId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("TopicId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("Domain.Models.Subject", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<Guid?>("ModifiedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("Domain.Models.SubjectGroup", b =>
                {
                    b.Property<Guid>("SubjectId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("GroupId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("SubjectId", "GroupId");

                    b.HasIndex("GroupId");

                    b.ToTable("SubjectGroup");
                });

            modelBuilder.Entity("Domain.Models.Topic", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Index")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<Guid?>("ModifiedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("SubjectId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("SubjectId");

                    b.ToTable("Topics");
                });

            modelBuilder.Entity("Domain.Models.University", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<Guid?>("ModifiedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("University");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f84e78ea-4426-4728-a3f6-c41c3ed22072"),
                            Code = "FPT",
                            Description = "Trường đại học tư thục hàng đầu Việt Nam về công nghệ thông tin và truyền thông.",
                            IsDeleted = false,
                            Name = "Đại học FPT"
                        },
                        new
                        {
                            Id = new Guid("6b70b92b-4201-4611-b6bb-716a5b3c4fec"),
                            Code = "UEH",
                            Description = "Trường đại học công lập đào tạo về kinh tế, tài chính, ngân hàng hàng đầu tại Việt Nam",
                            IsDeleted = false,
                            Name = "Đại học kinh tế TPHCM"
                        },
                        new
                        {
                            Id = new Guid("0e7c3b01-d954-4986-9d9d-f48127433211"),
                            Code = "HCMUE",
                            Description = "Trường đại học công lập đào tạo sư phạm lớn nhất Việt Nam",
                            IsDeleted = false,
                            Name = "Đại học Sư phạm Thành phố Hồ Chí Minh"
                        },
                        new
                        {
                            Id = new Guid("b629e405-9aca-4c19-bbe3-f4a50d9cca62"),
                            Code = "UMP",
                            Description = "Trường đại học công lập đào tạo về y dược lớn nhất Việt Nam",
                            IsDeleted = false,
                            Name = "Đại học Y Dược Thành phố Hồ Chí Minh"
                        },
                        new
                        {
                            Id = new Guid("cf30b5ef-1a8f-472f-af90-337a5cee4c16"),
                            Code = "UAH",
                            Description = "Trường đại học công lập đào tạo về kiến trúc hàng đầu Việt Nam",
                            IsDeleted = false,
                            Name = "Đại học Kiến trúc Thành phố Hồ Chí Minh"
                        });
                });

            modelBuilder.Entity("Domain.Models.UniversityDepartment", b =>
                {
                    b.Property<Guid>("UniversityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("DepartmentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<Guid?>("ModifiedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("UniversityId", "DepartmentId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("UniversityDepartments");
                });

            modelBuilder.Entity("Domain.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ModifiedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Domain.Models.Attempt", b =>
                {
                    b.HasOne("Domain.Models.User", "User")
                        .WithMany("Attempts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domain.Models.AttemptDetail", b =>
                {
                    b.HasOne("Domain.Models.Attempt", "Attempt")
                        .WithMany("AttemptDetails")
                        .HasForeignKey("AttemptId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Models.ExaminationQuestion", "ExaminationQuestion")
                        .WithMany("AttemptDetails")
                        .HasForeignKey("ExaminationQuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Attempt");

                    b.Navigation("ExaminationQuestion");
                });

            modelBuilder.Entity("Domain.Models.ExaminationQuestion", b =>
                {
                    b.HasOne("Domain.Models.Examination", "Examination")
                        .WithMany("ExaminationQuestions")
                        .HasForeignKey("ExaminationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Models.Question", "Question")
                        .WithMany("ExaminationQuestions")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Examination");

                    b.Navigation("Question");
                });

            modelBuilder.Entity("Domain.Models.GroupDepartment", b =>
                {
                    b.HasOne("Domain.Models.Department", "Department")
                        .WithMany("GroupDepartments")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Models.Group", "Group")
                        .WithMany("GroupDepartments")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");

                    b.Navigation("Group");
                });

            modelBuilder.Entity("Domain.Models.MBTI_Department", b =>
                {
                    b.HasOne("Domain.Models.Department", "Department")
                        .WithMany("MBTI_Departments")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Models.MBTI", "MBTI")
                        .WithMany("MBTI_Departments")
                        .HasForeignKey("MBTI_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");

                    b.Navigation("MBTI");
                });

            modelBuilder.Entity("Domain.Models.Major", b =>
                {
                    b.HasOne("Domain.Models.Department", "Department")
                        .WithMany("Majors")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("Domain.Models.Question", b =>
                {
                    b.HasOne("Domain.Models.Topic", "Topic")
                        .WithMany("Questions")
                        .HasForeignKey("TopicId");

                    b.Navigation("Topic");
                });

            modelBuilder.Entity("Domain.Models.SubjectGroup", b =>
                {
                    b.HasOne("Domain.Models.Group", "Group")
                        .WithMany("SubjectGroups")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Models.Subject", "Subject")
                        .WithMany("SubjectGroups")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Group");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("Domain.Models.Topic", b =>
                {
                    b.HasOne("Domain.Models.Subject", "Subject")
                        .WithMany("Topics")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("Domain.Models.UniversityDepartment", b =>
                {
                    b.HasOne("Domain.Models.Department", "Department")
                        .WithMany("UniversityDepartments")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Models.University", "University")
                        .WithMany("UniversityDepartments")
                        .HasForeignKey("UniversityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");

                    b.Navigation("University");
                });

            modelBuilder.Entity("Domain.Models.Attempt", b =>
                {
                    b.Navigation("AttemptDetails");
                });

            modelBuilder.Entity("Domain.Models.Department", b =>
                {
                    b.Navigation("GroupDepartments");

                    b.Navigation("MBTI_Departments");

                    b.Navigation("Majors");

                    b.Navigation("UniversityDepartments");
                });

            modelBuilder.Entity("Domain.Models.Examination", b =>
                {
                    b.Navigation("ExaminationQuestions");
                });

            modelBuilder.Entity("Domain.Models.ExaminationQuestion", b =>
                {
                    b.Navigation("AttemptDetails");
                });

            modelBuilder.Entity("Domain.Models.Group", b =>
                {
                    b.Navigation("GroupDepartments");

                    b.Navigation("SubjectGroups");
                });

            modelBuilder.Entity("Domain.Models.MBTI", b =>
                {
                    b.Navigation("MBTI_Departments");
                });

            modelBuilder.Entity("Domain.Models.Question", b =>
                {
                    b.Navigation("ExaminationQuestions");
                });

            modelBuilder.Entity("Domain.Models.Subject", b =>
                {
                    b.Navigation("SubjectGroups");

                    b.Navigation("Topics");
                });

            modelBuilder.Entity("Domain.Models.Topic", b =>
                {
                    b.Navigation("Questions");
                });

            modelBuilder.Entity("Domain.Models.University", b =>
                {
                    b.Navigation("UniversityDepartments");
                });

            modelBuilder.Entity("Domain.Models.User", b =>
                {
                    b.Navigation("Attempts");
                });
#pragma warning restore 612, 618
        }
    }
}
