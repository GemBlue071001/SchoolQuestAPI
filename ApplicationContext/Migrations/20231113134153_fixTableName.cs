using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApplicationContext.Migrations
{
    /// <inheritdoc />
    public partial class fixTableName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MBTI_ExamDetail_MBTI_Exam_ExamId",
                table: "MBTI_ExamDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_MBTI_ExamDetail_MBTI_Question_QuestionId",
                table: "MBTI_ExamDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_MBTI_UserRecord_Users_UserId",
                table: "MBTI_UserRecord");

            migrationBuilder.DropForeignKey(
                name: "FK_RecordDetail_MBTI_Question_QuestionId",
                table: "RecordDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_RecordDetail_MBTI_UserRecord_UserRecordId",
                table: "RecordDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RecordDetail",
                table: "RecordDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MBTI_UserRecord",
                table: "MBTI_UserRecord");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MBTI_Question",
                table: "MBTI_Question");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MBTI_ExamDetail",
                table: "MBTI_ExamDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MBTI_Exam",
                table: "MBTI_Exam");

            migrationBuilder.RenameTable(
                name: "RecordDetail",
                newName: "RecordDetails");

            migrationBuilder.RenameTable(
                name: "MBTI_UserRecord",
                newName: "MBTI_UserRecords");

            migrationBuilder.RenameTable(
                name: "MBTI_Question",
                newName: "MBTI_Questions");

            migrationBuilder.RenameTable(
                name: "MBTI_ExamDetail",
                newName: "MBTI_ExamDetails");

            migrationBuilder.RenameTable(
                name: "MBTI_Exam",
                newName: "MBTI_Exams");

            migrationBuilder.RenameIndex(
                name: "IX_RecordDetail_UserRecordId",
                table: "RecordDetails",
                newName: "IX_RecordDetails_UserRecordId");

            migrationBuilder.RenameIndex(
                name: "IX_RecordDetail_QuestionId",
                table: "RecordDetails",
                newName: "IX_RecordDetails_QuestionId");

            migrationBuilder.RenameIndex(
                name: "IX_MBTI_UserRecord_UserId",
                table: "MBTI_UserRecords",
                newName: "IX_MBTI_UserRecords_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_MBTI_ExamDetail_QuestionId",
                table: "MBTI_ExamDetails",
                newName: "IX_MBTI_ExamDetails_QuestionId");

            migrationBuilder.RenameIndex(
                name: "IX_MBTI_ExamDetail_ExamId",
                table: "MBTI_ExamDetails",
                newName: "IX_MBTI_ExamDetails_ExamId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RecordDetails",
                table: "RecordDetails",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MBTI_UserRecords",
                table: "MBTI_UserRecords",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MBTI_Questions",
                table: "MBTI_Questions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MBTI_ExamDetails",
                table: "MBTI_ExamDetails",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MBTI_Exams",
                table: "MBTI_Exams",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Attempts",
                keyColumn: "Id",
                keyValue: new Guid("9b8daa9f-7f8c-41d9-aa34-ba2b1010f4ed"),
                columns: new[] { "CreatedDate", "ExamDate" },
                values: new object[] { new DateTime(2023, 11, 13, 13, 41, 52, 994, DateTimeKind.Utc).AddTicks(5776), new DateTime(2023, 11, 14, 13, 41, 52, 994, DateTimeKind.Utc).AddTicks(5780) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a6be20e2-5927-4cce-bed4-258f919f82e6"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 220, 65, 188, 194, 133, 182, 6, 160, 176, 181, 159, 6, 189, 4, 181, 96, 220, 58, 242, 141, 94, 133, 140, 226, 186, 254, 54, 69, 229, 218, 227, 53, 231, 99, 149, 152, 210, 18, 205, 233, 204, 180, 184, 201, 239, 83, 238, 165, 144, 186, 140, 184, 190, 164, 243, 61, 184, 97, 36, 82, 94, 208, 174, 108 }, new byte[] { 53, 76, 214, 4, 98, 168, 50, 205, 162, 22, 100, 216, 33, 93, 86, 34, 24, 168, 144, 201, 225, 80, 49, 245, 218, 142, 77, 242, 82, 191, 161, 227, 35, 165, 51, 81, 208, 36, 115, 136, 223, 111, 168, 138, 187, 109, 212, 184, 189, 34, 69, 80, 98, 50, 122, 33, 1, 241, 178, 14, 126, 114, 93, 161, 44, 116, 40, 147, 139, 48, 1, 101, 8, 228, 245, 247, 61, 251, 64, 151, 159, 194, 88, 20, 12, 120, 56, 9, 24, 178, 118, 5, 116, 103, 24, 11, 217, 107, 204, 6, 219, 188, 50, 166, 225, 167, 151, 245, 30, 206, 218, 194, 165, 0, 187, 126, 235, 248, 233, 115, 140, 108, 116, 175, 235, 74, 121, 30 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f0b84747-fbed-43e1-9cd1-ecf2e1bd3cc0"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 60, 223, 110, 189, 36, 240, 75, 94, 91, 198, 107, 231, 38, 23, 195, 13, 90, 97, 148, 100, 78, 42, 23, 215, 175, 184, 141, 25, 145, 107, 84, 175, 45, 196, 22, 93, 106, 193, 39, 59, 128, 43, 76, 211, 53, 127, 248, 130, 57, 66, 226, 151, 85, 164, 114, 241, 168, 209, 220, 174, 147, 156, 155, 16 }, new byte[] { 125, 183, 227, 190, 166, 84, 45, 240, 124, 203, 123, 21, 115, 119, 58, 175, 87, 37, 150, 26, 64, 120, 118, 103, 9, 156, 127, 35, 64, 118, 118, 195, 179, 115, 169, 123, 129, 74, 216, 150, 176, 71, 204, 192, 186, 170, 33, 92, 254, 5, 196, 154, 2, 188, 136, 157, 10, 254, 39, 78, 122, 191, 133, 76, 203, 153, 85, 58, 59, 105, 12, 236, 167, 42, 182, 110, 147, 195, 68, 55, 244, 240, 250, 243, 115, 241, 253, 85, 92, 123, 20, 251, 114, 19, 216, 222, 214, 31, 12, 69, 120, 77, 254, 247, 170, 180, 171, 142, 3, 119, 171, 26, 169, 4, 31, 33, 145, 54, 51, 60, 126, 71, 98, 176, 254, 105, 168, 136 } });

            migrationBuilder.AddForeignKey(
                name: "FK_MBTI_ExamDetails_MBTI_Exams_ExamId",
                table: "MBTI_ExamDetails",
                column: "ExamId",
                principalTable: "MBTI_Exams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MBTI_ExamDetails_MBTI_Questions_QuestionId",
                table: "MBTI_ExamDetails",
                column: "QuestionId",
                principalTable: "MBTI_Questions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MBTI_UserRecords_Users_UserId",
                table: "MBTI_UserRecords",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RecordDetails_MBTI_Questions_QuestionId",
                table: "RecordDetails",
                column: "QuestionId",
                principalTable: "MBTI_Questions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RecordDetails_MBTI_UserRecords_UserRecordId",
                table: "RecordDetails",
                column: "UserRecordId",
                principalTable: "MBTI_UserRecords",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MBTI_ExamDetails_MBTI_Exams_ExamId",
                table: "MBTI_ExamDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_MBTI_ExamDetails_MBTI_Questions_QuestionId",
                table: "MBTI_ExamDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_MBTI_UserRecords_Users_UserId",
                table: "MBTI_UserRecords");

            migrationBuilder.DropForeignKey(
                name: "FK_RecordDetails_MBTI_Questions_QuestionId",
                table: "RecordDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_RecordDetails_MBTI_UserRecords_UserRecordId",
                table: "RecordDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RecordDetails",
                table: "RecordDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MBTI_UserRecords",
                table: "MBTI_UserRecords");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MBTI_Questions",
                table: "MBTI_Questions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MBTI_Exams",
                table: "MBTI_Exams");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MBTI_ExamDetails",
                table: "MBTI_ExamDetails");

            migrationBuilder.RenameTable(
                name: "RecordDetails",
                newName: "RecordDetail");

            migrationBuilder.RenameTable(
                name: "MBTI_UserRecords",
                newName: "MBTI_UserRecord");

            migrationBuilder.RenameTable(
                name: "MBTI_Questions",
                newName: "MBTI_Question");

            migrationBuilder.RenameTable(
                name: "MBTI_Exams",
                newName: "MBTI_Exam");

            migrationBuilder.RenameTable(
                name: "MBTI_ExamDetails",
                newName: "MBTI_ExamDetail");

            migrationBuilder.RenameIndex(
                name: "IX_RecordDetails_UserRecordId",
                table: "RecordDetail",
                newName: "IX_RecordDetail_UserRecordId");

            migrationBuilder.RenameIndex(
                name: "IX_RecordDetails_QuestionId",
                table: "RecordDetail",
                newName: "IX_RecordDetail_QuestionId");

            migrationBuilder.RenameIndex(
                name: "IX_MBTI_UserRecords_UserId",
                table: "MBTI_UserRecord",
                newName: "IX_MBTI_UserRecord_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_MBTI_ExamDetails_QuestionId",
                table: "MBTI_ExamDetail",
                newName: "IX_MBTI_ExamDetail_QuestionId");

            migrationBuilder.RenameIndex(
                name: "IX_MBTI_ExamDetails_ExamId",
                table: "MBTI_ExamDetail",
                newName: "IX_MBTI_ExamDetail_ExamId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RecordDetail",
                table: "RecordDetail",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MBTI_UserRecord",
                table: "MBTI_UserRecord",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MBTI_Question",
                table: "MBTI_Question",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MBTI_Exam",
                table: "MBTI_Exam",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MBTI_ExamDetail",
                table: "MBTI_ExamDetail",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_MBTI_ExamDetail_MBTI_Exam_ExamId",
                table: "MBTI_ExamDetail",
                column: "ExamId",
                principalTable: "MBTI_Exam",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MBTI_ExamDetail_MBTI_Question_QuestionId",
                table: "MBTI_ExamDetail",
                column: "QuestionId",
                principalTable: "MBTI_Question",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MBTI_UserRecord_Users_UserId",
                table: "MBTI_UserRecord",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RecordDetail_MBTI_Question_QuestionId",
                table: "RecordDetail",
                column: "QuestionId",
                principalTable: "MBTI_Question",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RecordDetail_MBTI_UserRecord_UserRecordId",
                table: "RecordDetail",
                column: "UserRecordId",
                principalTable: "MBTI_UserRecord",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
