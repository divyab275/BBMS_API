using Microsoft.EntityFrameworkCore.Migrations;

namespace BBMS_API.Migrations
{
    public partial class AddeDaColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "BloodCamps",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "BloodCamps");
        }
    }
}
