using Microsoft.EntityFrameworkCore.Migrations;

namespace NormanManley.Data.Migrations
{
    public partial class AddedGenderGradeTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Disabilities",
                columns: table => new
                {
                    Blind = table.Column<string>(nullable: false),
                    Dumb = table.Column<string>(nullable: true),
                    VisuallyImpaired = table.Column<string>(nullable: true),
                    PhysicallyDisabled = table.Column<string>(nullable: true),
                    HearingImpaired = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Disabilities", x => x.Blind);
                });

            migrationBuilder.CreateTable(
                name: "Genders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Boy = table.Column<string>(nullable: true),
                    Girl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Grades",
                columns: table => new
                {
                    Class1 = table.Column<string>(nullable: false),
                    Class2 = table.Column<string>(nullable: true),
                    Class3 = table.Column<string>(nullable: true),
                    Class4 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grades", x => x.Class1);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Disabilities");

            migrationBuilder.DropTable(
                name: "Genders");

            migrationBuilder.DropTable(
                name: "Grades");
        }
    }
}
