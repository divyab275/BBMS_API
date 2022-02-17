using Microsoft.EntityFrameworkCore.Migrations;

namespace BBMS_API.Migrations
{
    public partial class modelBuilderChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BloodCampID1",
                table: "Donations",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Donations_BloodCampID1",
                table: "Donations",
                column: "BloodCampID1");

            migrationBuilder.AddForeignKey(
                name: "FK_Donations_BloodCamps_BloodCampID1",
                table: "Donations",
                column: "BloodCampID1",
                principalTable: "BloodCamps",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Donations_BloodCamps_BloodCampID1",
                table: "Donations");

            migrationBuilder.DropIndex(
                name: "IX_Donations_BloodCampID1",
                table: "Donations");

            migrationBuilder.DropColumn(
                name: "BloodCampID1",
                table: "Donations");
        }
    }
}
