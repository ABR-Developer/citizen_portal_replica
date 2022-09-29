using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Citizen_Portal.Migrations
{
    public partial class addingAdminAndCompalints : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "cnic",
                table: "complainee");

            migrationBuilder.RenameColumn(
                name: "telephone_number",
                table: "complainee",
                newName: "office_landline_number");

            migrationBuilder.RenameColumn(
                name: "confirm_password",
                table: "complainee",
                newName: "nic_number");

            migrationBuilder.RenameColumn(
                name: "confirm_password",
                table: "complainant",
                newName: "profile_image");

            migrationBuilder.RenameColumn(
                name: "cnic",
                table: "complainant",
                newName: "nic_number");

            migrationBuilder.AlterColumn<DateTime>(
                name: "date_of_birth",
                table: "complainant",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "admin",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_admin", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "complaint",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    field = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    reason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    complaint_type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    discription = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    hide_indentity = table.Column<bool>(type: "bit", nullable: true),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedById = table.Column<int>(type: "int", nullable: true),
                    LastModifyById = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_complaint", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "admin");

            migrationBuilder.DropTable(
                name: "complaint");

            migrationBuilder.RenameColumn(
                name: "office_landline_number",
                table: "complainee",
                newName: "telephone_number");

            migrationBuilder.RenameColumn(
                name: "nic_number",
                table: "complainee",
                newName: "confirm_password");

            migrationBuilder.RenameColumn(
                name: "profile_image",
                table: "complainant",
                newName: "confirm_password");

            migrationBuilder.RenameColumn(
                name: "nic_number",
                table: "complainant",
                newName: "cnic");

            migrationBuilder.AddColumn<string>(
                name: "cnic",
                table: "complainee",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "date_of_birth",
                table: "complainant",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }
    }
}
