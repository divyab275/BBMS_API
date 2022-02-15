using Microsoft.EntityFrameworkCore.Migrations;

namespace BBMS_API.Migrations
{
    public partial class BloodGroupAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BloodGroup",
                table: "Donors",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BloodGroup",
                table: "Donors");
        }
    }
}
