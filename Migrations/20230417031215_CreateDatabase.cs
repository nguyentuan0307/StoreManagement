using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ComputerRepair.Migrations
{
    /// <inheritdoc />
    public partial class CreateDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerID);
                });

            migrationBuilder.CreateTable(
                name: "Devices",
                columns: table => new
                {
                    DeviceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeviceName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Devices", x => x.DeviceID);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RoleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RoleID);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    ServiceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.ServiceID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoleID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleID",
                        column: x => x.RoleID,
                        principalTable: "Roles",
                        principalColumn: "RoleID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Invoices",
                columns: table => new
                {
                    InvoiceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    InvoiceDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RequestxID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoices", x => x.InvoiceID);
                    table.ForeignKey(
                        name: "FK_Invoices_Customers_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customers",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Requests",
                columns: table => new
                {
                    RequestxID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceID = table.Column<int>(type: "int", nullable: false),
                    DeviceID = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    InvoiceID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requests", x => x.RequestxID);
                    table.ForeignKey(
                        name: "FK_Requests_Devices_DeviceID",
                        column: x => x.DeviceID,
                        principalTable: "Devices",
                        principalColumn: "DeviceID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Requests_Invoices_InvoiceID",
                        column: x => x.InvoiceID,
                        principalTable: "Invoices",
                        principalColumn: "InvoiceID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Requests_Services_ServiceID",
                        column: x => x.ServiceID,
                        principalTable: "Services",
                        principalColumn: "ServiceID",
                        onDelete: ReferentialAction.Cascade);
                });

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
                table: "Invoices",
                columns: new[] { "InvoiceID", "CustomerID", "InvoiceDate", "RequestxID", "TotalPrice" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 4, 17, 10, 12, 15, 83, DateTimeKind.Local).AddTicks(1259), null, 0m },
                    { 2, 2, new DateTime(2023, 4, 17, 10, 12, 15, 83, DateTimeKind.Local).AddTicks(1268), null, 0m },
                    { 3, 3, new DateTime(2023, 4, 17, 10, 12, 15, 83, DateTimeKind.Local).AddTicks(1269), null, 0m },
                    { 4, 4, new DateTime(2023, 4, 17, 10, 12, 15, 83, DateTimeKind.Local).AddTicks(1270), null, 0m },
                    { 5, 5, new DateTime(2023, 4, 17, 10, 12, 15, 83, DateTimeKind.Local).AddTicks(1272), null, 0m },
                    { 6, 6, new DateTime(2023, 4, 17, 10, 12, 15, 83, DateTimeKind.Local).AddTicks(1273), null, 0m }
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

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_CustomerID",
                table: "Invoices",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_RequestxID",
                table: "Invoices",
                column: "RequestxID");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_DeviceID",
                table: "Requests",
                column: "DeviceID");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_InvoiceID",
                table: "Requests",
                column: "InvoiceID");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_ServiceID",
                table: "Requests",
                column: "ServiceID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleID",
                table: "Users",
                column: "RoleID");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_Requests_RequestxID",
                table: "Invoices",
                column: "RequestxID",
                principalTable: "Requests",
                principalColumn: "RequestxID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_Customers_CustomerID",
                table: "Invoices");

            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_Requests_RequestxID",
                table: "Invoices");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Requests");

            migrationBuilder.DropTable(
                name: "Devices");

            migrationBuilder.DropTable(
                name: "Invoices");

            migrationBuilder.DropTable(
                name: "Services");
        }
    }
}
