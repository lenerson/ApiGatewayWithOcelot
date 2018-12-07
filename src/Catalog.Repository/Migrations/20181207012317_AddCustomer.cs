using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Catalog.Repository.Migrations
{
    public partial class AddCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("11253e54-ed71-466c-9e7a-430fc14a17b9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3e5ff496-e40d-4a59-baf9-30081918f445"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7e9729b8-9704-4a0b-ae39-036cacae09f6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e6ea2289-1551-473c-9123-8634790a81ba"));

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("354d06be-9c1d-4b8b-a7d7-79f10c5beebb"), "João da Silva" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("b6a9c498-26a3-406a-8458-fb53387f8668"), "Notebook Avell G1513 FOX-5 BS", "Notebook Avell G1513 FOX-5 BS", 4799.70m },
                    { new Guid("18bbadd7-b805-4757-9951-e5ab706316b7"), "Smartphone ASUS ZenFone 5Z 8GB/256GB Preto", "Smartphone ASUS ZenFone 5Z 8GB/256GB Preto", 3509.10m },
                    { new Guid("f21974a6-4e97-4703-a36e-2ccc03a5ba3d"), "Console Xbox One X 1TB 4K+ Controle sem Fio", "Console Xbox One X 1TB 4K+ Controle sem Fio", 2540.19m },
                    { new Guid("ba27bf30-c2da-48f5-b756-d28c6df7622a"), "Console Playstation 4 Pro 1tb - Ps4", "Console Playstation 4 Pro 1tb - Ps4", 2640.00m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("18bbadd7-b805-4757-9951-e5ab706316b7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b6a9c498-26a3-406a-8458-fb53387f8668"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ba27bf30-c2da-48f5-b756-d28c6df7622a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f21974a6-4e97-4703-a36e-2ccc03a5ba3d"));

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
    }
}
