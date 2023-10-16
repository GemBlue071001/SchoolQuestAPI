using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ApplicationContext.Migrations
{
    /// <inheritdoc />
    public partial class addMBTI : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "UniversityDepartments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "UniversityDepartments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "RequiredScore",
                table: "UniversityDepartments",
                type: "real",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "MBTI",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MBTI", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MBTI_Department",
                columns: table => new
                {
                    MBTI_Id = table.Column<int>(type: "int", nullable: false),
                    DepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MBTI_Department", x => new { x.MBTI_Id, x.DepartmentId });
                    table.ForeignKey(
                        name: "FK_MBTI_Department_MBTI_MBTI_Id",
                        column: x => x.MBTI_Id,
                        principalTable: "MBTI",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MBTI_Department_UniversityDepartments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "UniversityDepartments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                name: "IX_MBTI_Department_DepartmentId",
                table: "MBTI_Department",
                column: "DepartmentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MBTI_Department");

            migrationBuilder.DropTable(
                name: "MBTI");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "UniversityDepartments");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "UniversityDepartments");

            migrationBuilder.DropColumn(
                name: "RequiredScore",
                table: "UniversityDepartments");
        }
    }
}
