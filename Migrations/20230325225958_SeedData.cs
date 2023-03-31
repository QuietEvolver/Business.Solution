using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusinessApi.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Businesss",
                columns: new[] { "BusinessId", "Age", "Name", "Species" },
                values: new object[,]
                {
                    { 1, 7, "Matilda", "Wooly Mammoth" },
                    { 2, 10, "Rexi", "Dinosaur" },
                    { 3, 2, "Matilda", "Dinosaur" },
                    { 4, 4, "Pip", "Shark" },
                    { 5, 22, "Bartholomew", "Dinosaur" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Businesss",
                keyColumn: "BusinessId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Businesss",
                keyColumn: "BusinessId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Businesss",
                keyColumn: "BusinessId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Businesss",
                keyColumn: "BusinessId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Businesss",
                keyColumn: "BusinessId",
                keyValue: 5);
        }
    }
}
