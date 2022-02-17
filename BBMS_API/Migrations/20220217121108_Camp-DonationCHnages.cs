using Microsoft.EntityFrameworkCore.Migrations;

namespace BBMS_API.Migrations
{
    public partial class CampDonationCHnages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Donations_BloodBanks_BloodBankID",
                table: "Donations");

            migrationBuilder.RenameColumn(
                name: "BloodBankID",
                table: "Donations",
                newName: "BloodCampID");

            migrationBuilder.RenameIndex(
                name: "IX_Donations_BloodBankID",
                table: "Donations",
                newName: "IX_Donations_BloodCampID");

            migrationBuilder.AddForeignKey(
                name: "FK_Donations_BloodCamps_BloodCampID",
                table: "Donations",
                column: "BloodCampID",
                principalTable: "BloodCamps",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Donations_BloodCamps_BloodCampID",
                table: "Donations");

            migrationBuilder.RenameColumn(
                name: "BloodCampID",
                table: "Donations",
                newName: "BloodBankID");

            migrationBuilder.RenameIndex(
                name: "IX_Donations_BloodCampID",
                table: "Donations",
                newName: "IX_Donations_BloodBankID");

            migrationBuilder.AddForeignKey(
                name: "FK_Donations_BloodBanks_BloodBankID",
                table: "Donations",
                column: "BloodBankID",
                principalTable: "BloodBanks",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
