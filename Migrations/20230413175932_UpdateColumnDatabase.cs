using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ComputerRepair.Migrations
{
    /// <inheritdoc />
    public partial class UpdateColumnDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "DevicesServices");

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Requests",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Requests");

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "DevicesServices",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
