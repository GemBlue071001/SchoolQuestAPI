using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ApplicationContext.Migrations
{
    /// <inheritdoc />
    public partial class addMBTI : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MBTI_Exam",
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
                    table.PrimaryKey("PK_MBTI_Exam", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MBTI_Question",
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
                    table.PrimaryKey("PK_MBTI_Question", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MBTI_UserRecord",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MBTI_UserRecord", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MBTI_UserRecord_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MBTI_ExamDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    QuestionId = table.Column<int>(type: "integer", nullable: false),
                    ExamId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MBTI_ExamDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MBTI_ExamDetail_MBTI_Exam_ExamId",
                        column: x => x.ExamId,
                        principalTable: "MBTI_Exam",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MBTI_ExamDetail_MBTI_Question_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "MBTI_Question",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RecordDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserRecordId = table.Column<int>(type: "integer", nullable: false),
                    QuestionId = table.Column<int>(type: "integer", nullable: false),
                    UserChoice = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecordDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RecordDetail_MBTI_Question_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "MBTI_Question",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RecordDetail_MBTI_UserRecord_UserRecordId",
                        column: x => x.UserRecordId,
                        principalTable: "MBTI_UserRecord",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Attempts",
                keyColumn: "Id",
                keyValue: new Guid("9b8daa9f-7f8c-41d9-aa34-ba2b1010f4ed"),
                columns: new[] { "CreatedDate", "ExamDate" },
                values: new object[] { new DateTime(2023, 11, 12, 14, 59, 40, 683, DateTimeKind.Utc).AddTicks(7800), new DateTime(2023, 11, 13, 14, 59, 40, 683, DateTimeKind.Utc).AddTicks(7807) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a6be20e2-5927-4cce-bed4-258f919f82e6"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 45, 197, 6, 3, 227, 30, 167, 235, 37, 75, 160, 55, 152, 149, 211, 122, 13, 47, 120, 114, 233, 133, 77, 156, 146, 214, 11, 137, 108, 34, 92, 18, 182, 226, 165, 141, 85, 138, 240, 101, 42, 26, 232, 72, 23, 147, 108, 81, 89, 91, 33, 104, 147, 181, 73, 161, 30, 237, 115, 99, 30, 3, 15, 99 }, new byte[] { 233, 188, 178, 217, 183, 240, 140, 148, 32, 162, 61, 235, 152, 237, 46, 96, 253, 88, 199, 149, 251, 126, 193, 199, 201, 28, 106, 106, 90, 21, 10, 222, 60, 97, 109, 232, 10, 36, 49, 30, 173, 8, 9, 244, 118, 184, 221, 154, 137, 230, 134, 206, 98, 5, 122, 189, 200, 234, 244, 161, 165, 71, 87, 79, 6, 136, 118, 93, 13, 116, 57, 145, 223, 227, 40, 95, 190, 75, 14, 181, 11, 54, 207, 203, 189, 234, 196, 95, 88, 174, 186, 28, 30, 170, 253, 191, 118, 218, 202, 152, 201, 43, 27, 92, 230, 33, 24, 99, 4, 152, 242, 68, 185, 208, 58, 205, 205, 202, 96, 39, 233, 208, 157, 4, 69, 255, 143, 93 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f0b84747-fbed-43e1-9cd1-ecf2e1bd3cc0"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 183, 7, 4, 214, 145, 39, 145, 250, 194, 198, 231, 43, 69, 104, 249, 52, 108, 78, 130, 114, 241, 191, 199, 147, 144, 173, 129, 167, 162, 240, 230, 163, 144, 139, 178, 226, 249, 166, 0, 151, 2, 254, 198, 22, 174, 241, 247, 130, 25, 231, 0, 48, 250, 116, 185, 160, 215, 161, 26, 92, 70, 19, 46, 171 }, new byte[] { 62, 133, 6, 54, 135, 208, 141, 91, 35, 210, 131, 154, 211, 216, 243, 112, 233, 60, 81, 208, 48, 255, 247, 178, 126, 8, 212, 170, 111, 112, 40, 224, 68, 161, 81, 25, 98, 66, 235, 228, 208, 185, 27, 191, 55, 91, 153, 159, 60, 178, 182, 231, 70, 128, 58, 173, 241, 250, 121, 124, 147, 182, 60, 65, 5, 36, 235, 195, 100, 68, 183, 222, 124, 188, 97, 129, 41, 155, 30, 47, 107, 57, 218, 252, 76, 72, 137, 28, 248, 78, 178, 201, 129, 114, 113, 187, 245, 39, 220, 50, 182, 155, 80, 112, 221, 73, 226, 206, 244, 1, 57, 222, 41, 219, 100, 101, 155, 10, 109, 177, 159, 124, 219, 68, 144, 32, 167, 171 } });

            migrationBuilder.CreateIndex(
                name: "IX_MBTI_ExamDetail_ExamId",
                table: "MBTI_ExamDetail",
                column: "ExamId");

            migrationBuilder.CreateIndex(
                name: "IX_MBTI_ExamDetail_QuestionId",
                table: "MBTI_ExamDetail",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_MBTI_UserRecord_UserId",
                table: "MBTI_UserRecord",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_RecordDetail_QuestionId",
                table: "RecordDetail",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_RecordDetail_UserRecordId",
                table: "RecordDetail",
                column: "UserRecordId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MBTI_ExamDetail");

            migrationBuilder.DropTable(
                name: "RecordDetail");

            migrationBuilder.DropTable(
                name: "MBTI_Exam");

            migrationBuilder.DropTable(
                name: "MBTI_Question");

            migrationBuilder.DropTable(
                name: "MBTI_UserRecord");

            migrationBuilder.UpdateData(
                table: "Attempts",
                keyColumn: "Id",
                keyValue: new Guid("9b8daa9f-7f8c-41d9-aa34-ba2b1010f4ed"),
                columns: new[] { "CreatedDate", "ExamDate" },
                values: new object[] { new DateTime(2023, 11, 8, 13, 34, 12, 850, DateTimeKind.Utc).AddTicks(963), new DateTime(2023, 11, 9, 13, 34, 12, 850, DateTimeKind.Utc).AddTicks(969) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a6be20e2-5927-4cce-bed4-258f919f82e6"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 219, 78, 69, 146, 130, 35, 112, 98, 173, 93, 70, 120, 182, 76, 5, 240, 170, 147, 128, 4, 99, 153, 255, 85, 209, 101, 156, 127, 86, 10, 128, 131, 44, 34, 64, 223, 42, 77, 155, 136, 182, 172, 192, 224, 54, 97, 243, 200, 144, 67, 51, 61, 37, 62, 146, 192, 213, 147, 140, 48, 92, 141, 5, 198 }, new byte[] { 109, 145, 44, 25, 213, 201, 190, 77, 171, 17, 138, 191, 48, 117, 46, 98, 106, 109, 235, 205, 5, 157, 84, 144, 147, 112, 78, 249, 57, 238, 82, 7, 97, 126, 70, 167, 94, 203, 176, 126, 97, 106, 221, 208, 200, 236, 98, 101, 203, 197, 145, 167, 109, 102, 114, 77, 210, 36, 109, 3, 169, 224, 75, 83, 81, 178, 209, 171, 55, 122, 214, 184, 169, 36, 22, 105, 12, 136, 105, 85, 49, 60, 30, 188, 123, 94, 144, 197, 16, 92, 103, 43, 131, 200, 136, 117, 147, 84, 45, 117, 51, 124, 200, 140, 231, 45, 195, 249, 77, 190, 63, 241, 41, 145, 121, 208, 158, 186, 226, 130, 133, 129, 180, 110, 114, 104, 49, 229 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f0b84747-fbed-43e1-9cd1-ecf2e1bd3cc0"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 97, 190, 107, 23, 166, 45, 176, 18, 232, 188, 174, 143, 240, 184, 29, 107, 155, 193, 96, 50, 136, 245, 112, 175, 167, 92, 0, 104, 7, 135, 3, 217, 160, 235, 9, 66, 214, 183, 212, 141, 62, 40, 180, 48, 5, 79, 175, 141, 56, 141, 165, 200, 226, 84, 49, 208, 198, 151, 251, 146, 52, 213, 198, 19 }, new byte[] { 47, 241, 114, 179, 10, 251, 90, 120, 44, 16, 167, 25, 187, 33, 198, 68, 69, 6, 8, 29, 7, 179, 131, 32, 43, 164, 11, 166, 2, 68, 141, 34, 61, 124, 178, 241, 115, 7, 54, 248, 154, 76, 96, 5, 225, 105, 162, 64, 118, 113, 11, 190, 146, 197, 88, 46, 184, 166, 25, 54, 233, 131, 243, 109, 74, 249, 86, 59, 154, 211, 124, 134, 56, 251, 91, 218, 93, 74, 142, 247, 139, 122, 10, 160, 203, 171, 163, 183, 22, 22, 103, 39, 37, 127, 103, 153, 107, 176, 152, 152, 103, 158, 16, 172, 65, 201, 126, 229, 125, 134, 241, 89, 201, 151, 113, 235, 198, 2, 25, 99, 182, 15, 118, 50, 186, 231, 46, 43 } });
        }
    }
}
