using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApplicationContext.Migrations
{
    /// <inheritdoc />
    public partial class addFieldForAttemp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AttempType",
                table: "Attempts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "ExamDate",
                table: "Attempts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsCorrect",
                table: "AttemptDetails",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UserAnswered",
                table: "AttemptDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AttempType",
                table: "Attempts");

            migrationBuilder.DropColumn(
                name: "ExamDate",
                table: "Attempts");

            migrationBuilder.DropColumn(
                name: "IsCorrect",
                table: "AttemptDetails");

            migrationBuilder.DropColumn(
                name: "UserAnswered",
                table: "AttemptDetails");
        }
    }
}
