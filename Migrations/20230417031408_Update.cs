using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ComputerRepair.Migrations
{
    /// <inheritdoc />
    public partial class Update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_Requests_RequestxID",
                table: "Invoices");

            migrationBuilder.DropIndex(
                name: "IX_Invoices_RequestxID",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "RequestxID",
                table: "Invoices");

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "InvoiceID",
                keyValue: 1,
                column: "InvoiceDate",
                value: new DateTime(2023, 4, 17, 10, 14, 8, 678, DateTimeKind.Local).AddTicks(617));

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "InvoiceID",
                keyValue: 2,
                column: "InvoiceDate",
                value: new DateTime(2023, 4, 17, 10, 14, 8, 678, DateTimeKind.Local).AddTicks(627));

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "InvoiceID",
                keyValue: 3,
                column: "InvoiceDate",
                value: new DateTime(2023, 4, 17, 10, 14, 8, 678, DateTimeKind.Local).AddTicks(628));

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "InvoiceID",
                keyValue: 4,
                column: "InvoiceDate",
                value: new DateTime(2023, 4, 17, 10, 14, 8, 678, DateTimeKind.Local).AddTicks(629));

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "InvoiceID",
                keyValue: 5,
                column: "InvoiceDate",
                value: new DateTime(2023, 4, 17, 10, 14, 8, 678, DateTimeKind.Local).AddTicks(630));

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "InvoiceID",
                keyValue: 6,
                column: "InvoiceDate",
                value: new DateTime(2023, 4, 17, 10, 14, 8, 678, DateTimeKind.Local).AddTicks(632));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RequestxID",
                table: "Invoices",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "InvoiceID",
                keyValue: 1,
                columns: new[] { "InvoiceDate", "RequestxID" },
                values: new object[] { new DateTime(2023, 4, 17, 10, 12, 15, 83, DateTimeKind.Local).AddTicks(1259), null });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "InvoiceID",
                keyValue: 2,
                columns: new[] { "InvoiceDate", "RequestxID" },
                values: new object[] { new DateTime(2023, 4, 17, 10, 12, 15, 83, DateTimeKind.Local).AddTicks(1268), null });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "InvoiceID",
                keyValue: 3,
                columns: new[] { "InvoiceDate", "RequestxID" },
                values: new object[] { new DateTime(2023, 4, 17, 10, 12, 15, 83, DateTimeKind.Local).AddTicks(1269), null });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "InvoiceID",
                keyValue: 4,
                columns: new[] { "InvoiceDate", "RequestxID" },
                values: new object[] { new DateTime(2023, 4, 17, 10, 12, 15, 83, DateTimeKind.Local).AddTicks(1270), null });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "InvoiceID",
                keyValue: 5,
                columns: new[] { "InvoiceDate", "RequestxID" },
                values: new object[] { new DateTime(2023, 4, 17, 10, 12, 15, 83, DateTimeKind.Local).AddTicks(1272), null });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "InvoiceID",
                keyValue: 6,
                columns: new[] { "InvoiceDate", "RequestxID" },
                values: new object[] { new DateTime(2023, 4, 17, 10, 12, 15, 83, DateTimeKind.Local).AddTicks(1273), null });

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_RequestxID",
                table: "Invoices",
                column: "RequestxID");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_Requests_RequestxID",
                table: "Invoices",
                column: "RequestxID",
                principalTable: "Requests",
                principalColumn: "RequestxID");
        }
    }
}
