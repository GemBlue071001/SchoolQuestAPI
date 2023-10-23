using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

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
