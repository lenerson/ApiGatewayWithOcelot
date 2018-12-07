using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Orders.Repository.Migrations
{
    public partial class RenameColumnCustomerId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrdersProducts",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("377c779f-c96c-4cb2-b0d8-e9e233215e3b"), new Guid("11253e54-ed71-466c-9e7a-430fc14a17b9") });

            migrationBuilder.DeleteData(
                table: "OrdersProducts",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("377c779f-c96c-4cb2-b0d8-e9e233215e3b"), new Guid("3e5ff496-e40d-4a59-baf9-30081918f445") });

            migrationBuilder.DeleteData(
                table: "OrdersProducts",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("377c779f-c96c-4cb2-b0d8-e9e233215e3b"), new Guid("7e9729b8-9704-4a0b-ae39-036cacae09f6") });

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("377c779f-c96c-4cb2-b0d8-e9e233215e3b"));

            migrationBuilder.RenameColumn(
                name: "ClientId",
                table: "Orders",
                newName: "CustomerId");

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CustomerId" },
                values: new object[] { new Guid("80cdd625-47e1-46aa-bf35-ec3547737b8c"), new Guid("354d06be-9c1d-4b8b-a7d7-79f10c5beebb") });

            migrationBuilder.InsertData(
                table: "OrdersProducts",
                columns: new[] { "OrderId", "ProductId" },
                values: new object[] { new Guid("80cdd625-47e1-46aa-bf35-ec3547737b8c"), new Guid("7e9729b8-9704-4a0b-ae39-036cacae09f6") });

            migrationBuilder.InsertData(
                table: "OrdersProducts",
                columns: new[] { "OrderId", "ProductId" },
                values: new object[] { new Guid("80cdd625-47e1-46aa-bf35-ec3547737b8c"), new Guid("3e5ff496-e40d-4a59-baf9-30081918f445") });

            migrationBuilder.InsertData(
                table: "OrdersProducts",
                columns: new[] { "OrderId", "ProductId" },
                values: new object[] { new Guid("80cdd625-47e1-46aa-bf35-ec3547737b8c"), new Guid("11253e54-ed71-466c-9e7a-430fc14a17b9") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrdersProducts",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("80cdd625-47e1-46aa-bf35-ec3547737b8c"), new Guid("11253e54-ed71-466c-9e7a-430fc14a17b9") });

            migrationBuilder.DeleteData(
                table: "OrdersProducts",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("80cdd625-47e1-46aa-bf35-ec3547737b8c"), new Guid("3e5ff496-e40d-4a59-baf9-30081918f445") });

            migrationBuilder.DeleteData(
                table: "OrdersProducts",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("80cdd625-47e1-46aa-bf35-ec3547737b8c"), new Guid("7e9729b8-9704-4a0b-ae39-036cacae09f6") });

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("80cdd625-47e1-46aa-bf35-ec3547737b8c"));

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "Orders",
                newName: "ClientId");

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "ClientId" },
                values: new object[] { new Guid("377c779f-c96c-4cb2-b0d8-e9e233215e3b"), new Guid("354d06be-9c1d-4b8b-a7d7-79f10c5beebb") });

            migrationBuilder.InsertData(
                table: "OrdersProducts",
                columns: new[] { "OrderId", "ProductId" },
                values: new object[] { new Guid("377c779f-c96c-4cb2-b0d8-e9e233215e3b"), new Guid("7e9729b8-9704-4a0b-ae39-036cacae09f6") });

            migrationBuilder.InsertData(
                table: "OrdersProducts",
                columns: new[] { "OrderId", "ProductId" },
                values: new object[] { new Guid("377c779f-c96c-4cb2-b0d8-e9e233215e3b"), new Guid("3e5ff496-e40d-4a59-baf9-30081918f445") });

            migrationBuilder.InsertData(
                table: "OrdersProducts",
                columns: new[] { "OrderId", "ProductId" },
                values: new object[] { new Guid("377c779f-c96c-4cb2-b0d8-e9e233215e3b"), new Guid("11253e54-ed71-466c-9e7a-430fc14a17b9") });
        }
    }
}
