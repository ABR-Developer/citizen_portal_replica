using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Citizen_Portal.Migrations
{
    public partial class addedCompalaineeAttributed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "nationality",
                table: "complainee",
                newName: "tehsil");

            migrationBuilder.RenameColumn(
                name: "country_code",
                table: "complainee",
                newName: "district");

            migrationBuilder.AddColumn<string>(
                name: "profile_image",
                table: "complainee",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "profile_image",
                table: "complainant",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "profile_image",
                table: "complainee");

            migrationBuilder.RenameColumn(
                name: "tehsil",
                table: "complainee",
                newName: "nationality");

            migrationBuilder.RenameColumn(
                name: "district",
                table: "complainee",
                newName: "country_code");

            migrationBuilder.AlterColumn<string>(
                name: "profile_image",
                table: "complainant",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
