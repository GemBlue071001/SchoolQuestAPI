using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApplicationContext.Migrations
{
    /// <inheritdoc />
    public partial class addExaminationTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExaminationQuestion_Examination_ExaminationId",
                table: "ExaminationQuestion");

            migrationBuilder.DropForeignKey(
                name: "FK_ExaminationQuestion_Questions_QuestionId",
                table: "ExaminationQuestion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ExaminationQuestion",
                table: "ExaminationQuestion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Examination",
                table: "Examination");

            migrationBuilder.RenameTable(
                name: "ExaminationQuestion",
                newName: "ExaminationQuestions");

            migrationBuilder.RenameTable(
                name: "Examination",
                newName: "Examinations");

            migrationBuilder.RenameIndex(
                name: "IX_ExaminationQuestion_QuestionId",
                table: "ExaminationQuestions",
                newName: "IX_ExaminationQuestions_QuestionId");

            migrationBuilder.RenameIndex(
                name: "IX_ExaminationQuestion_ExaminationId",
                table: "ExaminationQuestions",
                newName: "IX_ExaminationQuestions_ExaminationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ExaminationQuestions",
                table: "ExaminationQuestions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Examinations",
                table: "Examinations",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ExaminationQuestions_Examinations_ExaminationId",
                table: "ExaminationQuestions",
                column: "ExaminationId",
                principalTable: "Examinations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ExaminationQuestions_Questions_QuestionId",
                table: "ExaminationQuestions",
                column: "QuestionId",
                principalTable: "Questions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExaminationQuestions_Examinations_ExaminationId",
                table: "ExaminationQuestions");

            migrationBuilder.DropForeignKey(
                name: "FK_ExaminationQuestions_Questions_QuestionId",
                table: "ExaminationQuestions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Examinations",
                table: "Examinations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ExaminationQuestions",
                table: "ExaminationQuestions");

            migrationBuilder.RenameTable(
                name: "Examinations",
                newName: "Examination");

            migrationBuilder.RenameTable(
                name: "ExaminationQuestions",
                newName: "ExaminationQuestion");

            migrationBuilder.RenameIndex(
                name: "IX_ExaminationQuestions_QuestionId",
                table: "ExaminationQuestion",
                newName: "IX_ExaminationQuestion_QuestionId");

            migrationBuilder.RenameIndex(
                name: "IX_ExaminationQuestions_ExaminationId",
                table: "ExaminationQuestion",
                newName: "IX_ExaminationQuestion_ExaminationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Examination",
                table: "Examination",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ExaminationQuestion",
                table: "ExaminationQuestion",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ExaminationQuestion_Examination_ExaminationId",
                table: "ExaminationQuestion",
                column: "ExaminationId",
                principalTable: "Examination",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ExaminationQuestion_Questions_QuestionId",
                table: "ExaminationQuestion",
                column: "QuestionId",
                principalTable: "Questions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
