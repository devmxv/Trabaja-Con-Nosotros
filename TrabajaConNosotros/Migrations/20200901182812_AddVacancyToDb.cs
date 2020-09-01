using Microsoft.EntityFrameworkCore.Migrations;

namespace TrabajaConNosotros.Migrations
{
    public partial class AddVacancyToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vacancy",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: false),
                    Category = table.Column<int>(nullable: false),
                    Salary = table.Column<float>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    Comments = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vacancy", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vacancy");
        }
    }
}
