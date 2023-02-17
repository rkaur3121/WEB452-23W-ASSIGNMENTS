using Microsoft.EntityFrameworkCore.Migrations;

namespace Magnets.Migrations.Magnets
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Magnet",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MagnetNames = table.Column<string>(nullable: true),
                    Material = table.Column<string>(nullable: true),
                    Applications = table.Column<string>(nullable: true),
                    Strength = table.Column<string>(nullable: true),
                    Rating = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Magnet", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Magnet");
        }
    }
}
