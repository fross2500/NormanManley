using Microsoft.EntityFrameworkCore.Migrations;

namespace NormanManley.Data.Migrations
{
    public partial class AddedParentDataPoints : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           

            migrationBuilder.AddColumn<string>(
                name: "FatherFirstName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FatherLastName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GuardianFirstName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GuardianLastName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MotherFirstName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MotherLastName",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
           

            migrationBuilder.DropColumn(
                name: "FatherFirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FatherLastName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "GuardianFirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "GuardianLastName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "MotherFirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "MotherLastName",
                table: "AspNetUsers");
        }
    }
}
