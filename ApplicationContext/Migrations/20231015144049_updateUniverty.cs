using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApplicationContext.Migrations
{
    /// <inheritdoc />
    public partial class updateUniverty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "University",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "University",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Code",
                table: "University");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "University");
        }
    }
}
