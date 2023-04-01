using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusinessApi.Migrations
{
    public partial class NewFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Species",
                table: "Businesses",
                newName: "Type");

            migrationBuilder.RenameColumn(
                name: "Age",
                table: "Businesses",
                newName: "YearsInBusiness");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "YearsInBusiness",
                table: "Businesses",
                newName: "Age");

            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Businesses",
                newName: "Species");
        }
    }
}
