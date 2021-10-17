using Microsoft.EntityFrameworkCore.Migrations;

namespace Noter.Data.Migrations.Note
{
    public partial class AddFlags : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Completed",
                table: "Notes",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Started",
                table: "Notes",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Completed",
                table: "Notes");

            migrationBuilder.DropColumn(
                name: "Started",
                table: "Notes");
        }
    }
}
