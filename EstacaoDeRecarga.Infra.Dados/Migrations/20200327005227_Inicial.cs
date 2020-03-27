using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EstacaoDeRecarga.Infra.Dados.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EstacaoRecarga",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: false),
                    Tipo = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Latitude = table.Column<decimal>(type: "decimal(14,6)", nullable: false),
                    Longitude = table.Column<decimal>(type: "decimal(14,6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstacaoRecarga", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EstacaoRecarga");
        }
    }
}
