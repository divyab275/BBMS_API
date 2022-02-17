using Microsoft.EntityFrameworkCore.Migrations;

namespace BBMS_API.Migrations
{
    public partial class donationChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Donations_DonorID",
                table: "Donations",
                column: "DonorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Donations_Donors_DonorID",
                table: "Donations",
                column: "DonorID",
                principalTable: "Donors",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Donations_Donors_DonorID",
                table: "Donations");

            migrationBuilder.DropIndex(
                name: "IX_Donations_DonorID",
                table: "Donations");
        }
    }
}
