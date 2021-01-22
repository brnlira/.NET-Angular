using Microsoft.EntityFrameworkCore.Migrations;

namespace PBT.API.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    ClienteId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(nullable: true),
                    Telefone = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    DataCadastro = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.ClienteId);
                });

            migrationBuilder.CreateTable(
                name: "CSessao",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ClienteId = table.Column<int>(nullable: false),
                    NomeCliente = table.Column<string>(nullable: true),
                    SessaoId = table.Column<int>(nullable: false),
                    NomeSessao = table.Column<string>(nullable: true),
                    Local = table.Column<string>(nullable: true),
                    DataDaSessao = table.Column<string>(nullable: true),
                    QtdPessoas = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CSessao", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sessoes",
                columns: table => new
                {
                    SessaoId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Sesssao = table.Column<string>(nullable: true),
                    Local = table.Column<string>(nullable: true),
                    Preco = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sessoes", x => x.SessaoId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "CSessao");

            migrationBuilder.DropTable(
                name: "Sessoes");
        }
    }
}
