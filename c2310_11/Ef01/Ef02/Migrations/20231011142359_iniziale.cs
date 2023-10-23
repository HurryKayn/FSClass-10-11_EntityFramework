using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ef02.Migrations
{
    public partial class iniziale : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Alunni",
                columns: table => new
                {
                    AlunnoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Cognome = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    Eta = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Notazioni = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Altezza = table.Column<decimal>(type: "decimal  (4,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alunni", x => x.AlunnoId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alunni");
        }
    }
}
