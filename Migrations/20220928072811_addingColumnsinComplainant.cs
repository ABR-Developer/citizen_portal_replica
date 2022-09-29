using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Citizen_Portal.Migrations
{
    public partial class addingColumnsinComplainant : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "postal_code",
                table: "complainant");

            migrationBuilder.RenameColumn(
                name: "country_code",
                table: "complainant",
                newName: "reason_visit_pakistan");

            migrationBuilder.AlterColumn<string>(
                name: "mobile_number",
                table: "complainant",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(12)",
                oldMaxLength: 12);

            migrationBuilder.AddColumn<string>(
                name: "abroad_country",
                table: "complainant",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "reason_abroad",
                table: "complainant",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "abroad_country",
                table: "complainant");

            migrationBuilder.DropColumn(
                name: "reason_abroad",
                table: "complainant");

            migrationBuilder.RenameColumn(
                name: "reason_visit_pakistan",
                table: "complainant",
                newName: "country_code");

            migrationBuilder.AlterColumn<string>(
                name: "mobile_number",
                table: "complainant",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "postal_code",
                table: "complainant",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: false,
                defaultValue: "");
        }
    }
}
