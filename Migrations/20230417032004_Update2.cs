using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ComputerRepair.Migrations
{
    /// <inheritdoc />
    public partial class Update2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "InvoiceID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "InvoiceID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "InvoiceID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "InvoiceID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "InvoiceID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "InvoiceID",
                keyValue: 6);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "InvoiceID", "CustomerID", "InvoiceDate", "TotalPrice" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 4, 17, 10, 14, 8, 678, DateTimeKind.Local).AddTicks(617), 0m },
                    { 2, 2, new DateTime(2023, 4, 17, 10, 14, 8, 678, DateTimeKind.Local).AddTicks(627), 0m },
                    { 3, 3, new DateTime(2023, 4, 17, 10, 14, 8, 678, DateTimeKind.Local).AddTicks(628), 0m },
                    { 4, 4, new DateTime(2023, 4, 17, 10, 14, 8, 678, DateTimeKind.Local).AddTicks(629), 0m },
                    { 5, 5, new DateTime(2023, 4, 17, 10, 14, 8, 678, DateTimeKind.Local).AddTicks(630), 0m },
                    { 6, 6, new DateTime(2023, 4, 17, 10, 14, 8, 678, DateTimeKind.Local).AddTicks(632), 0m }
                });
        }
    }
}
