using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI.Migrations
{
    public partial class minimizedb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Doctor");

            migrationBuilder.DropColumn(
                name: "CorporatePhone",
                table: "Doctor");

            migrationBuilder.DropColumn(
                name: "Register",
                table: "Doctor");

            migrationBuilder.DropColumn(
                name: "Signature",
                table: "Doctor");

            migrationBuilder.DropColumn(
                name: "Speciality",
                table: "Doctor");

            migrationBuilder.AlterColumn<string>(
                name: "PersonalPhone",
                table: "Doctor",
                type: "nvarchar(15)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PersonalPhone",
                table: "Doctor",
                type: "nvarchar(15)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Doctor",
                type: "nvarchar(100)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CorporatePhone",
                table: "Doctor",
                type: "nvarchar(15)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Register",
                table: "Doctor",
                type: "nvarchar(15)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Signature",
                table: "Doctor",
                type: "nvarchar(50)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Speciality",
                table: "Doctor",
                type: "nvarchar(50)",
                nullable: false,
                defaultValue: "");
        }
    }
}
