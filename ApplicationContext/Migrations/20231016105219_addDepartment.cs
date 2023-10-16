using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApplicationContext.Migrations
{
    /// <inheritdoc />
    public partial class addDepartment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GroupDepartments_UniversityDepartments_UniversityDepartmentId",
                table: "GroupDepartments");

            migrationBuilder.DropForeignKey(
                name: "FK_Major_UniversityDepartments_UniversityDepartmentId",
                table: "Major");

            migrationBuilder.DropForeignKey(
                name: "FK_MBTI_Department_UniversityDepartments_DepartmentId",
                table: "MBTI_Department");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UniversityDepartments",
                table: "UniversityDepartments");

            migrationBuilder.DropIndex(
                name: "IX_UniversityDepartments_UniversityId",
                table: "UniversityDepartments");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "UniversityDepartments");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "UniversityDepartments");

            migrationBuilder.DropColumn(
                name: "RequiredScore",
                table: "UniversityDepartments");

            migrationBuilder.RenameColumn(
                name: "UniversityDepartmentId",
                table: "Major",
                newName: "DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Major_UniversityDepartmentId",
                table: "Major",
                newName: "IX_Major_DepartmentId");

            migrationBuilder.RenameColumn(
                name: "UniversityDepartmentId",
                table: "GroupDepartments",
                newName: "DepartmentId");

            migrationBuilder.AddColumn<Guid>(
                name: "DepartmentId",
                table: "UniversityDepartments",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "Major",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Major",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UniversityDepartments",
                table: "UniversityDepartments",
                columns: new[] { "UniversityId", "DepartmentId" });

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RequiredScore = table.Column<float>(type: "real", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UniversityDepartments_DepartmentId",
                table: "UniversityDepartments",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_GroupDepartments_Department_DepartmentId",
                table: "GroupDepartments",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Major_Department_DepartmentId",
                table: "Major",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MBTI_Department_Department_DepartmentId",
                table: "MBTI_Department",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UniversityDepartments_Department_DepartmentId",
                table: "UniversityDepartments",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GroupDepartments_Department_DepartmentId",
                table: "GroupDepartments");

            migrationBuilder.DropForeignKey(
                name: "FK_Major_Department_DepartmentId",
                table: "Major");

            migrationBuilder.DropForeignKey(
                name: "FK_MBTI_Department_Department_DepartmentId",
                table: "MBTI_Department");

            migrationBuilder.DropForeignKey(
                name: "FK_UniversityDepartments_Department_DepartmentId",
                table: "UniversityDepartments");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UniversityDepartments",
                table: "UniversityDepartments");

            migrationBuilder.DropIndex(
                name: "IX_UniversityDepartments_DepartmentId",
                table: "UniversityDepartments");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "UniversityDepartments");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "Major");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Major");

            migrationBuilder.RenameColumn(
                name: "DepartmentId",
                table: "Major",
                newName: "UniversityDepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Major_DepartmentId",
                table: "Major",
                newName: "IX_Major_UniversityDepartmentId");

            migrationBuilder.RenameColumn(
                name: "DepartmentId",
                table: "GroupDepartments",
                newName: "UniversityDepartmentId");

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

            migrationBuilder.AddPrimaryKey(
                name: "PK_UniversityDepartments",
                table: "UniversityDepartments",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_UniversityDepartments_UniversityId",
                table: "UniversityDepartments",
                column: "UniversityId");

            migrationBuilder.AddForeignKey(
                name: "FK_GroupDepartments_UniversityDepartments_UniversityDepartmentId",
                table: "GroupDepartments",
                column: "UniversityDepartmentId",
                principalTable: "UniversityDepartments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Major_UniversityDepartments_UniversityDepartmentId",
                table: "Major",
                column: "UniversityDepartmentId",
                principalTable: "UniversityDepartments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MBTI_Department_UniversityDepartments_DepartmentId",
                table: "MBTI_Department",
                column: "DepartmentId",
                principalTable: "UniversityDepartments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
