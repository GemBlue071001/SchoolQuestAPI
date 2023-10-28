﻿// <auto-generated />
using System;
using ApplicationContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ApplicationContext.Migrations
{
    [DbContext(typeof(HighSchoolQuestContext))]
    partial class HighSchoolQuestContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Domain.Models.Attempt", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("AttempType")
                        .HasColumnType("integer");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("ExamDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<Guid?>("ModifiedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Result")
                        .HasColumnType("text");

                    b.Property<int?>("Score")
                        .HasColumnType("integer");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Attempts");
                });

            modelBuilder.Entity("Domain.Models.AttemptDetail", b =>
                {
                    b.Property<Guid>("AttemptId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("ExaminationQuestionId")
                        .HasColumnType("uuid");

                    b.Property<bool>("IsCorrect")
                        .HasColumnType("boolean");

                    b.Property<string>("UserAnswered")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("AttemptId", "ExaminationQuestionId");

                    b.HasIndex("ExaminationQuestionId");

                    b.ToTable("AttemptDetails");
                });

            modelBuilder.Entity("Domain.Models.Department", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Code")
                        .HasColumnType("text");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("NOW()");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<Guid?>("ModifiedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .HasColumnType("text");

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
                        .HasColumnType("uuid");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("NOW()");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<Guid?>("ModifiedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("TotalNumberOfQuestion")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Examinations");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ad0080ef-ac58-450b-b086-bc7f856c1fec"),
                            Description = "de thi toan",
                            IsDeleted = false,
                            Name = "de toan",
                            TotalNumberOfQuestion = 4
                        });
                });

            modelBuilder.Entity("Domain.Models.ExaminationQuestion", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("NOW()");

                    b.Property<Guid>("ExaminationId")
                        .HasColumnType("uuid");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<Guid?>("ModifiedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("QuestionId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("ExaminationId");

                    b.HasIndex("QuestionId");

                    b.ToTable("ExaminationQuestions");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ad0080ef-ac58-450b-b086-bc7f856c1fec"),
                            ExaminationId = new Guid("ad0080ef-ac58-450b-b086-bc7f856c1fec"),
                            IsDeleted = false,
                            QuestionId = new Guid("238f27e2-fe56-4ce8-88f8-d3aa7b56f976")
                        },
                        new
                        {
                            Id = new Guid("046b0f97-130a-48c7-b1ad-40033ae41fff"),
                            ExaminationId = new Guid("ad0080ef-ac58-450b-b086-bc7f856c1fec"),
                            IsDeleted = false,
                            QuestionId = new Guid("85e5d51b-16c7-4d0d-8f40-766a6a902698")
                        },
                        new
                        {
                            Id = new Guid("2339983b-33db-4333-9b1b-a5514faa280a"),
                            ExaminationId = new Guid("ad0080ef-ac58-450b-b086-bc7f856c1fec"),
                            IsDeleted = false,
                            QuestionId = new Guid("3e28911a-1220-4c7f-a1c6-bcce0b74ccfe")
                        },
                        new
                        {
                            Id = new Guid("139c3a57-af40-4c80-96fc-508957db3780"),
                            ExaminationId = new Guid("ad0080ef-ac58-450b-b086-bc7f856c1fec"),
                            IsDeleted = false,
                            QuestionId = new Guid("21eb2451-53ac-44f6-9a6c-751d394a8936")
                        });
                });

            modelBuilder.Entity("Domain.Models.Group", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<Guid?>("ModifiedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("Domain.Models.GroupDepartment", b =>
                {
                    b.Property<Guid>("DepartmentId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("GroupId")
                        .HasColumnType("uuid");

                    b.HasKey("DepartmentId", "GroupId");

                    b.HasIndex("GroupId");

                    b.ToTable("GroupDepartments");
                });

            modelBuilder.Entity("Domain.Models.MBTI", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("MBTI");
                });

            modelBuilder.Entity("Domain.Models.MBTI_Department", b =>
                {
                    b.Property<int>("MBTI_Id")
                        .HasColumnType("integer");

                    b.Property<Guid>("DepartmentId")
                        .HasColumnType("uuid");

                    b.HasKey("MBTI_Id", "DepartmentId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("MBTI_Department");
                });

            modelBuilder.Entity("Domain.Models.Major", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("DepartmentId")
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("MajorName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid?>("ModifiedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Major");
                });

            modelBuilder.Entity("Domain.Models.Question", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("NOW()");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<Guid?>("ModifiedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("TopicId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("TopicId");

                    b.ToTable("Questions");

                    b.HasData(
                        new
                        {
                            Id = new Guid("238f27e2-fe56-4ce8-88f8-d3aa7b56f976"),
                            Content = "{\"Question\":\"What is the capital of France?\",\"ListAnswer\":[{\"Value\":\"Paris\",\"IsAnswer\":true},{\"Value\":\"London\",\"IsAnswer\":false},{\"Value\":\"Berlin\",\"IsAnswer\":false}]}",
                            IsDeleted = false,
                            TopicId = new Guid("f722c143-412c-4721-bf5c-5b32a01d90da")
                        },
                        new
                        {
                            Id = new Guid("85e5d51b-16c7-4d0d-8f40-766a6a902698"),
                            Content = "{\"Question\":\"How many continents are there?\",\"ListAnswer\":[{\"Value\":\"7\",\"IsAnswer\":true},{\"Value\":\"5\",\"IsAnswer\":false},{\"Value\":\"6\",\"IsAnswer\":false}]}",
                            IsDeleted = false,
                            TopicId = new Guid("f722c143-412c-4721-bf5c-5b32a01d90da")
                        },
                        new
                        {
                            Id = new Guid("3e28911a-1220-4c7f-a1c6-bcce0b74ccfe"),
                            Content = "{\"Question\":\"When was the Declaration of Independence signed?\",\"ListAnswer\":[{\"Value\":\"1776-07-04\",\"IsAnswer\":true},{\"Value\":\"1789-09-25\",\"IsAnswer\":false},{\"Value\":\"1800-03-12\",\"IsAnswer\":false}]}",
                            IsDeleted = false,
                            TopicId = new Guid("f722c143-412c-4721-bf5c-5b32a01d90da")
                        },
                        new
                        {
                            Id = new Guid("21eb2451-53ac-44f6-9a6c-751d394a8936"),
                            Content = "{\"Question\":\"Which cities are in the United Kingdom?\",\"ListAnswer\":[{\"Value\":\"London\",\"IsAnswer\":true},{\"Value\":\"Manchester\",\"IsAnswer\":false},{\"Value\":\"Edinburgh\",\"IsAnswer\":true}]}",
                            IsDeleted = false,
                            TopicId = new Guid("f722c143-412c-4721-bf5c-5b32a01d90da")
                        });
                });

            modelBuilder.Entity("Domain.Models.Subject", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("NOW()");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<Guid?>("ModifiedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Subjects");

                    b.HasData(
                        new
                        {
                            Id = new Guid("6a8c8d5f-2a54-42ee-8a7f-0961273cd625"),
                            IsDeleted = false,
                            Name = "Toan"
                        });
                });

            modelBuilder.Entity("Domain.Models.SubjectGroup", b =>
                {
                    b.Property<Guid>("SubjectId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("GroupId")
                        .HasColumnType("uuid");

                    b.HasKey("SubjectId", "GroupId");

                    b.HasIndex("GroupId");

                    b.ToTable("SubjectGroup");
                });

            modelBuilder.Entity("Domain.Models.Topic", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("NOW()");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Index")
                        .HasColumnType("integer");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<Guid?>("ModifiedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("SubjectId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("SubjectId");

                    b.ToTable("Topics");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f722c143-412c-4721-bf5c-5b32a01d90da"),
                            Description = "toan dai cuong",
                            Index = 1,
                            IsDeleted = false,
                            Name = "toan dai cuong",
                            SubjectId = new Guid("6a8c8d5f-2a54-42ee-8a7f-0961273cd625")
                        },
                        new
                        {
                            Id = new Guid("25b3ba1e-240a-4a3c-96b6-c0816b0a3975"),
                            Description = "Toan hinh",
                            Index = 2,
                            IsDeleted = false,
                            Name = "toan hinh",
                            SubjectId = new Guid("6a8c8d5f-2a54-42ee-8a7f-0961273cd625")
                        });
                });

            modelBuilder.Entity("Domain.Models.University", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<Guid?>("ModifiedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

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
                        .HasColumnType("uuid");

                    b.Property<Guid>("DepartmentId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<Guid?>("ModifiedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("UniversityId", "DepartmentId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("UniversityDepartments");
                });

            modelBuilder.Entity("Domain.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("NOW()");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<Guid?>("ModifiedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("bytea");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("bytea");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<int>("Role")
                        .HasColumnType("integer");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("text");

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
