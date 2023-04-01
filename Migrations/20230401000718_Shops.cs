using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusinessApi.Migrations
{
    public partial class Shops : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 1,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Matilda's Bistro", "Restaurant" });

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 2,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Rexi Teacups", "Shop" });

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 3,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Matilda Toys", "Shop" });

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 4,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Pip's Pizza & Brew", "Restaurant" });

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 5,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Bartholomew Pet Shop", "Shop" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 1,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Matilda", "Wooly Mammoth" });

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 2,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Rexi", "Dinosaur" });

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 3,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Matilda", "Dinosaur" });

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 4,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Pip", "Shark" });

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 5,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Bartholomew", "Dinosaur" });
        }
    }
}
