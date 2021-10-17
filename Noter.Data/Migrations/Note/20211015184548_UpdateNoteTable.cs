using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Noter.Data.Migrations.Note
{
    public partial class UpdateNoteTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id",
                table: "Notes",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "tesst",
                table: "Notes",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "Noted",
                table: "Notes",
                newName: "Title");

            migrationBuilder.AddColumn<string>(
                name: "Body",
                table: "Notes",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "Notes",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastAmended",
                table: "Notes",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "LastAmendedBy",
                table: "Notes",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Body",
                table: "Notes");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "Notes");

            migrationBuilder.DropColumn(
                name: "LastAmended",
                table: "Notes");

            migrationBuilder.DropColumn(
                name: "LastAmendedBy",
                table: "Notes");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Notes",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Notes",
                newName: "tesst");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Notes",
                newName: "Noted");
        }
    }
}
