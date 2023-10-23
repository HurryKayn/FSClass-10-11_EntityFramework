using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ef01.Migrations
{
    public partial class terza : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AnagraficaArticoli",
                columns: table => new
                {
                    ProdottoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PrezzoUnitario = table.Column<decimal>(type: "decimal (9,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnagraficaArticoli", x => x.ProdottoID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnagraficaArticoli");
        }
    }
}
