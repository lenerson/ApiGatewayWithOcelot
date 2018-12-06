using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Catalog.Repository.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Description = table.Column<string>(maxLength: 1000, nullable: false),
                    Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("e6ea2289-1551-473c-9123-8634790a81ba"), "Notebook Avell G1513 FOX-5 BS", "Notebook Avell G1513 FOX-5 BS", 4799.70m },
                    { new Guid("11253e54-ed71-466c-9e7a-430fc14a17b9"), "Smartphone ASUS ZenFone 5Z 8GB/256GB Preto", "Smartphone ASUS ZenFone 5Z 8GB/256GB Preto", 3509.10m },
                    { new Guid("7e9729b8-9704-4a0b-ae39-036cacae09f6"), "Console Xbox One X 1TB 4K+ Controle sem Fio", "Console Xbox One X 1TB 4K+ Controle sem Fio", 2540.19m },
                    { new Guid("3e5ff496-e40d-4a59-baf9-30081918f445"), "Console Playstation 4 Pro 1tb - Ps4", "Console Playstation 4 Pro 1tb - Ps4", 2640.00m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
