using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ComputerRepair.Migrations
{
    /// <inheritdoc />
    public partial class AddRecord : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerID", "Address", "CustomerName", "Email", "Phone" },
                values: new object[,]
                {
                    { 1, "Thành phố Hồ Chí Minh", "Trần Hoàng A", "tranhoanga@gmail.com", "0234823423" },
                    { 2, "Thành phố Hồ Chí Minh", "Trần Hoàng A", "tranhoangb@gmail.com", "0234823423" },
                    { 3, "Thành phố Hồ Chí Minh", "Trần Hoàng C", "tranhoangc@gmail.com", "0232343423" },
                    { 4, "Thành phố Hồ Chí Minh", "Trần Hoàng D", "tranhoangd@gmail.com", "0234822453" },
                    { 5, "Thành phố Hồ Chí Minh", "Trần Hoàng E", "tranhoange@gmail.com", "0223452323" },
                    { 6, "Thành phố Hồ Chí Minh", "Trần Hoàng F", "tranhoangf@gmail.com", "0234752423" }
                });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "DeviceID", "Description", "DeviceName", "Manufacturer", "Quantity" },
                values: new object[,]
                {
                    { 1, "Bàn phím máy tính cơ học đen trắng", "Bàn phím", "Logitech", 10 },
                    { 2, "Chuột máy tính không dây màu đen", "Chuột", "Microsoft", 15 },
                    { 3, "Màn hình LCD 24 inch màu đen", "Màn hình", "Samsung", 5 },
                    { 4, "Pin laptop chính hãng", "Pin", "Samsung", 5 },
                    { 5, "Không sử dụng linh kiện", "Không", "Không", 0 }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleID", "RoleName" },
                values: new object[,]
                {
                    { 1, "Admin" },
                    { 2, "Employee" }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "ServiceID", "Description", "ServiceName" },
                values: new object[,]
                {
                    { 1, "Thay pin laptop chính hãng", "Thay pin laptop" },
                    { 2, "Cài đặt phần mềm đa dạng", "Cài đặt phần mềm" },
                    { 3, "Sửa màn hình laptop, máy tính", "Sửa màn hình" },
                    { 4, "Vệ sinh laptop, tản nhiệt", "Vệ sinh laptop" },
                    { 5, "Thay bàn phím laptop, máy tính", "Thay bàn phím laptop" },
                    { 6, "Cài đặt hệ điều hành cho máy tính", "Cài đặt hệ điều hành" },
                    { 7, "Cung cấp linh kiện cho máy tính", "Linh kiện" }
                });

            migrationBuilder.InsertData(
                table: "DevicesServices",
                columns: new[] { "DeviceServiceID", "DeviceID", "Price", "ServiceID" },
                values: new object[,]
                {
                    { 1, 4, 1000, 1 },
                    { 2, 5, 5, 2 },
                    { 3, 3, 6, 3 }
                });

            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "InvoiceID", "CustomerID", "InvoiceDate", "TotalPrice" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 4, 14, 1, 21, 53, 241, DateTimeKind.Local).AddTicks(9179), 0m },
                    { 2, 2, new DateTime(2023, 4, 14, 1, 21, 53, 241, DateTimeKind.Local).AddTicks(9194), 0m },
                    { 3, 3, new DateTime(2023, 4, 14, 1, 21, 53, 241, DateTimeKind.Local).AddTicks(9195), 0m },
                    { 4, 4, new DateTime(2023, 4, 14, 1, 21, 53, 241, DateTimeKind.Local).AddTicks(9196), 0m },
                    { 5, 5, new DateTime(2023, 4, 14, 1, 21, 53, 241, DateTimeKind.Local).AddTicks(9197), 0m },
                    { 6, 6, new DateTime(2023, 4, 14, 1, 21, 53, 241, DateTimeKind.Local).AddTicks(9199), 0m }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "Address", "Email", "FullName", "Password", "Phone", "RoleID", "Username" },
                values: new object[,]
                {
                    { 1, "Thành phố Hồ Chí Minh", "admin1@gmail.com", "Nguyễn Văn A", "admin1", "0123456789", 1, "admin1" },
                    { 2, "Thành phố Hồ Chí Minh", "admin2@gmail.com", "Nguyễn Văn B", "admin2", "01234523489", 1, "admin2" },
                    { 3, "Thành phố Hồ Chí Minh", "employee1@gmail.com", "Lê Văn A", "employee1", "0234823434", 2, "employee1" },
                    { 4, "Thành phố Hồ Chí Minh", "employee2@gmail.com", "Lê Văn B", "employee2", "0284928394", 2, "employee2" }
                });

            migrationBuilder.InsertData(
                table: "Requests",
                columns: new[] { "RequestID", "DeviceServiceID", "InvoiceID", "Quantity" },
                values: new object[,]
                {
                    { 1, 1, 1, 1 },
                    { 2, 2, 1, 1 },
                    { 3, 3, 2, 1 },
                    { 4, 1, 2, 1 },
                    { 5, 2, 3, 1 },
                    { 6, 3, 4, 1 },
                    { 7, 1, 5, 1 },
                    { 8, 2, 6, 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Requests",
                keyColumn: "RequestID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Requests",
                keyColumn: "RequestID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Requests",
                keyColumn: "RequestID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Requests",
                keyColumn: "RequestID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Requests",
                keyColumn: "RequestID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Requests",
                keyColumn: "RequestID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Requests",
                keyColumn: "RequestID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Requests",
                keyColumn: "RequestID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "ServiceID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "ServiceID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "ServiceID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "ServiceID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "DevicesServices",
                keyColumn: "DeviceServiceID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DevicesServices",
                keyColumn: "DeviceServiceID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DevicesServices",
                keyColumn: "DeviceServiceID",
                keyValue: 3);

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

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "ServiceID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "ServiceID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "ServiceID",
                keyValue: 3);
        }
    }
}
