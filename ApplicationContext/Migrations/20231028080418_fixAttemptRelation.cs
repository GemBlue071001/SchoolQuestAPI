using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ApplicationContext.Migrations
{
    /// <inheritdoc />
    public partial class fixAttemptRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AttemptDetails_Users_UserId",
                table: "AttemptDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AttemptDetails",
                table: "AttemptDetails");

            migrationBuilder.DropIndex(
                name: "IX_AttemptDetails_UserId",
                table: "AttemptDetails");

            migrationBuilder.DeleteData(
                table: "MBTI",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MBTI",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MBTI",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MBTI",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MBTI",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "MBTI",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "MBTI",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "MBTI",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "MBTI",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "MBTI",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "MBTI",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "MBTI",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "MBTI",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "MBTI",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "MBTI",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "MBTI",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "AttemptDetails");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "Attempts",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_AttemptDetails",
                table: "AttemptDetails",
                columns: new[] { "AttemptId", "ExaminationQuestionId" });

            migrationBuilder.CreateIndex(
                name: "IX_Attempts_UserId",
                table: "Attempts",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Attempts_Users_UserId",
                table: "Attempts",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attempts_Users_UserId",
                table: "Attempts");

            migrationBuilder.DropIndex(
                name: "IX_Attempts_UserId",
                table: "Attempts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AttemptDetails",
                table: "AttemptDetails");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "Attempts",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "AttemptDetails",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_AttemptDetails",
                table: "AttemptDetails",
                columns: new[] { "AttemptId", "UserId", "ExaminationQuestionId" });

            migrationBuilder.InsertData(
                table: "MBTI",
                columns: new[] { "Id", "Code", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "INTJ", "Imaginative and strategic thinkers, with a plan for everything.", "The Architect" },
                    { 2, "INTP", "Innovative inventors with an unquenchable thirst for knowledge.", "The Logician" },
                    { 3, "ENTJ", "Bold, imaginative and strong-willed leaders, always finding a way � or making one.", "The Commander" },
                    { 4, "ENTP", "Smart and curious thinkers who cannot resist an intellectual challenge.", "The Debater" },
                    { 5, "INFJ", "Quiet and mystical, yet very inspiring and tireless idealists.", "The Advocate" },
                    { 6, "INFP", "Poetic, kind and altruistic people, always eager to help a good cause.", "The Mediator" },
                    { 7, "ENFJ", "Charismatic and inspiring leaders, able to mesmerize their listeners.", "The Protagonist" },
                    { 8, "ENFP", "Enthusiastic, creative and sociable free spirits, who can always find a reason to smile.", "The Campaigner" },
                    { 9, "ISTJ", "Practical and fact-minded individuals, whose reliability cannot be doubted.", "The Logistician" },
                    { 10, "ISFJ", "Very dedicated and warm protectors, always ready to defend their loved ones.", "The Defender" },
                    { 11, "ESTJ", "Excellent administrators, unsurpassed at managing things � or people.", "The Executive" },
                    { 12, "ESFJ", "Extraordinarily caring, social and popular people, always eager to help.", "The Consul" },
                    { 13, "ISTP", "Bold and practical experimenters, masters of all kinds of tools.", "The Virtuoso" },
                    { 14, "ISFP", "Flexible and charming artists, always ready to explore and experience something new.", "The Adventurer" },
                    { 15, "ESTP", "Smart, energetic and very perceptive people, who truly enjoy living on the edge.", "The Entrepreneur" },
                    { 16, "ESFP", "Spontaneous, energetic and enthusiastic people � life is never boring around them.", "The Entertainer" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AttemptDetails_UserId",
                table: "AttemptDetails",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AttemptDetails_Users_UserId",
                table: "AttemptDetails",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
