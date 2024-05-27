using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations.WalletsDb
{
    /// <inheritdoc />
    public partial class WLT0007 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Beneficiary_Name",
                table: "Profiles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Beneficiary_NickName",
                table: "Profiles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Beneficiary_WalletNumber",
                table: "Profiles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Beneficiary_Name",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "Beneficiary_NickName",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "Beneficiary_WalletNumber",
                table: "Profiles");
        }
    }
}
