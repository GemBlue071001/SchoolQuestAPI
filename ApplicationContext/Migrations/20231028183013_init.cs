using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ApplicationContext.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
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
                    { new Guid("b8034210-23fd-4af9-9d7f-f260a0cdef97"), "KT", null, "các ngành về kinh tế", false, null, null, "Kinh tế", 22f },
                    { new Guid("bb3a10db-c4d4-4b45-9d15-0c38f41e8f5f"), "TK", null, "Các ngành thiết kế/nghệ thuật", false, null, null, "Thiết kế", 22f },
                    { new Guid("de305d54-75b4-431b-adb2-eb6b9e546013"), "SE", null, "lam ve may tinh", false, null, null, "Cong Nghe Thong Tin", 22f },
                    { new Guid("e35d862c-1f43-456b-a60b-1b2c7e44ab78"), "SP", null, "Các ngành sư phạm", false, null, null, "Sư phạm", 25f }
                });

            migrationBuilder.InsertData(
                table: "Examinations",
                columns: new[] { "Id", "CreatedBy", "Description", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name", "TotalNumberOfQuestion" },
                values: new object[] { new Guid("ad0080ef-ac58-450b-b086-bc7f856c1fec"), null, "de thi toan", false, null, null, "de toan", 4 });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "CreatedBy", "Description", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[] { new Guid("6a8c8d5f-2a54-42ee-8a7f-0961273cd625"), null, null, false, null, null, "Toan" });

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
                name: "IX_Questions_TopicId",
                table: "Questions",
                column: "TopicId");

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
                name: "Groups");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropTable(
                name: "University");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Examinations");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "Topics");

            migrationBuilder.DropTable(
                name: "Subjects");
        }
    }
}
