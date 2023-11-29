using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ApplicationContext.Migrations
{
    /// <inheritdoc />
    public partial class prod : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Code = table.Column<string>(type: "text", nullable: true),
                    RequiredScore = table.Column<float>(type: "real", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, defaultValueSql: "NOW()"),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Examinations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    TotalNumberOfQuestion = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, defaultValueSql: "NOW()"),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Examinations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MBTI",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MBTI", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MBTI_Exams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Note = table.Column<string>(type: "text", nullable: false),
                    NumberOfQuestion = table.Column<int>(type: "integer", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MBTI_Exams", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MBTI_Questions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NameQuestion = table.Column<string>(type: "text", nullable: false),
                    FirstAnswerType = table.Column<int>(type: "integer", nullable: false),
                    SecondAnswerType = table.Column<int>(type: "integer", nullable: false),
                    NameAns1 = table.Column<string>(type: "text", nullable: false),
                    NameAns2 = table.Column<string>(type: "text", nullable: false),
                    Category = table.Column<int>(type: "integer", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MBTI_Questions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, defaultValueSql: "NOW()"),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "University",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_University", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserName = table.Column<string>(type: "text", nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "bytea", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "bytea", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: true),
                    LastName = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    HighestScore = table.Column<int>(type: "integer", nullable: true),
                    Address = table.Column<string>(type: "text", nullable: true),
                    Role = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, defaultValueSql: "NOW()"),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Major",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    MajorName = table.Column<string>(type: "text", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    DepartmentId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Major", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Major_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GroupDepartments",
                columns: table => new
                {
                    DepartmentId = table.Column<Guid>(type: "uuid", nullable: false),
                    GroupId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupDepartments", x => new { x.DepartmentId, x.GroupId });
                    table.ForeignKey(
                        name: "FK_GroupDepartments_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GroupDepartments_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MBTI_Department",
                columns: table => new
                {
                    MBTI_Id = table.Column<int>(type: "integer", nullable: false),
                    DepartmentId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MBTI_Department", x => new { x.MBTI_Id, x.DepartmentId });
                    table.ForeignKey(
                        name: "FK_MBTI_Department_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MBTI_Department_MBTI_MBTI_Id",
                        column: x => x.MBTI_Id,
                        principalTable: "MBTI",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MBTI_ExamQuestions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    QuestionId = table.Column<int>(type: "integer", nullable: false),
                    ExamId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MBTI_ExamQuestions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MBTI_ExamQuestions_MBTI_Exams_ExamId",
                        column: x => x.ExamId,
                        principalTable: "MBTI_Exams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MBTI_ExamQuestions_MBTI_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "MBTI_Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubjectGroup",
                columns: table => new
                {
                    SubjectId = table.Column<Guid>(type: "uuid", nullable: false),
                    GroupId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubjectGroup", x => new { x.SubjectId, x.GroupId });
                    table.ForeignKey(
                        name: "FK_SubjectGroup_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SubjectGroup_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Topics",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Index = table.Column<int>(type: "integer", nullable: false),
                    SubjectId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, defaultValueSql: "NOW()"),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Topics", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Topics_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UniversityDepartments",
                columns: table => new
                {
                    UniversityId = table.Column<Guid>(type: "uuid", nullable: false),
                    DepartmentId = table.Column<Guid>(type: "uuid", nullable: false),
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UniversityDepartments", x => new { x.UniversityId, x.DepartmentId });
                    table.ForeignKey(
                        name: "FK_UniversityDepartments_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UniversityDepartments_University_UniversityId",
                        column: x => x.UniversityId,
                        principalTable: "University",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Attempts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    ExamDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    AttempType = table.Column<int>(type: "integer", nullable: false),
                    Score = table.Column<int>(type: "integer", nullable: true),
                    Result = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attempts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Attempts_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MBTI_UserRecords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    Result = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MBTI_UserRecords", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MBTI_UserRecords_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Content = table.Column<string>(type: "text", nullable: false),
                    TopicId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, defaultValueSql: "NOW()"),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Questions_Topics_TopicId",
                        column: x => x.TopicId,
                        principalTable: "Topics",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RecordDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserRecordId = table.Column<int>(type: "integer", nullable: false),
                    MBTI_ExamQuestionId = table.Column<int>(type: "integer", nullable: false),
                    UserChoice = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecordDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RecordDetails_MBTI_ExamQuestions_MBTI_ExamQuestionId",
                        column: x => x.MBTI_ExamQuestionId,
                        principalTable: "MBTI_ExamQuestions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RecordDetails_MBTI_UserRecords_UserRecordId",
                        column: x => x.UserRecordId,
                        principalTable: "MBTI_UserRecords",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExaminationQuestions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ExaminationId = table.Column<Guid>(type: "uuid", nullable: false),
                    QuestionId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, defaultValueSql: "NOW()"),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExaminationQuestions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExaminationQuestions_Examinations_ExaminationId",
                        column: x => x.ExaminationId,
                        principalTable: "Examinations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExaminationQuestions_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AttemptDetails",
                columns: table => new
                {
                    AttemptId = table.Column<Guid>(type: "uuid", nullable: false),
                    ExaminationQuestionId = table.Column<Guid>(type: "uuid", nullable: false),
                    IsCorrect = table.Column<bool>(type: "boolean", nullable: false),
                    UserAnswered = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttemptDetails", x => new { x.AttemptId, x.ExaminationQuestionId });
                    table.ForeignKey(
                        name: "FK_AttemptDetails_Attempts_AttemptId",
                        column: x => x.AttemptId,
                        principalTable: "Attempts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AttemptDetails_ExaminationQuestions_ExaminationQuestionId",
                        column: x => x.ExaminationQuestionId,
                        principalTable: "ExaminationQuestions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "Id", "Code", "CreatedBy", "Description", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name", "RequiredScore" },
                values: new object[,]
                {
                    { new Guid("4c7c3b5f-2a54-42ee-8a7f-0961273cd329"), "YH", null, "Các ngành y dược", false, null, null, "Y học", 27f },
                    { new Guid("5fbe7741-917c-45f5-8f78-c06327ede146"), "NN", null, "Các ngành về ngôn ngữ", false, null, null, "Ngôn Ngữ", 22f },
                    { new Guid("67d181a2-ac85-4aaa-bcad-863b8695071b"), "LAW", null, "Các ngành về luật", false, null, null, "Luật", 23f },
                    { new Guid("b8034210-23fd-4af9-9d7f-f260a0cdef97"), "KT", null, "các ngành về kinh tế", false, null, null, "Kinh tế", 22f },
                    { new Guid("bb3a10db-c4d4-4b45-9d15-0c38f41e8f5f"), "TK", null, "Các ngành thiết kế/nghệ thuật", false, null, null, "Thiết kế", 22f },
                    { new Guid("de305d54-75b4-431b-adb2-eb6b9e546013"), "SE", null, "các ngành về máy tính", false, null, null, "Công nghệ thông tin", 22f },
                    { new Guid("e35d862c-1f43-456b-a60b-1b2c7e44ab78"), "SP", null, "Các ngành sư phạm", false, null, null, "Sư phạm", 25f },
                    { new Guid("f9cf3140-b872-4837-b965-d37f94e33c0b"), "TT", null, "Các ngành về báo chí/truyền thông", false, null, null, "Truyền Thông", 24f }
                });

            migrationBuilder.InsertData(
                table: "Examinations",
                columns: new[] { "Id", "CreatedBy", "Description", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name", "TotalNumberOfQuestion" },
                values: new object[,]
                {
                    { new Guid("1e157ceb-9adb-48bf-84de-ae050c2f89b8"), null, "De thi hoa hoc", false, null, null, "de hoa", 20 },
                    { new Guid("61bb287c-ea61-47ec-883d-628ed98bb716"), null, "De thi am nhac", false, null, null, "de music", 10 },
                    { new Guid("80b9fa50-f8aa-4bc5-bf05-39e8f54f8f06"), null, "De thi van", false, null, null, "de van", 5 },
                    { new Guid("ad0080ef-ac58-450b-b086-bc7f856c1fec"), null, "de thi toan", false, null, null, "de toan", 4 },
                    { new Guid("e296dd9b-4007-4666-b6fe-35664dcaed77"), null, "De thi sinh hoc", false, null, null, "de sinh", 21 }
                });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "Code", "CreatedBy", "CreatedDate", "Description", "IsDeleted", "ModifiedBy", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("09f798c3-4d01-437f-b361-bf230efd7ddf"), "GroupD", null, null, "Khối D", false, null, null },
                    { new Guid("20bbb66d-3117-4050-ae30-4caf85831530"), "GroupH", null, null, "Khối H", false, null, null },
                    { new Guid("632ba05a-9ed9-4a00-9ac8-e1c642919806"), "GroupB", null, null, "Khối B", false, null, null },
                    { new Guid("b8de514a-7bba-4b8b-bae1-fc36c07ed52b"), "GroupV", null, null, "Khối V", false, null, null },
                    { new Guid("dab75dab-d28c-45ad-98a6-b3f25dec3ad0"), "GroupC", null, null, "Khối C", false, null, null },
                    { new Guid("f5e0affd-9745-4859-8171-77b99fc725c1"), "GroupA", null, null, "Khối A", false, null, null }
                });

            migrationBuilder.InsertData(
                table: "MBTI",
                columns: new[] { "Id", "Code", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "INTJ", "Imaginative and strategic thinkers, with a plan for everything.", "The Architect" },
                    { 2, "INTP", "Innovative inventors with an unquenchable thirst for knowledge.", "The Logician" },
                    { 3, "ENTJ", "Bold, imaginative and strong-willed leaders, always finding a way – or making one.", "The Commander" },
                    { 4, "ENTP", "Smart and curious thinkers who cannot resist an intellectual challenge.", "The Debater" },
                    { 5, "INFJ", "Quiet and mystical, yet very inspiring and tireless idealists.", "The Advocate" },
                    { 6, "INFP", "Poetic, kind and altruistic people, always eager to help a good cause.", "The Mediator" },
                    { 7, "ENFJ", "Charismatic and inspiring leaders, able to mesmerize their listeners.", "The Protagonist" },
                    { 8, "ENFP", "Enthusiastic, creative and sociable free spirits, who can always find a reason to smile.", "The Campaigner" },
                    { 9, "ISTJ", "Practical and fact-minded individuals, whose reliability cannot be doubted.", "The Logistician" },
                    { 10, "ISFJ", "Very dedicated and warm protectors, always ready to defend their loved ones.", "The Defender" },
                    { 11, "ESTJ", "Excellent administrators, unsurpassed at managing things – or people.", "The Executive" },
                    { 12, "ESFJ", "Extraordinarily caring, social and popular people, always eager to help.", "The Consul" },
                    { 13, "ISTP", "Bold and practical experimenters, masters of all kinds of tools.", "The Virtuoso" },
                    { 14, "ISFP", "Flexible and charming artists, always ready to explore and experience something new.", "The Adventurer" },
                    { 15, "ESTP", "Smart, energetic and very perceptive people, who truly enjoy living on the edge.", "The Entrepreneur" },
                    { 16, "ESFP", "Spontaneous, energetic and enthusiastic people – life is never boring around them.", "The Entertainer" }
                });

            migrationBuilder.InsertData(
                table: "MBTI_Exams",
                columns: new[] { "Id", "CreatedBy", "Note", "NumberOfQuestion" },
                values: new object[] { 1, null, "MBTI Exam", 12 });

            migrationBuilder.InsertData(
                table: "MBTI_Questions",
                columns: new[] { "Id", "Category", "CreatedBy", "FirstAnswerType", "NameAns1", "NameAns2", "NameQuestion", "SecondAnswerType" },
                values: new object[,]
                {
                    { 1, 0, new Guid("a6be20e2-5927-4cce-bed4-258f919f82e6"), 0, "a. Xã hội, giao tiếp.", "b. Thiết kế, nghiên cứu.", "Bạn thích công việc kiểu : ", 1 },
                    { 2, 0, new Guid("a6be20e2-5927-4cce-bed4-258f919f82e6"), 0, "a. Khách quan.", "b. Chủ quan.", "Bạn tiếp xúc với một người theo xu hướng : ", 1 },
                    { 3, 2, new Guid("a6be20e2-5927-4cce-bed4-258f919f82e6"), 4, "a. Ý nghĩa, giá trị.", "b. Tính logic.", "Bạn đánh giá sự việc dựa trên : ", 5 },
                    { 4, 0, new Guid("a6be20e2-5927-4cce-bed4-258f919f82e6"), 0, "a. Thong thả, thoải mái.", "b. Nhanh nhẹn, đúng giờ.", "Bạn là người có tác phong : ", 1 },
                    { 5, 0, new Guid("a6be20e2-5927-4cce-bed4-258f919f82e6"), 0, "a. Bắt đầu cho cuộc nói chuyện.", "b. Chỉ nói khi người khác bắt chuyện.", "Trong các cuộc giao tiếp, bạn là người : ", 1 },
                    { 6, 2, new Guid("a6be20e2-5927-4cce-bed4-258f919f82e6"), 4, "a. Là người có cái đầu lạnh.", "b. Là người có trái tim ấm.", "Bạn là người thế nào : ", 5 },
                    { 7, 0, new Guid("a6be20e2-5927-4cce-bed4-258f919f82e6"), 0, "a. Dễ chịu, thoải mái.", "b. Nghiêm chỉnh, quả quyết.", "Tính cách của bạn : ", 1 },
                    { 8, 3, new Guid("a6be20e2-5927-4cce-bed4-258f919f82e6"), 6, "a. Khá thú vị.", "b. Khó hiểu.", "Những người có tầm nhìn xa thường : ", 7 },
                    { 9, 0, new Guid("a6be20e2-5927-4cce-bed4-258f919f82e6"), 0, "a. Dễ dàng bắt chuyện và trò chuyện nhiều điều cùng họ.", "b. Cảm thấy khó khăn và không biết nên nói gì.", "Đối với những người mới gặp, bạn thường : ", 1 },
                    { 10, 3, new Guid("a6be20e2-5927-4cce-bed4-258f919f82e6"), 6, "a. Không có quy trình cụ thể.", "b. Thiếu tính sáng tạo.", "Một công việc gây nhàm chán khi : ", 7 },
                    { 11, 2, new Guid("a6be20e2-5927-4cce-bed4-258f919f82e6"), 4, "a. Sự hòa hợp với mọi người.", "b. Sự nhất quán trong suy nghĩ.", "Bạn bị hấp dẫn bởi : ", 5 },
                    { 12, 1, new Guid("a6be20e2-5927-4cce-bed4-258f919f82e6"), 2, "a. Giàu trí tưởng tượng.", "b. Nắm bắt tình huống tốt.", "Bạn bị lôi cuốn bởi kiểu người : ", 3 },
                    { 13, 0, new Guid("a6be20e2-5927-4cce-bed4-258f919f82e6"), 0, "a. Dè dặt.", "b. Thoải mái.", "Trong các cuộc trò chuyện bạn thường : ", 1 },
                    { 14, 2, new Guid("a6be20e2-5927-4cce-bed4-258f919f82e6"), 4, "a. Tuân theo chuẩn mực.", "b. Đôi lúc không hiểu rõ nguyên nhân.", "Lựa chọn của bạn có xu hướng : ", 5 },
                    { 15, 2, new Guid("a6be20e2-5927-4cce-bed4-258f919f82e6"), 4, "a. Không công bằng.", "b. Tàn nhẫn.", "Trong hai điều sau, điều nào tồi tệ hơn : ", 5 },
                    { 16, 2, new Guid("a6be20e2-5927-4cce-bed4-258f919f82e6"), 4, "a. Kiên quyết.", "b. Nhẹ nhàng.", "Tính cách nào giống bạn hơn : ", 5 },
                    { 17, 0, new Guid("a6be20e2-5927-4cce-bed4-258f919f82e6"), 0, "a. Độc lập giải quyết.", "b. Trao đổi với mọi người.", "Đối với một vấn đề trong nhóm : ", 1 },
                    { 18, 3, new Guid("a6be20e2-5927-4cce-bed4-258f919f82e6"), 6, "a. Những điều bất ngờ không tính trước.", "b. Những điều có kế hoạch trước.", "Trong cuộc sống, bạn cảm thấy hứng thú với : ", 7 },
                    { 19, 2, new Guid("a6be20e2-5927-4cce-bed4-258f919f82e6"), 4, "a. Chắc chắn trong tư tưởng.", "b. Cống hiến hết mình.", "Bạn thấy tâm đắc với bản thân bởi sự : ", 5 },
                    { 20, 2, new Guid("a6be20e2-5927-4cce-bed4-258f919f82e6"), 4, "a. Khả năng lý luận phân tích.", "b. Sự liên tưởng.", "Bạn nhìn nhận một vấn đề với : ", 5 },
                    { 21, 0, new Guid("a6be20e2-5927-4cce-bed4-258f919f82e6"), 0, "a. Ở nhà cùng gia đình.", "b. Đi du lịch cùng bạn bè.", "Trong các kỳ nghỉ lễ bạn có xu hướng : ", 1 },
                    { 22, 3, new Guid("a6be20e2-5927-4cce-bed4-258f919f82e6"), 6, "a. Các ngụ ý, hàm ý, ẩn ý.", "b. Các nguyên tắc, nguyên lý.", "Bạn bị lôi cuốn bởi : ", 7 },
                    { 23, 2, new Guid("a6be20e2-5927-4cce-bed4-258f919f82e6"), 5, "a. Cảm nhận từ con tim.", "b. Những quy tắc chung.", "Khi quyết định việc gì bạn thường dựa vào : ", 4 },
                    { 24, 3, new Guid("a6be20e2-5927-4cce-bed4-258f919f82e6"), 6, "a. Làm việc có phương pháp, tổ chức tốt.", "b. Ứng biến xoay trở tốt trước khó khăn.", "Bạn thích làm việc với người Sếp", 7 },
                    { 25, 3, new Guid("a6be20e2-5927-4cce-bed4-258f919f82e6"), 6, "a. Sự chắc chắn.", "b. Sự cởi mở.", "Bạn nghiêng về :", 7 },
                    { 26, 2, new Guid("a6be20e2-5927-4cce-bed4-258f919f82e6"), 4, "a. Công tư phân minh.", "b. Bị tình cảm chi phối.", "Bạn là người có tư tưởng :", 5 },
                    { 27, 1, new Guid("a6be20e2-5927-4cce-bed4-258f919f82e6"), 3, "a. Nghệ thuật.", "b. Khoa học.", "Bạn thích học các môn :", 2 },
                    { 28, 0, new Guid("a6be20e2-5927-4cce-bed4-258f919f82e6"), 1, "a. Trầm lặng, ít nói.", "b. Hoạt bát, vui vẻ.", "Trong một nhóm bạn bè bạn thường :", 0 },
                    { 29, 1, new Guid("a6be20e2-5927-4cce-bed4-258f919f82e6"), 2, "a. Dựa vào vẻ ngoài của họ.", "b. Dựa vào cảm nhận của bạn.", "Khi đánh giá một người bạn thường :", 3 },
                    { 30, 3, new Guid("a6be20e2-5927-4cce-bed4-258f919f82e6"), 6, "a. Quá nồng nhiệt, mong chờ.", "b. Quá khách quan.", "Sẽ thật tai hại khi bạn :", 7 },
                    { 31, 1, new Guid("a6be20e2-5927-4cce-bed4-258f919f82e6"), 2, "a. Thích những thứ quen thuộc.", "b. Thích những điều mới mẻ.", "Phong cách của bạn :", 3 },
                    { 32, 3, new Guid("a6be20e2-5927-4cce-bed4-258f919f82e6"), 7, "a. Tìm kiếm một cách làm mới.", "b. Làm theo cách mọi người hay làm.", "Khi giải quyết một công việc thông thường, bạn sẽ :", 6 },
                    { 33, 0, new Guid("a6be20e2-5927-4cce-bed4-258f919f82e6"), 1, "a. Độc lập.", "b. Theo nhóm.", "Bạn thích làm việc :", 0 },
                    { 34, 3, new Guid("a6be20e2-5927-4cce-bed4-258f919f82e6"), 6, "a. Hiếm khi.", "b. Hay xảy ra.", "Bạn có hành động theo bản năng :", 7 },
                    { 35, 2, new Guid("a6be20e2-5927-4cce-bed4-258f919f82e6"), 4, "a. Giàu lý trí.", "b. Giàu cảm xúc.", "Trong cuộc sống, một người sẽ tốt hơn nếu :", 5 },
                    { 36, 3, new Guid("a6be20e2-5927-4cce-bed4-258f919f82e6"), 6, "a. Theo thứ tự.", "b. Phát ngẫu nhiên.", "Khi nghe một album nhạc mới, bạn thường nghe :", 7 },
                    { 37, 2, new Guid("a6be20e2-5927-4cce-bed4-258f919f82e6"), 5, "a. Khéo léo, lanh lợi.", "b. Thẳng thắn, thực tế.", "Bạn là người :", 4 },
                    { 38, 2, new Guid("a6be20e2-5927-4cce-bed4-258f919f82e6"), 4, "a. Sử dụng người khác.", "b. Hiểu và chia sẻ với người khác.", "Sẽ khó khăn hơn khi bạn cố:", 5 },
                    { 39, 0, new Guid("a6be20e2-5927-4cce-bed4-258f919f82e6"), 1, "a. Diễn đạt trực tiếp nhất có thể.", "b. Diễn đạt một cách gián tiếp.", "Khi trình bày bạn thường :", 0 },
                    { 40, 0, new Guid("a6be20e2-5927-4cce-bed4-258f919f82e6"), 0, "a. Tìm bạn bè tâm sự hoặc đi chơi.", "b. Muốn ở một mình cho khuây khỏa.", "Khi cảm thấy buồn bạn thường :", 1 },
                    { 41, 3, new Guid("a6be20e2-5927-4cce-bed4-258f919f82e6"), 6, "a. Tham gia khi bị ép.", "b. Năng nổ, tích cực.", "Đối với các hoạt động của cơ quan, lớp học :", 7 },
                    { 42, 1, new Guid("a6be20e2-5927-4cce-bed4-258f919f82e6"), 3, "a. Những thứ không xác định.", "b. Những thứ có logic.", "Bạn cảm thấy thoải mái với :", 2 },
                    { 43, 2, new Guid("a6be20e2-5927-4cce-bed4-258f919f82e6"), 5, "a. Dễ dàng nắm bắt.", "b. Giấu kín, khó nhận biết.", "Cảm xúc của bạn thường được người khác :", 4 },
                    { 44, 2, new Guid("a6be20e2-5927-4cce-bed4-258f919f82e6"), 4, "a. Hành xử thiếu cân nhắc.", "b. Chỉ trích, phê phán người khác.", "Thật tồi tệ khi :", 5 },
                    { 45, 3, new Guid("a6be20e2-5927-4cce-bed4-258f919f82e6"), 6, "a. Chuẩn bị chu toàn trước.", "b. Diễn ra tự nhiên.", "Bạn muốn một sự kiện như thế nào :", 7 },
                    { 46, 0, new Guid("a6be20e2-5927-4cce-bed4-258f919f82e6"), 0, "a. Dễ gần, hòa đồng.", "b. Thân thiện nhưng kín đáo.", "Bạn là người có tình cách :", 1 },
                    { 47, 1, new Guid("a6be20e2-5927-4cce-bed4-258f919f82e6"), 3, "a. Trí tưởng tượng phong phú.", "b. Sự quan sát thực tế.", "Bạn có ưu điểm về :", 2 },
                    { 48, 2, new Guid("a6be20e2-5927-4cce-bed4-258f919f82e6"), 5, "a. Linh cảm.", "b. Sự việc thực tế.", "Khi quyết định điều gì đó, bạn tin vào :", 4 },
                    { 49, 2, new Guid("a6be20e2-5927-4cce-bed4-258f919f82e6"), 4, "a. Bạn là người có đầu óc suy luận.", "b. Bạn là người giàu tình cảm và sự tinh tế.", "Bạn muốn được người khác khen ngợi như thế nào :", 5 },
                    { 50, 3, new Guid("a6be20e2-5927-4cce-bed4-258f919f82e6"), 6, "a. Có chọn lựa và suy tính.", "b. Một cách tự nhiên.", "Bạn thích các sự việc xảy ra :", 7 },
                    { 51, 3, new Guid("a6be20e2-5927-4cce-bed4-258f919f82e6"), 7, "a. Bộc phát, linh hoạt.", "b. Kỹ lưỡng, cẩn thận.", "Bạn hay hành động một cách :", 6 },
                    { 52, 2, new Guid("a6be20e2-5927-4cce-bed4-258f919f82e6"), 5, "a. Tình cảm dồi dào.", "b. Lý trí mạnh mẽ.", "Bạn muốn bổ sung thêm điều gì ở bản thân :", 4 },
                    { 53, 1, new Guid("a6be20e2-5927-4cce-bed4-258f919f82e6"), 3, "a. Mơ mộng và tưởng tượng.", "b. Thực tế và thực dụng.", "Bạn là người :", 2 },
                    { 54, 0, new Guid("a6be20e2-5927-4cce-bed4-258f919f82e6"), 0, "a. Nhấc máy trước để nghe.", "b. Để cho đồng nghiệp nhấc máy.", "Khi điện thoại bàn trong văn phòng công ty đổ chuông :", 1 },
                    { 55, 0, new Guid("a6be20e2-5927-4cce-bed4-258f919f82e6"), 0, "a. Cố làm quen với nhiều người.", "b. Chỉ nói chuyện với vài người.", "Bạn mới tham gia một lớp Ngoại ngữ :", 1 },
                    { 56, 1, new Guid("a6be20e2-5927-4cce-bed4-258f919f82e6"), 2, "a. Bản thân nó giải thích cho chính nó.", "b. Là bằng chứng giải thích cho các quy tắc, quy luật.", "Theo bạn, các sự việc, sự kiện :", 3 },
                    { 57, 2, new Guid("a6be20e2-5927-4cce-bed4-258f919f82e6"), 5, "a. Đa sầu đa cảm.", "b. Thực dụng, không bị chi phối bởi tình cảm.", "Bạn là người :", 4 },
                    { 58, 2, new Guid("a6be20e2-5927-4cce-bed4-258f919f82e6"), 5, "a. Những suy nghĩ của họ.", "b. Những gì họ làm được.", "Bạn thường quan tâm tới người khác thông qua :", 4 },
                    { 59, 3, new Guid("a6be20e2-5927-4cce-bed4-258f919f82e6"), 6, "a. Thói quen.", "b. Những điều mới mẻ.", "Bạn nghiêng về điều nào sau đây :", 7 },
                    { 60, 3, new Guid("a6be20e2-5927-4cce-bed4-258f919f82e6"), 6, "a. Luôn được chuẩn bị kỹ lưỡng.", "b. Tùy cơ ứng biến.", "Mọi việc sẽ tốt hơn nếu :", 7 },
                    { 61, 0, new Guid("a6be20e2-5927-4cce-bed4-258f919f82e6"), 1, "a. Ít bạn nhưng chơi rất thân.", "b. Nhiều bạn nhưng không thân thiết lắm.", "Bạn thích mối quan hệ :", 0 },
                    { 62, 1, new Guid("a6be20e2-5927-4cce-bed4-258f919f82e6"), 3, "a. Diễn đạt lời văn qua các phép so sánh, ẩn dụ.", "b. Nghĩ sao viết vậy, diễn đạt rõ ràng.", "Nếu bạn là nhà văn, bạn sẽ viết bài theo cách :", 2 },
                    { 63, 3, new Guid("a6be20e2-5927-4cce-bed4-258f919f82e6"), 7, "a. Phụ thuộc vào tâm trạng.", "b. Suy tính cẩn trọng.", "Khi quyết định một việc :", 6 },
                    { 64, 3, new Guid("a6be20e2-5927-4cce-bed4-258f919f82e6"), 6, "a. Một cách chắn chắn.", "b. Không chắc lắm, có thể thay đổi sau.", "Bạn thường hay đưa ra quyết định :", 7 },
                    { 65, 2, new Guid("a6be20e2-5927-4cce-bed4-258f919f82e6"), 4, "a. Nguyên tắc, lý trí.", "b. Cảm xúc, tình cảm.", "Bạn là người sống thiên về :", 5 },
                    { 66, 1, new Guid("a6be20e2-5927-4cce-bed4-258f919f82e6"), 2, "a. Thực tế.", "b. Bất ngờ, mới mẻ", "Bạn thích thú với sự việc :", 3 },
                    { 67, 1, new Guid("a6be20e2-5927-4cce-bed4-258f919f82e6"), 2, "a. Không hứng thú.", "b. Hào hứng.", "Khi nói về một chủ đề mới lạ chưa gặp, bạn cảm thấy :", 3 },
                    { 68, 3, new Guid("a6be20e2-5927-4cce-bed4-258f919f82e6"), 6, "a. Kiểm tra lại trước khi áp dụng.", "b. Tin tưởng và áp dụng theo.", "Đối với một suy luận được nhiều người tin dùng, bạn sẽ :", 7 },
                    { 69, 2, new Guid("a6be20e2-5927-4cce-bed4-258f919f82e6"), 4, "a. Những thứ có tính logic cao.", "b. Những thứ gây cảm động.", "Điều gì làm cho bạn ấn tượng :", 5 },
                    { 70, 1, new Guid("a6be20e2-5927-4cce-bed4-258f919f82e6"), 2, "a. Những thứ thực tế và rõ ràng.", "b. Những suy đoán.", "Bạn là người có xu hướng thiên về :", 3 },
                    { 71, 0, new Guid("a6be20e2-5927-4cce-bed4-258f919f82e6"), 1, "a. Không thoải mái.", "b. Thích thú.", "Ở một nơi đông người làm bạn :", 0 },
                    { 72, 2, new Guid("a6be20e2-5927-4cce-bed4-258f919f82e6"), 5, "a. Hoàn cảnh nhất định.", "b. Nguyên tắc chung.", "Bạn đánh giá một người dựa trên :", 4 },
                    { 73, 0, new Guid("a6be20e2-5927-4cce-bed4-258f919f82e6"), 1, "a. Ra về sớm vì không hào hứng lắm.", "b. Vui chơi hết mình cho đến khi tàn tiệc.", "Bạn được mời tới bữa tiệc của công ty :", 0 },
                    { 74, 3, new Guid("a6be20e2-5927-4cce-bed4-258f919f82e6"), 6, "a. Tuân thủ thời gian.", "b. Làm việc tùy hứng.", "Khi làm việc bạn sẽ :", 7 },
                    { 75, 0, new Guid("a6be20e2-5927-4cce-bed4-258f919f82e6"), 0, "a. Trò chuyện cùng nhiều người, quen hoặc không quen.", "b. Chỉ trò chuyện với một số người quen.", "Khi đi tham dự một buổi liên hoan/tiệc tùng, bạn sẽ :", 1 },
                    { 76, 1, new Guid("a6be20e2-5927-4cce-bed4-258f919f82e6"), 3, "a. Những thứ mơ hồ, không rõ ràng.", "b. Những thứ nhàm chán, tẻ nhạt.", "Điều gì làm bạn cảm thấy tồi tệ :", 2 }
                });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "CreatedBy", "Description", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("00940497-7f82-493d-aac3-a56e9e92f390"), null, null, false, null, null, "Giáo dục công dân" },
                    { new Guid("0141a511-2028-4a5a-b81d-4a61d98ee0a8"), null, null, false, null, null, "Hóa học" },
                    { new Guid("4cb41deb-15d9-40ba-9d20-1f3f10410cc7"), null, null, false, null, null, "Địa Lý" },
                    { new Guid("50051095-391a-4abf-94f2-ac3cf912f07b"), null, null, false, null, null, "Mỹ Thuật" },
                    { new Guid("6a8c8d5f-2a54-42ee-8a7f-0961273cd625"), null, null, false, null, null, "Toán" },
                    { new Guid("ab091cc2-6f9a-4023-8003-2ca82076f5a4"), null, null, false, null, null, "Vật Lý" },
                    { new Guid("af6197e1-8fc6-4afe-9f63-6b4f426ad502"), null, null, false, null, null, "Sinh học" },
                    { new Guid("c0456f7f-1963-4598-8b7c-8f44bd7e2dbe"), null, null, false, null, null, "Ngữ Văn" },
                    { new Guid("d6d7fa5b-6578-46c3-bcd4-98c43d6d709c"), null, null, false, null, null, "Anh Văn" },
                    { new Guid("ffb7d37a-a980-4623-ad89-0c1e0a7de7de"), null, null, false, null, null, "Lịch Sử" }
                });

            migrationBuilder.InsertData(
                table: "University",
                columns: new[] { "Id", "Code", "CreatedBy", "CreatedDate", "Description", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("0e7c3b01-d954-4986-9d9d-f48127433211"), "HCMUE", null, null, "Trường đại học công lập đào tạo sư phạm lớn nhất Việt Nam", false, null, null, "Đại học Sư phạm Thành phố Hồ Chí Minh" },
                    { new Guid("6b70b92b-4201-4611-b6bb-716a5b3c4fec"), "UEH", null, null, "Trường đại học công lập đào tạo về kinh tế, tài chính, ngân hàng hàng đầu tại Việt Nam", false, null, null, "Đại học kinh tế TPHCM" },
                    { new Guid("b629e405-9aca-4c19-bbe3-f4a50d9cca62"), "UMP", null, null, "Trường đại học công lập đào tạo về y dược lớn nhất Việt Nam", false, null, null, "Đại học Y Dược Thành phố Hồ Chí Minh" },
                    { new Guid("cf30b5ef-1a8f-472f-af90-337a5cee4c16"), "UAH", null, null, "Trường đại học công lập đào tạo về kiến trúc hàng đầu Việt Nam", false, null, null, "Đại học Kiến trúc Thành phố Hồ Chí Minh" },
                    { new Guid("f84e78ea-4426-4728-a3f6-c41c3ed22072"), "FPT", null, null, "Trường đại học tư thục hàng đầu Việt Nam về công nghệ thông tin và truyền thông.", false, null, null, "Đại học FPT" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "CreatedBy", "Email", "FirstName", "HighestScore", "IsDeleted", "LastName", "ModifiedBy", "ModifiedDate", "PasswordHash", "PasswordSalt", "PhoneNumber", "Role", "UserName" },
                values: new object[,]
                {
                    { new Guid("09d2d924-8c18-4e49-bbc4-f67c0204d7af"), "Tran quoc toan", null, "student2@gmail.com", "Minh", 9, false, "Vu", null, null, new byte[] { 5, 232, 163, 226, 156, 238, 132, 243, 239, 156, 178, 197, 79, 217, 8, 54, 150, 81, 180, 192, 102, 27, 137, 202, 36, 147, 186, 89, 168, 250, 166, 232, 22, 21, 157, 40, 151, 11, 168, 149, 89, 185, 163, 77, 60, 80, 122, 250, 120, 111, 144, 73, 166, 75, 149, 19, 43, 22, 47, 193, 120, 87, 82, 122 }, new byte[] { 251, 126, 184, 215, 13, 148, 146, 16, 99, 91, 23, 58, 134, 213, 235, 114, 24, 148, 146, 181, 7, 194, 199, 3, 152, 49, 120, 31, 87, 179, 205, 151, 96, 61, 111, 238, 101, 211, 107, 89, 162, 224, 31, 185, 209, 179, 10, 51, 142, 30, 146, 86, 240, 17, 179, 72, 230, 137, 177, 250, 208, 145, 139, 227, 27, 72, 181, 190, 87, 196, 194, 162, 10, 153, 71, 88, 196, 46, 228, 126, 0, 198, 122, 147, 203, 189, 13, 83, 40, 242, 28, 92, 93, 244, 106, 233, 98, 73, 122, 147, 194, 249, 220, 250, 215, 97, 25, 112, 161, 47, 151, 31, 113, 137, 182, 97, 4, 31, 121, 199, 112, 243, 96, 18, 188, 202, 53, 47 }, "1234567890", 1, "student2" },
                    { new Guid("1a022b66-8b1c-461a-be8a-ec2a7b0741e9"), "Tran quoc toan", null, "student4@gmail.com", "Minh", 6, false, "Tam", null, null, new byte[] { 98, 7, 40, 19, 84, 24, 49, 155, 126, 216, 85, 17, 217, 116, 68, 44, 164, 150, 25, 102, 123, 102, 77, 56, 244, 107, 252, 32, 218, 33, 233, 249, 221, 186, 151, 55, 17, 107, 98, 180, 203, 171, 167, 73, 144, 215, 72, 50, 113, 114, 92, 218, 198, 93, 66, 97, 43, 157, 211, 146, 210, 127, 84, 141 }, new byte[] { 213, 187, 59, 67, 177, 252, 96, 35, 45, 251, 195, 21, 90, 24, 39, 92, 206, 41, 66, 14, 175, 222, 67, 27, 183, 24, 177, 220, 4, 190, 62, 29, 232, 8, 83, 141, 158, 200, 142, 53, 8, 251, 65, 194, 102, 157, 16, 15, 133, 158, 182, 32, 71, 41, 104, 193, 136, 33, 215, 68, 214, 128, 78, 228, 144, 238, 68, 146, 117, 208, 54, 190, 91, 54, 55, 157, 252, 0, 115, 73, 65, 98, 31, 12, 254, 171, 164, 211, 165, 176, 253, 69, 240, 156, 134, 97, 250, 117, 12, 153, 26, 3, 203, 185, 99, 23, 252, 49, 179, 255, 135, 211, 240, 152, 40, 219, 241, 98, 47, 83, 72, 184, 99, 175, 152, 173, 228, 171 }, "1234567890", 1, "student4" },
                    { new Guid("1eff27be-f2ea-4df7-93a5-33c7ba5e2d98"), "Tran quoc toan", null, "student15@gmail.com", "Trinh", 1, false, "Quan", null, null, new byte[] { 237, 162, 217, 221, 40, 109, 183, 136, 25, 250, 16, 188, 17, 40, 155, 128, 93, 255, 157, 150, 108, 232, 152, 244, 171, 182, 102, 182, 210, 8, 67, 231, 13, 207, 178, 197, 35, 195, 47, 91, 98, 68, 107, 55, 16, 103, 92, 11, 161, 27, 46, 64, 83, 179, 242, 199, 255, 220, 141, 216, 98, 75, 211, 60 }, new byte[] { 99, 164, 49, 216, 104, 166, 248, 65, 7, 17, 115, 246, 95, 187, 239, 217, 157, 222, 220, 170, 141, 243, 106, 177, 194, 213, 123, 161, 83, 167, 52, 70, 6, 52, 195, 231, 35, 104, 175, 78, 217, 28, 84, 118, 168, 11, 6, 44, 29, 199, 126, 215, 76, 85, 199, 235, 218, 144, 183, 166, 1, 209, 177, 75, 202, 68, 30, 168, 210, 68, 29, 189, 98, 254, 194, 130, 130, 26, 116, 37, 101, 205, 29, 172, 30, 183, 123, 252, 132, 250, 193, 147, 75, 247, 188, 71, 93, 89, 226, 182, 21, 72, 114, 96, 246, 48, 176, 124, 255, 219, 209, 226, 180, 253, 225, 45, 72, 103, 65, 25, 196, 213, 37, 56, 231, 217, 159, 120 }, "1234567890", 1, "student15" },
                    { new Guid("24d15338-310e-4d3d-9e39-86444fc0ddec"), "Tran quoc toan", null, "student14@gmail.com", "Cook", 1, false, "Lee", null, null, new byte[] { 9, 233, 143, 201, 4, 118, 234, 166, 213, 204, 4, 14, 173, 185, 25, 29, 219, 86, 9, 93, 50, 110, 24, 185, 186, 188, 186, 225, 142, 49, 100, 191, 130, 131, 97, 135, 254, 165, 250, 144, 16, 105, 151, 47, 76, 3, 176, 168, 248, 85, 163, 145, 206, 165, 221, 84, 147, 44, 106, 216, 222, 171, 78, 67 }, new byte[] { 230, 201, 246, 26, 11, 227, 151, 121, 39, 203, 13, 115, 188, 117, 83, 248, 9, 224, 255, 194, 129, 170, 163, 253, 118, 39, 210, 191, 140, 26, 234, 26, 103, 210, 76, 25, 116, 201, 197, 188, 30, 67, 100, 5, 214, 128, 54, 25, 97, 226, 255, 20, 137, 109, 172, 49, 45, 159, 251, 1, 166, 232, 189, 219, 103, 157, 149, 103, 182, 52, 248, 179, 161, 220, 23, 50, 11, 114, 11, 131, 30, 147, 52, 176, 88, 232, 63, 64, 245, 79, 109, 150, 173, 47, 2, 245, 33, 233, 128, 38, 4, 61, 161, 231, 103, 27, 104, 92, 144, 128, 72, 157, 134, 29, 19, 251, 246, 42, 116, 226, 53, 213, 231, 134, 146, 161, 161, 20 }, "1234567890", 1, "student14" },
                    { new Guid("312f4251-1f9f-4f80-b2ad-968fc339b134"), "Tran quoc toan", null, "student8@gmail.com", "Ly", 2, false, "Hung", null, null, new byte[] { 212, 218, 243, 194, 208, 90, 71, 251, 227, 83, 221, 41, 198, 254, 125, 172, 9, 187, 255, 121, 183, 175, 73, 243, 134, 27, 3, 144, 203, 221, 214, 134, 36, 15, 149, 182, 85, 110, 252, 104, 61, 201, 64, 200, 169, 155, 234, 66, 88, 99, 87, 255, 207, 98, 199, 12, 112, 95, 186, 121, 188, 155, 70, 183 }, new byte[] { 131, 130, 45, 38, 214, 195, 141, 30, 124, 164, 22, 99, 200, 177, 28, 121, 142, 150, 255, 106, 117, 111, 135, 50, 136, 167, 26, 53, 58, 222, 178, 74, 132, 105, 16, 62, 155, 187, 10, 206, 241, 48, 22, 44, 149, 190, 215, 189, 194, 200, 11, 61, 45, 16, 152, 242, 99, 141, 28, 245, 18, 78, 253, 94, 160, 252, 131, 152, 152, 107, 105, 174, 24, 211, 7, 228, 191, 129, 183, 185, 10, 23, 21, 128, 57, 132, 110, 220, 135, 212, 76, 172, 167, 9, 58, 191, 24, 202, 118, 198, 99, 122, 134, 235, 163, 23, 172, 246, 27, 231, 224, 182, 32, 86, 228, 119, 86, 16, 233, 24, 144, 54, 64, 21, 42, 26, 242, 15 }, "1234567890", 1, "student8" },
                    { new Guid("324ed66e-e8de-4710-a139-18c50b442945"), "Tran quoc toan", null, "student6@gmail.com", "Van", 4, false, "Ba", null, null, new byte[] { 106, 25, 167, 34, 223, 22, 208, 185, 108, 40, 59, 189, 112, 235, 2, 46, 49, 195, 229, 233, 11, 178, 247, 107, 65, 214, 250, 30, 85, 8, 247, 6, 2, 77, 246, 53, 206, 130, 196, 30, 191, 41, 216, 130, 53, 22, 99, 138, 243, 12, 74, 108, 173, 203, 0, 2, 91, 50, 40, 192, 198, 41, 71, 54 }, new byte[] { 164, 204, 49, 12, 234, 106, 238, 145, 228, 189, 231, 188, 4, 188, 51, 12, 164, 39, 70, 148, 36, 167, 110, 250, 89, 164, 21, 228, 14, 253, 110, 150, 80, 37, 112, 168, 195, 92, 98, 102, 183, 78, 26, 10, 112, 86, 154, 226, 76, 245, 201, 32, 101, 228, 231, 226, 127, 211, 240, 59, 152, 188, 150, 163, 7, 31, 100, 5, 176, 100, 237, 34, 7, 239, 29, 250, 79, 193, 129, 177, 121, 41, 52, 254, 144, 231, 190, 113, 213, 119, 99, 71, 19, 30, 74, 174, 97, 145, 180, 218, 210, 184, 61, 29, 226, 128, 251, 90, 65, 156, 132, 99, 113, 231, 118, 15, 115, 24, 212, 95, 144, 100, 19, 116, 65, 1, 76, 144 }, "1234567890", 1, "student6" },
                    { new Guid("4c5d8bb2-b66c-49e7-982b-685ed23d1be8"), "Tran quoc toan", null, "student5@gmail.com", "Trinh", 5, false, "Tam", null, null, new byte[] { 58, 83, 14, 163, 223, 172, 63, 110, 3, 243, 30, 61, 107, 230, 183, 157, 188, 251, 118, 228, 64, 218, 226, 8, 30, 73, 152, 34, 156, 135, 219, 88, 141, 54, 194, 15, 80, 182, 186, 235, 217, 7, 59, 226, 26, 253, 140, 15, 155, 84, 161, 223, 219, 78, 53, 132, 71, 19, 41, 158, 67, 183, 171, 151 }, new byte[] { 86, 86, 68, 206, 49, 40, 169, 88, 156, 200, 122, 111, 145, 26, 70, 39, 67, 137, 16, 69, 37, 147, 191, 26, 140, 103, 158, 218, 46, 196, 230, 125, 66, 18, 214, 112, 53, 62, 228, 243, 6, 1, 97, 24, 11, 48, 245, 131, 255, 205, 140, 122, 184, 181, 167, 139, 198, 255, 53, 216, 108, 197, 44, 92, 94, 54, 54, 29, 43, 201, 144, 114, 79, 245, 67, 244, 76, 22, 134, 244, 228, 244, 245, 235, 196, 54, 109, 193, 45, 138, 102, 7, 128, 167, 123, 217, 47, 142, 154, 201, 226, 55, 30, 157, 72, 144, 179, 222, 56, 43, 176, 145, 207, 37, 157, 66, 254, 107, 103, 43, 65, 241, 172, 185, 39, 109, 173, 253 }, "1234567890", 1, "student5" },
                    { new Guid("5b670b4c-a8dc-4cca-8d2b-0bb45d69a702"), "Tran quoc toan", null, "student17@gmail.com", "Kim", 1, false, "Trong", null, null, new byte[] { 228, 170, 103, 115, 27, 135, 148, 239, 87, 109, 127, 211, 246, 19, 60, 230, 234, 72, 255, 213, 12, 52, 122, 131, 91, 39, 18, 100, 19, 186, 68, 52, 80, 219, 1, 213, 179, 197, 106, 88, 43, 219, 17, 159, 12, 163, 110, 28, 87, 177, 59, 14, 204, 162, 179, 40, 64, 105, 192, 107, 87, 205, 206, 78 }, new byte[] { 207, 22, 201, 136, 85, 24, 64, 125, 213, 191, 216, 24, 39, 113, 204, 39, 133, 100, 218, 23, 125, 67, 3, 138, 45, 11, 227, 223, 110, 176, 4, 201, 58, 33, 157, 232, 114, 46, 97, 90, 186, 31, 131, 96, 227, 168, 198, 153, 140, 57, 110, 157, 233, 41, 78, 159, 6, 133, 191, 112, 116, 2, 139, 157, 190, 144, 89, 94, 209, 217, 143, 252, 69, 228, 125, 96, 165, 197, 249, 118, 232, 11, 187, 15, 74, 230, 38, 248, 249, 126, 194, 88, 169, 112, 151, 139, 54, 93, 66, 91, 219, 95, 138, 24, 214, 74, 212, 136, 83, 173, 173, 242, 147, 65, 232, 34, 157, 38, 14, 134, 150, 178, 23, 31, 171, 246, 226, 63 }, "1234567890", 1, "student17" },
                    { new Guid("5ddbd197-9ac9-42fb-bdfe-dee7dbe35efd"), "Tran quoc toan", null, "student2@gmail.com", "Minh", 6, false, "Duc", null, null, new byte[] { 75, 45, 214, 69, 73, 253, 35, 31, 102, 144, 204, 52, 142, 253, 29, 16, 102, 55, 160, 94, 247, 10, 147, 245, 12, 69, 252, 114, 214, 32, 165, 3, 36, 53, 153, 176, 142, 191, 5, 12, 47, 76, 129, 32, 235, 234, 241, 59, 82, 135, 167, 255, 228, 11, 141, 10, 45, 230, 103, 174, 91, 173, 203, 186 }, new byte[] { 23, 177, 15, 8, 189, 234, 108, 183, 112, 210, 136, 22, 0, 55, 114, 81, 121, 77, 247, 117, 169, 166, 105, 152, 68, 136, 228, 53, 132, 189, 146, 61, 101, 115, 189, 4, 105, 5, 169, 126, 91, 154, 216, 127, 198, 57, 203, 126, 204, 228, 213, 22, 30, 159, 203, 212, 32, 158, 243, 171, 25, 227, 167, 8, 241, 10, 203, 219, 11, 7, 95, 220, 252, 135, 254, 106, 45, 74, 88, 195, 155, 147, 206, 212, 106, 181, 29, 122, 145, 69, 239, 64, 131, 98, 106, 199, 169, 189, 141, 183, 118, 110, 116, 219, 30, 87, 0, 171, 145, 18, 6, 140, 51, 194, 205, 117, 180, 141, 250, 129, 222, 99, 142, 4, 100, 229, 183, 64 }, "1234567890", 1, "student2" },
                    { new Guid("666bc14a-4078-4619-85f1-bc63033c556f"), "Tran quoc toan", null, "student19@gmail.com", "Cach", 2, false, "Ly", null, null, new byte[] { 226, 124, 86, 141, 232, 193, 146, 201, 194, 34, 56, 61, 150, 162, 21, 186, 1, 220, 58, 89, 190, 81, 84, 189, 83, 205, 7, 83, 94, 254, 198, 250, 77, 205, 190, 104, 161, 171, 211, 66, 199, 33, 59, 143, 187, 156, 184, 181, 39, 190, 38, 103, 187, 114, 100, 188, 128, 75, 26, 243, 34, 139, 38, 98 }, new byte[] { 73, 95, 55, 75, 169, 220, 47, 172, 15, 175, 45, 99, 204, 38, 7, 216, 82, 197, 39, 67, 121, 40, 177, 69, 169, 43, 229, 139, 107, 13, 75, 120, 46, 255, 19, 15, 110, 2, 33, 254, 173, 53, 17, 128, 253, 135, 40, 187, 183, 31, 246, 8, 135, 118, 188, 166, 225, 253, 164, 198, 150, 100, 37, 125, 224, 53, 182, 46, 102, 69, 121, 244, 26, 12, 229, 80, 234, 185, 150, 65, 252, 245, 120, 108, 70, 209, 218, 67, 223, 76, 8, 241, 119, 175, 178, 230, 123, 4, 88, 167, 97, 20, 96, 214, 58, 126, 3, 17, 126, 217, 18, 22, 96, 159, 146, 214, 78, 31, 189, 61, 13, 67, 84, 33, 239, 76, 102, 18 }, "1234567890", 1, "student19" },
                    { new Guid("6d6ad990-1ff2-445b-8496-d766048e25cf"), "Tran quoc toan", null, "student11@gmail.com", "Nhan", 10, false, "Hong", null, null, new byte[] { 170, 25, 45, 113, 145, 3, 239, 197, 135, 7, 61, 57, 223, 38, 116, 252, 95, 108, 108, 68, 173, 61, 158, 199, 221, 141, 25, 169, 19, 147, 116, 3, 165, 62, 68, 190, 196, 138, 193, 13, 184, 149, 81, 205, 200, 117, 51, 166, 196, 157, 89, 244, 249, 15, 136, 216, 126, 44, 3, 246, 190, 116, 162, 116 }, new byte[] { 177, 245, 248, 113, 55, 132, 121, 135, 77, 249, 41, 75, 26, 71, 110, 52, 69, 131, 205, 32, 121, 181, 103, 145, 25, 213, 161, 41, 12, 201, 240, 216, 231, 44, 117, 2, 235, 94, 206, 75, 15, 8, 197, 131, 121, 162, 33, 113, 147, 150, 183, 231, 93, 54, 186, 130, 196, 222, 91, 110, 10, 232, 233, 232, 176, 65, 15, 107, 4, 36, 94, 39, 11, 229, 124, 78, 192, 105, 37, 244, 111, 155, 229, 166, 102, 174, 25, 229, 107, 170, 49, 107, 198, 141, 111, 191, 170, 145, 157, 177, 108, 143, 47, 167, 22, 167, 114, 241, 52, 121, 113, 160, 225, 39, 190, 90, 187, 139, 255, 73, 235, 89, 120, 250, 129, 133, 210, 12 }, "1234567890", 1, "student11" },
                    { new Guid("84a7c64a-feed-4fb2-8b1e-24e10aa382b2"), "Tran quoc toan", null, "student9@gmail.com", "Ly", 1, false, "Lac", null, null, new byte[] { 205, 195, 78, 130, 22, 40, 219, 96, 1, 196, 179, 147, 77, 48, 233, 212, 241, 208, 179, 121, 119, 106, 3, 175, 108, 101, 201, 251, 229, 48, 33, 65, 73, 198, 35, 12, 148, 90, 159, 186, 178, 222, 223, 153, 59, 224, 26, 10, 187, 106, 59, 199, 191, 255, 9, 212, 19, 246, 25, 116, 26, 145, 166, 145 }, new byte[] { 46, 82, 233, 128, 30, 99, 104, 30, 99, 13, 169, 93, 111, 60, 130, 208, 190, 156, 154, 203, 52, 127, 109, 71, 199, 103, 137, 137, 168, 132, 232, 240, 193, 237, 36, 30, 123, 24, 47, 106, 109, 172, 232, 10, 234, 45, 244, 37, 26, 200, 211, 4, 235, 229, 190, 172, 221, 9, 43, 217, 214, 109, 197, 125, 167, 0, 40, 208, 132, 155, 158, 186, 186, 131, 0, 21, 224, 169, 221, 199, 44, 35, 224, 71, 100, 100, 119, 111, 57, 172, 214, 95, 199, 251, 122, 207, 6, 50, 38, 171, 72, 21, 128, 175, 211, 220, 128, 2, 55, 226, 80, 27, 146, 245, 88, 6, 200, 78, 240, 120, 250, 16, 144, 242, 128, 19, 212, 192 }, "1234567890", 1, "student9" },
                    { new Guid("8f744e72-da12-4038-a54e-7512a0ada884"), "Tran quoc toan", null, "student13@gmail.com", "Huan", 8, false, "Hoe", null, null, new byte[] { 222, 130, 151, 38, 164, 106, 255, 196, 174, 183, 42, 121, 220, 196, 1, 130, 172, 60, 64, 141, 226, 103, 141, 241, 113, 238, 131, 132, 201, 205, 181, 178, 78, 133, 15, 52, 210, 147, 252, 251, 156, 171, 77, 186, 206, 84, 59, 174, 115, 225, 249, 165, 11, 56, 50, 142, 39, 234, 103, 104, 161, 17, 141, 239 }, new byte[] { 142, 11, 93, 230, 114, 199, 113, 18, 244, 115, 0, 108, 251, 219, 193, 253, 89, 152, 208, 131, 176, 179, 1, 192, 143, 107, 226, 161, 167, 207, 10, 144, 16, 129, 226, 59, 141, 139, 241, 217, 28, 242, 2, 75, 97, 203, 230, 160, 137, 132, 144, 222, 60, 151, 86, 254, 142, 130, 151, 150, 1, 14, 231, 157, 59, 154, 35, 34, 82, 10, 47, 45, 42, 153, 197, 41, 173, 79, 126, 117, 128, 36, 178, 64, 42, 181, 36, 170, 43, 143, 140, 162, 172, 194, 103, 47, 65, 137, 100, 43, 88, 47, 167, 11, 168, 56, 227, 115, 190, 187, 82, 58, 3, 166, 221, 104, 223, 46, 247, 222, 141, 3, 228, 144, 203, 24, 5, 14 }, "1234567890", 1, "student13" },
                    { new Guid("96e0097f-ce73-4950-8ee2-89b313581154"), "Tran quoc toan", null, "student20@gmail.com", "Biet", 3, false, "Ly", null, null, new byte[] { 126, 117, 236, 71, 136, 166, 172, 251, 144, 142, 85, 238, 214, 203, 91, 94, 185, 146, 9, 67, 143, 83, 90, 170, 137, 64, 211, 68, 100, 67, 66, 98, 233, 54, 173, 22, 83, 239, 156, 66, 31, 240, 237, 73, 249, 158, 82, 36, 122, 143, 196, 147, 172, 211, 47, 87, 121, 182, 232, 247, 28, 110, 81, 187 }, new byte[] { 28, 224, 203, 101, 60, 20, 112, 163, 224, 254, 36, 209, 146, 166, 162, 152, 127, 114, 101, 214, 94, 181, 197, 33, 171, 216, 117, 41, 210, 7, 145, 82, 239, 68, 239, 61, 179, 107, 251, 114, 3, 185, 204, 219, 83, 55, 228, 58, 56, 143, 24, 136, 157, 60, 108, 63, 214, 248, 206, 3, 238, 34, 109, 75, 218, 197, 234, 17, 208, 50, 159, 234, 156, 91, 218, 212, 181, 128, 140, 183, 84, 0, 229, 231, 154, 67, 155, 232, 156, 5, 83, 7, 0, 201, 81, 219, 154, 7, 23, 102, 156, 211, 146, 238, 101, 57, 85, 191, 42, 86, 144, 87, 118, 222, 213, 27, 51, 62, 42, 57, 126, 45, 40, 172, 10, 141, 182, 246 }, "1234567890", 1, "student20" },
                    { new Guid("99c5faa8-d3fe-45b3-a871-86117ef93111"), "Tran quoc toan", null, "student16@gmail.com", "Trinh", 5, false, "Trong", null, null, new byte[] { 183, 19, 5, 71, 22, 36, 224, 165, 26, 175, 80, 113, 81, 127, 248, 46, 124, 54, 200, 123, 158, 61, 208, 22, 237, 136, 185, 18, 117, 25, 188, 63, 94, 7, 251, 46, 17, 183, 217, 189, 133, 192, 105, 22, 30, 218, 252, 57, 208, 167, 198, 37, 152, 220, 44, 5, 104, 34, 77, 107, 166, 70, 167, 181 }, new byte[] { 133, 224, 79, 220, 19, 11, 148, 218, 13, 102, 139, 39, 53, 199, 127, 251, 105, 25, 225, 108, 148, 91, 14, 4, 226, 26, 55, 198, 94, 242, 61, 103, 30, 227, 247, 39, 103, 115, 184, 160, 243, 108, 174, 201, 90, 54, 89, 159, 127, 37, 74, 217, 62, 10, 27, 14, 194, 112, 128, 14, 230, 71, 159, 181, 127, 23, 165, 170, 63, 177, 202, 52, 8, 169, 230, 31, 156, 155, 2, 146, 244, 112, 124, 132, 46, 62, 252, 36, 164, 216, 38, 254, 46, 250, 251, 176, 195, 244, 226, 230, 131, 66, 171, 22, 156, 229, 123, 93, 197, 198, 34, 111, 171, 118, 191, 53, 75, 221, 91, 243, 219, 177, 153, 49, 151, 255, 30, 76 }, "1234567890", 1, "student16" },
                    { new Guid("a6be20e2-5927-4cce-bed4-258f919f82e6"), "tran quoc toan", null, "admin@gmail.com", "admin", null, false, "admin", null, null, new byte[] { 180, 66, 61, 83, 197, 81, 135, 240, 132, 230, 146, 87, 219, 217, 181, 40, 209, 210, 146, 36, 98, 188, 105, 109, 22, 221, 211, 221, 100, 68, 44, 53, 242, 221, 170, 158, 212, 190, 146, 218, 123, 222, 230, 99, 0, 57, 162, 104, 68, 152, 172, 102, 159, 199, 145, 189, 49, 182, 251, 125, 188, 254, 53, 8 }, new byte[] { 95, 132, 119, 189, 149, 149, 136, 153, 115, 59, 9, 184, 75, 214, 93, 19, 228, 212, 253, 106, 131, 170, 153, 61, 69, 206, 235, 124, 40, 189, 159, 248, 6, 224, 206, 155, 116, 154, 158, 206, 127, 93, 65, 49, 186, 42, 51, 142, 86, 204, 127, 254, 18, 172, 38, 227, 234, 236, 254, 42, 149, 5, 216, 17, 102, 55, 133, 130, 216, 254, 112, 210, 135, 131, 32, 144, 233, 42, 183, 39, 245, 66, 171, 93, 178, 45, 9, 208, 184, 67, 248, 239, 16, 182, 19, 69, 165, 110, 225, 30, 23, 53, 235, 184, 68, 46, 189, 82, 186, 35, 46, 70, 21, 215, 235, 167, 34, 205, 204, 42, 165, 164, 12, 148, 1, 207, 107, 38 }, "1234567890", 0, "admin" },
                    { new Guid("c30d316f-9c93-42c9-8e72-0b3efa896192"), "Tran quoc toan", null, "student18@gmail.com", "Kim", 10, false, "Ly", null, null, new byte[] { 253, 34, 169, 42, 136, 144, 245, 42, 63, 143, 47, 3, 205, 47, 96, 168, 28, 70, 66, 119, 217, 10, 104, 41, 55, 39, 142, 249, 176, 101, 155, 41, 239, 194, 235, 97, 6, 22, 209, 151, 10, 219, 116, 31, 164, 155, 219, 9, 172, 149, 1, 184, 183, 52, 0, 178, 217, 156, 134, 13, 96, 182, 92, 72 }, new byte[] { 157, 236, 252, 169, 253, 227, 224, 42, 13, 65, 194, 116, 161, 200, 112, 221, 82, 111, 61, 173, 129, 187, 181, 77, 200, 112, 220, 178, 30, 243, 58, 226, 79, 121, 104, 250, 118, 160, 111, 45, 137, 203, 74, 51, 28, 205, 202, 103, 100, 78, 218, 110, 4, 121, 91, 131, 158, 177, 64, 10, 176, 94, 42, 178, 89, 227, 39, 68, 152, 13, 140, 31, 19, 225, 191, 112, 177, 54, 149, 213, 81, 178, 179, 176, 171, 65, 159, 229, 112, 65, 207, 120, 219, 146, 144, 54, 205, 243, 193, 0, 29, 133, 128, 235, 152, 193, 157, 173, 42, 122, 155, 97, 104, 132, 104, 0, 247, 26, 14, 195, 206, 55, 70, 129, 215, 242, 207, 205 }, "1234567890", 1, "student18" },
                    { new Guid("c5eacfa9-ec87-4150-bedc-ca141458b5a3"), "Tran quoc toan", null, "student21@gmail.com", "Bien", 4, false, "Ly", null, null, new byte[] { 157, 11, 84, 151, 65, 22, 124, 247, 112, 2, 143, 91, 216, 214, 77, 98, 92, 51, 13, 192, 62, 54, 97, 234, 46, 250, 222, 169, 77, 52, 164, 100, 223, 170, 7, 212, 216, 24, 95, 86, 32, 191, 100, 135, 215, 150, 164, 178, 168, 97, 14, 204, 106, 242, 185, 203, 50, 138, 124, 14, 150, 86, 155, 59 }, new byte[] { 210, 249, 16, 159, 66, 12, 52, 122, 221, 69, 246, 13, 38, 73, 248, 227, 125, 24, 87, 246, 125, 40, 242, 8, 39, 1, 108, 56, 130, 198, 120, 88, 109, 32, 237, 184, 130, 68, 5, 125, 176, 179, 45, 236, 202, 247, 75, 162, 248, 255, 35, 4, 70, 195, 47, 103, 24, 118, 169, 158, 28, 122, 138, 87, 124, 80, 120, 78, 162, 17, 204, 170, 229, 42, 100, 82, 57, 248, 211, 181, 160, 2, 119, 207, 28, 107, 116, 23, 134, 196, 198, 25, 170, 129, 119, 35, 54, 172, 145, 231, 201, 250, 70, 178, 202, 221, 166, 235, 184, 140, 236, 60, 95, 186, 113, 14, 117, 158, 8, 111, 89, 243, 230, 32, 44, 100, 59, 92 }, "1234567890", 1, "student21" },
                    { new Guid("cb235a17-fd24-48cf-ba34-ac5ac698a832"), "Tran quoc toan", null, "student10@gmail.com", "Tran", 9, false, "Hong", null, null, new byte[] { 189, 110, 232, 7, 3, 67, 234, 240, 246, 41, 31, 160, 83, 158, 4, 115, 95, 207, 127, 128, 94, 1, 246, 192, 104, 214, 169, 3, 107, 95, 186, 165, 123, 240, 87, 62, 155, 50, 27, 129, 41, 241, 128, 29, 91, 185, 227, 118, 208, 176, 148, 131, 108, 160, 118, 151, 140, 211, 78, 7, 227, 147, 21, 30 }, new byte[] { 177, 212, 213, 40, 124, 59, 3, 235, 59, 153, 75, 78, 226, 250, 39, 149, 60, 160, 210, 206, 191, 191, 115, 136, 53, 164, 5, 133, 20, 139, 211, 93, 22, 202, 12, 27, 84, 237, 123, 190, 78, 125, 164, 193, 242, 235, 200, 18, 247, 132, 110, 164, 181, 50, 78, 76, 62, 105, 238, 60, 19, 19, 189, 244, 202, 70, 99, 224, 131, 108, 247, 33, 31, 78, 238, 212, 205, 203, 156, 166, 252, 137, 201, 186, 19, 117, 141, 232, 219, 60, 222, 166, 13, 227, 214, 182, 20, 194, 108, 7, 245, 30, 97, 7, 129, 163, 29, 75, 4, 44, 213, 203, 17, 234, 206, 191, 53, 100, 224, 5, 164, 9, 144, 239, 53, 98, 156, 121 }, "1234567890", 1, "student10" },
                    { new Guid("d406be20-d364-43c5-84bf-4d3e3be43ae0"), "Tran quoc toan", null, "student7@gmail.com", "Van", 3, false, "Hung", null, null, new byte[] { 20, 240, 37, 240, 157, 168, 81, 152, 167, 11, 12, 230, 45, 192, 84, 203, 176, 232, 166, 232, 241, 28, 93, 8, 65, 226, 88, 41, 133, 54, 104, 19, 224, 114, 224, 14, 165, 129, 212, 73, 14, 199, 201, 87, 37, 10, 11, 147, 53, 16, 102, 203, 236, 13, 16, 137, 186, 223, 34, 202, 147, 1, 244, 181 }, new byte[] { 195, 66, 106, 194, 90, 168, 66, 44, 90, 254, 55, 145, 48, 152, 147, 253, 244, 154, 185, 200, 232, 49, 39, 251, 239, 81, 67, 117, 132, 186, 175, 65, 109, 140, 104, 98, 169, 7, 80, 21, 231, 28, 126, 207, 32, 252, 72, 175, 95, 146, 176, 38, 39, 217, 153, 121, 200, 15, 3, 114, 83, 230, 239, 60, 108, 44, 79, 121, 223, 210, 175, 45, 182, 15, 234, 151, 32, 161, 32, 79, 202, 57, 123, 157, 133, 188, 222, 251, 28, 253, 89, 150, 70, 102, 215, 138, 84, 17, 148, 250, 31, 71, 231, 72, 88, 178, 224, 171, 198, 65, 89, 108, 145, 21, 158, 153, 94, 237, 221, 147, 49, 101, 210, 210, 45, 244, 209, 28 }, "1234567890", 1, "student7" },
                    { new Guid("e798134f-8d1b-41aa-98c1-c8914240366d"), "Tran quoc toan", null, "student12@gmail.com", "Nhan", 7, false, "Chia", null, null, new byte[] { 197, 190, 228, 216, 181, 77, 165, 16, 16, 83, 112, 191, 75, 44, 40, 105, 28, 59, 174, 128, 16, 74, 150, 194, 55, 106, 176, 232, 82, 249, 110, 209, 234, 199, 15, 142, 201, 79, 101, 37, 56, 95, 87, 123, 59, 80, 203, 161, 33, 200, 146, 163, 49, 236, 252, 153, 71, 135, 131, 36, 147, 70, 228, 158 }, new byte[] { 49, 208, 175, 16, 178, 235, 74, 60, 200, 227, 13, 114, 243, 214, 138, 243, 57, 254, 135, 142, 130, 220, 139, 229, 3, 76, 51, 90, 209, 140, 162, 117, 241, 196, 25, 205, 19, 84, 107, 147, 91, 203, 44, 27, 95, 59, 69, 50, 116, 115, 160, 232, 97, 147, 205, 234, 148, 150, 57, 35, 11, 231, 30, 231, 153, 103, 67, 112, 66, 121, 24, 28, 16, 222, 134, 129, 84, 58, 71, 148, 214, 101, 232, 30, 98, 96, 182, 227, 61, 130, 1, 175, 174, 236, 2, 7, 52, 112, 69, 200, 17, 166, 194, 226, 98, 95, 175, 191, 125, 184, 223, 203, 174, 242, 54, 177, 59, 93, 186, 153, 120, 254, 160, 214, 48, 0, 217, 22 }, "1234567890", 1, "student12" },
                    { new Guid("f0b84747-fbed-43e1-9cd1-ecf2e1bd3cc0"), "Tran quoc toan", null, "student@gmail.com", "Nguyen", 10, false, "Vu", null, null, new byte[] { 106, 188, 178, 75, 201, 50, 184, 25, 21, 170, 234, 143, 180, 49, 71, 105, 56, 141, 208, 81, 104, 4, 2, 207, 14, 241, 107, 224, 171, 197, 249, 183, 236, 44, 67, 3, 3, 61, 131, 135, 85, 43, 233, 102, 94, 61, 81, 97, 194, 9, 124, 234, 104, 2, 212, 106, 248, 156, 93, 125, 252, 74, 204, 245 }, new byte[] { 26, 145, 146, 195, 154, 39, 82, 35, 5, 197, 230, 156, 142, 211, 105, 24, 205, 45, 181, 17, 235, 246, 229, 223, 181, 236, 226, 45, 48, 148, 42, 217, 179, 232, 204, 19, 164, 202, 58, 109, 52, 46, 252, 157, 135, 117, 75, 121, 19, 248, 170, 177, 115, 60, 175, 220, 194, 51, 97, 183, 187, 93, 189, 17, 168, 92, 45, 197, 199, 249, 172, 107, 7, 187, 172, 233, 196, 255, 224, 253, 178, 80, 59, 55, 197, 18, 70, 108, 40, 232, 81, 230, 179, 40, 176, 81, 74, 181, 54, 41, 188, 106, 205, 66, 51, 46, 174, 77, 211, 79, 17, 217, 235, 115, 195, 139, 216, 168, 6, 224, 210, 0, 120, 42, 244, 159, 7, 11 }, "1234567890", 1, "student1" },
                    { new Guid("f2dbff0f-0ccb-4cc3-91e3-d068431af710"), "Tran quoc toan", null, "student3@gmail.com", "Minh", 7, false, "Quan", null, null, new byte[] { 69, 42, 146, 63, 86, 119, 248, 43, 226, 15, 20, 60, 30, 62, 164, 103, 119, 233, 142, 13, 199, 202, 106, 140, 33, 76, 7, 119, 70, 79, 118, 227, 215, 10, 228, 222, 160, 207, 157, 180, 198, 145, 53, 197, 233, 131, 174, 121, 115, 197, 162, 234, 52, 128, 220, 197, 13, 156, 22, 53, 96, 132, 139, 136 }, new byte[] { 96, 227, 242, 160, 32, 34, 244, 59, 212, 230, 61, 50, 18, 225, 194, 17, 53, 25, 70, 112, 183, 218, 72, 52, 196, 43, 93, 201, 41, 179, 155, 9, 62, 103, 12, 23, 181, 176, 151, 21, 2, 7, 135, 127, 91, 70, 78, 254, 187, 200, 80, 96, 146, 39, 39, 172, 234, 8, 17, 194, 183, 15, 8, 226, 39, 17, 151, 242, 148, 102, 106, 5, 202, 130, 35, 62, 72, 139, 48, 106, 55, 225, 99, 100, 58, 56, 172, 104, 66, 135, 47, 161, 133, 71, 118, 157, 168, 152, 166, 148, 72, 126, 113, 141, 60, 134, 159, 35, 187, 102, 221, 57, 201, 87, 34, 105, 35, 241, 108, 94, 142, 192, 212, 216, 1, 101, 194, 111 }, "1234567890", 1, "student3" }
                });

            migrationBuilder.InsertData(
                table: "Attempts",
                columns: new[] { "Id", "AttempType", "CreatedBy", "CreatedDate", "ExamDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name", "Result", "Score", "UserId" },
                values: new object[] { new Guid("9b8daa9f-7f8c-41d9-aa34-ba2b1010f4ed"), 0, null, new DateTime(2023, 11, 29, 15, 4, 12, 870, DateTimeKind.Utc).AddTicks(8630), new DateTime(2023, 11, 30, 15, 4, 12, 870, DateTimeKind.Utc).AddTicks(8633), false, null, null, "bai kiem tra kien thuc xa hoi", "Pass", 10, new Guid("f0b84747-fbed-43e1-9cd1-ecf2e1bd3cc0") });

            migrationBuilder.InsertData(
                table: "GroupDepartments",
                columns: new[] { "DepartmentId", "GroupId" },
                values: new object[,]
                {
                    { new Guid("4c7c3b5f-2a54-42ee-8a7f-0961273cd329"), new Guid("632ba05a-9ed9-4a00-9ac8-e1c642919806") },
                    { new Guid("4c7c3b5f-2a54-42ee-8a7f-0961273cd329"), new Guid("f5e0affd-9745-4859-8171-77b99fc725c1") },
                    { new Guid("5fbe7741-917c-45f5-8f78-c06327ede146"), new Guid("09f798c3-4d01-437f-b361-bf230efd7ddf") },
                    { new Guid("67d181a2-ac85-4aaa-bcad-863b8695071b"), new Guid("09f798c3-4d01-437f-b361-bf230efd7ddf") },
                    { new Guid("67d181a2-ac85-4aaa-bcad-863b8695071b"), new Guid("dab75dab-d28c-45ad-98a6-b3f25dec3ad0") },
                    { new Guid("67d181a2-ac85-4aaa-bcad-863b8695071b"), new Guid("f5e0affd-9745-4859-8171-77b99fc725c1") },
                    { new Guid("b8034210-23fd-4af9-9d7f-f260a0cdef97"), new Guid("09f798c3-4d01-437f-b361-bf230efd7ddf") },
                    { new Guid("b8034210-23fd-4af9-9d7f-f260a0cdef97"), new Guid("f5e0affd-9745-4859-8171-77b99fc725c1") },
                    { new Guid("bb3a10db-c4d4-4b45-9d15-0c38f41e8f5f"), new Guid("20bbb66d-3117-4050-ae30-4caf85831530") },
                    { new Guid("bb3a10db-c4d4-4b45-9d15-0c38f41e8f5f"), new Guid("b8de514a-7bba-4b8b-bae1-fc36c07ed52b") },
                    { new Guid("de305d54-75b4-431b-adb2-eb6b9e546013"), new Guid("09f798c3-4d01-437f-b361-bf230efd7ddf") },
                    { new Guid("de305d54-75b4-431b-adb2-eb6b9e546013"), new Guid("f5e0affd-9745-4859-8171-77b99fc725c1") },
                    { new Guid("e35d862c-1f43-456b-a60b-1b2c7e44ab78"), new Guid("09f798c3-4d01-437f-b361-bf230efd7ddf") },
                    { new Guid("e35d862c-1f43-456b-a60b-1b2c7e44ab78"), new Guid("632ba05a-9ed9-4a00-9ac8-e1c642919806") },
                    { new Guid("e35d862c-1f43-456b-a60b-1b2c7e44ab78"), new Guid("dab75dab-d28c-45ad-98a6-b3f25dec3ad0") },
                    { new Guid("e35d862c-1f43-456b-a60b-1b2c7e44ab78"), new Guid("f5e0affd-9745-4859-8171-77b99fc725c1") },
                    { new Guid("f9cf3140-b872-4837-b965-d37f94e33c0b"), new Guid("09f798c3-4d01-437f-b361-bf230efd7ddf") },
                    { new Guid("f9cf3140-b872-4837-b965-d37f94e33c0b"), new Guid("dab75dab-d28c-45ad-98a6-b3f25dec3ad0") },
                    { new Guid("f9cf3140-b872-4837-b965-d37f94e33c0b"), new Guid("f5e0affd-9745-4859-8171-77b99fc725c1") }
                });

            migrationBuilder.InsertData(
                table: "MBTI_Department",
                columns: new[] { "DepartmentId", "MBTI_Id" },
                values: new object[,]
                {
                    { new Guid("bb3a10db-c4d4-4b45-9d15-0c38f41e8f5f"), 2 },
                    { new Guid("de305d54-75b4-431b-adb2-eb6b9e546013"), 2 },
                    { new Guid("4c7c3b5f-2a54-42ee-8a7f-0961273cd329"), 9 }
                });

            migrationBuilder.InsertData(
                table: "MBTI_ExamQuestions",
                columns: new[] { "Id", "ExamId", "QuestionId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 2 },
                    { 3, 1, 3 },
                    { 4, 1, 4 },
                    { 5, 1, 5 },
                    { 6, 1, 6 },
                    { 7, 1, 7 },
                    { 8, 1, 8 },
                    { 9, 1, 9 },
                    { 10, 1, 10 },
                    { 11, 1, 11 },
                    { 12, 1, 12 }
                });

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "CreatedBy", "Description", "Index", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name", "SubjectId" },
                values: new object[,]
                {
                    { new Guid("25b3ba1e-240a-4a3c-96b6-c0816b0a3975"), null, "Toan hinh", 2, false, null, null, "toan hinh", new Guid("6a8c8d5f-2a54-42ee-8a7f-0961273cd625") },
                    { new Guid("f722c143-412c-4721-bf5c-5b32a01d90da"), null, "toan dai cuong", 1, false, null, null, "toan dai cuong", new Guid("6a8c8d5f-2a54-42ee-8a7f-0961273cd625") }
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Content", "CreatedBy", "IsDeleted", "ModifiedBy", "ModifiedDate", "TopicId" },
                values: new object[,]
                {
                    { new Guid("21eb2451-53ac-44f6-9a6c-751d394a8936"), "{\"Question\":\"Which cities are in the United Kingdom?\",\"ListAnswer\":[{\"Value\":\"London\",\"IsAnswer\":true},{\"Value\":\"Manchester\",\"IsAnswer\":false},{\"Value\":\"Edinburgh\",\"IsAnswer\":true}]}", null, false, null, null, new Guid("f722c143-412c-4721-bf5c-5b32a01d90da") },
                    { new Guid("238f27e2-fe56-4ce8-88f8-d3aa7b56f976"), "{\"Question\":\"What is the capital of France?\",\"ListAnswer\":[{\"Value\":\"Paris\",\"IsAnswer\":true},{\"Value\":\"London\",\"IsAnswer\":false},{\"Value\":\"Berlin\",\"IsAnswer\":false}]}", null, false, null, null, new Guid("f722c143-412c-4721-bf5c-5b32a01d90da") },
                    { new Guid("3e28911a-1220-4c7f-a1c6-bcce0b74ccfe"), "{\"Question\":\"When was the Declaration of Independence signed?\",\"ListAnswer\":[{\"Value\":\"1776-07-04\",\"IsAnswer\":true},{\"Value\":\"1789-09-25\",\"IsAnswer\":false},{\"Value\":\"1800-03-12\",\"IsAnswer\":false}]}", null, false, null, null, new Guid("f722c143-412c-4721-bf5c-5b32a01d90da") },
                    { new Guid("85e5d51b-16c7-4d0d-8f40-766a6a902698"), "{\"Question\":\"How many continents are there?\",\"ListAnswer\":[{\"Value\":\"7\",\"IsAnswer\":true},{\"Value\":\"5\",\"IsAnswer\":false},{\"Value\":\"6\",\"IsAnswer\":false}]}", null, false, null, null, new Guid("f722c143-412c-4721-bf5c-5b32a01d90da") }
                });

            migrationBuilder.InsertData(
                table: "ExaminationQuestions",
                columns: new[] { "Id", "CreatedBy", "ExaminationId", "IsDeleted", "ModifiedBy", "ModifiedDate", "QuestionId" },
                values: new object[,]
                {
                    { new Guid("046b0f97-130a-48c7-b1ad-40033ae41fff"), null, new Guid("ad0080ef-ac58-450b-b086-bc7f856c1fec"), false, null, null, new Guid("85e5d51b-16c7-4d0d-8f40-766a6a902698") },
                    { new Guid("139c3a57-af40-4c80-96fc-508957db3780"), null, new Guid("ad0080ef-ac58-450b-b086-bc7f856c1fec"), false, null, null, new Guid("21eb2451-53ac-44f6-9a6c-751d394a8936") },
                    { new Guid("2339983b-33db-4333-9b1b-a5514faa280a"), null, new Guid("ad0080ef-ac58-450b-b086-bc7f856c1fec"), false, null, null, new Guid("3e28911a-1220-4c7f-a1c6-bcce0b74ccfe") },
                    { new Guid("ad0080ef-ac58-450b-b086-bc7f856c1fec"), null, new Guid("ad0080ef-ac58-450b-b086-bc7f856c1fec"), false, null, null, new Guid("238f27e2-fe56-4ce8-88f8-d3aa7b56f976") }
                });

            migrationBuilder.InsertData(
                table: "AttemptDetails",
                columns: new[] { "AttemptId", "ExaminationQuestionId", "IsCorrect", "UserAnswered" },
                values: new object[,]
                {
                    { new Guid("9b8daa9f-7f8c-41d9-aa34-ba2b1010f4ed"), new Guid("046b0f97-130a-48c7-b1ad-40033ae41fff"), true, "7" },
                    { new Guid("9b8daa9f-7f8c-41d9-aa34-ba2b1010f4ed"), new Guid("139c3a57-af40-4c80-96fc-508957db3780"), true, "London" },
                    { new Guid("9b8daa9f-7f8c-41d9-aa34-ba2b1010f4ed"), new Guid("2339983b-33db-4333-9b1b-a5514faa280a"), true, "1776-07-04" },
                    { new Guid("9b8daa9f-7f8c-41d9-aa34-ba2b1010f4ed"), new Guid("ad0080ef-ac58-450b-b086-bc7f856c1fec"), true, "Paris" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AttemptDetails_ExaminationQuestionId",
                table: "AttemptDetails",
                column: "ExaminationQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Attempts_UserId",
                table: "Attempts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ExaminationQuestions_ExaminationId",
                table: "ExaminationQuestions",
                column: "ExaminationId");

            migrationBuilder.CreateIndex(
                name: "IX_ExaminationQuestions_QuestionId",
                table: "ExaminationQuestions",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupDepartments_GroupId",
                table: "GroupDepartments",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Major_DepartmentId",
                table: "Major",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_MBTI_Department_DepartmentId",
                table: "MBTI_Department",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_MBTI_ExamQuestions_ExamId",
                table: "MBTI_ExamQuestions",
                column: "ExamId");

            migrationBuilder.CreateIndex(
                name: "IX_MBTI_ExamQuestions_QuestionId",
                table: "MBTI_ExamQuestions",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_MBTI_UserRecords_UserId",
                table: "MBTI_UserRecords",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_TopicId",
                table: "Questions",
                column: "TopicId");

            migrationBuilder.CreateIndex(
                name: "IX_RecordDetails_MBTI_ExamQuestionId",
                table: "RecordDetails",
                column: "MBTI_ExamQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_RecordDetails_UserRecordId",
                table: "RecordDetails",
                column: "UserRecordId");

            migrationBuilder.CreateIndex(
                name: "IX_SubjectGroup_GroupId",
                table: "SubjectGroup",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Topics_SubjectId",
                table: "Topics",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_UniversityDepartments_DepartmentId",
                table: "UniversityDepartments",
                column: "DepartmentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AttemptDetails");

            migrationBuilder.DropTable(
                name: "GroupDepartments");

            migrationBuilder.DropTable(
                name: "Major");

            migrationBuilder.DropTable(
                name: "MBTI_Department");

            migrationBuilder.DropTable(
                name: "RecordDetails");

            migrationBuilder.DropTable(
                name: "SubjectGroup");

            migrationBuilder.DropTable(
                name: "UniversityDepartments");

            migrationBuilder.DropTable(
                name: "Attempts");

            migrationBuilder.DropTable(
                name: "ExaminationQuestions");

            migrationBuilder.DropTable(
                name: "MBTI");

            migrationBuilder.DropTable(
                name: "MBTI_ExamQuestions");

            migrationBuilder.DropTable(
                name: "MBTI_UserRecords");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropTable(
                name: "University");

            migrationBuilder.DropTable(
                name: "Examinations");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "MBTI_Exams");

            migrationBuilder.DropTable(
                name: "MBTI_Questions");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Topics");

            migrationBuilder.DropTable(
                name: "Subjects");
        }
    }
}
