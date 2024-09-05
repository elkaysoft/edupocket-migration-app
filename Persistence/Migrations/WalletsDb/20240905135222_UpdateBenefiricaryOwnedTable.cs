using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations.WalletsDb
{
    /// <inheritdoc />
    public partial class UpdateBenefiricaryOwnedTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BeneficiaryAccountName",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "BeneficiaryNickName",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "BeneficiaryWalletNumber",
                table: "Profiles");

            migrationBuilder.CreateTable(
                name: "Beneficiaries",
                columns: table => new
                {
                    ProfileId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BeneficiaryAccountName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    BeneficiaryWalletNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    BeneficiaryNickName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Beneficiaries", x => x.ProfileId);
                    table.ForeignKey(
                        name: "FK_Beneficiaries_Profiles_ProfileId",
                        column: x => x.ProfileId,
                        principalTable: "Profiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Beneficiaries");

            migrationBuilder.AddColumn<string>(
                name: "BeneficiaryAccountName",
                table: "Profiles",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BeneficiaryNickName",
                table: "Profiles",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BeneficiaryWalletNumber",
                table: "Profiles",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "");
        }
    }
}
