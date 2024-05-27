using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations.WalletsDb
{
    /// <inheritdoc />
    public partial class WLT0008 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Beneficiary_WalletNumber",
                table: "Profiles",
                newName: "BeneficiaryWalletNumber");

            migrationBuilder.RenameColumn(
                name: "Beneficiary_NickName",
                table: "Profiles",
                newName: "BeneficiaryNickName");

            migrationBuilder.RenameColumn(
                name: "Beneficiary_Name",
                table: "Profiles",
                newName: "BeneficiaryAccountName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BeneficiaryWalletNumber",
                table: "Profiles",
                newName: "Beneficiary_WalletNumber");

            migrationBuilder.RenameColumn(
                name: "BeneficiaryNickName",
                table: "Profiles",
                newName: "Beneficiary_NickName");

            migrationBuilder.RenameColumn(
                name: "BeneficiaryAccountName",
                table: "Profiles",
                newName: "Beneficiary_Name");
        }
    }
}
