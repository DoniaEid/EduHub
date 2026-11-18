using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EduHub.Migrations
{
    /// <inheritdoc />
    public partial class AddColumnInCourse : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Course",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Course");
        }
    }
}
