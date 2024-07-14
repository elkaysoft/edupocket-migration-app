using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations.WalletsDb
{
    /// <inheritdoc />
    public partial class RemovalOfWalletSchemeFromWalletEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Wallets_WalletSchemes_WalletSchemeId",
                table: "Wallets");

            migrationBuilder.DropForeignKey(
                name: "FK_WalletSchemeAccounts_WalletSchemes_WalletSchemeId",
                table: "WalletSchemeAccounts");

            migrationBuilder.DropTable(
                name: "WalletSchemes");

            migrationBuilder.DropTable(
                name: "LimitConfigurations");

            migrationBuilder.DropIndex(
                name: "IX_WalletSchemeAccounts_WalletSchemeId",
                table: "WalletSchemeAccounts");

            migrationBuilder.DropIndex(
                name: "IX_Wallets_WalletSchemeId",
                table: "Wallets");

            migrationBuilder.DropColumn(
                name: "WalletSchemeId",
                table: "WalletSchemeAccounts");

            migrationBuilder.DropColumn(
                name: "WalletSchemeId",
                table: "Wallets");

            migrationBuilder.AddColumn<string>(
                name: "UserType",
                table: "WalletSchemeAccounts",
                type: "nvarchar(58)",
                maxLength: 58,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserType",
                table: "WalletSchemeAccounts");

            migrationBuilder.AddColumn<Guid>(
                name: "WalletSchemeId",
                table: "WalletSchemeAccounts",
                type: "uniqueidentifier",
                maxLength: 58,
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "WalletSchemeId",
                table: "Wallets",
                type: "uniqueidentifier",
                maxLength: 50,
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "LimitConfigurations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedByIp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CumulativeLimit = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    MaxBalanceLimit = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    ModifiedByIp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SingleLimit = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UserType = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LimitConfigurations", x => x.Id);
                },
                comment: "The table stores limit configuration records");

            migrationBuilder.CreateTable(
                name: "WalletSchemes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LimitConfigurationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(28)", maxLength: 28, nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedByIp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedByIp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    WalletSchemeType = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WalletSchemes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WalletSchemes_LimitConfigurations_LimitConfigurationId",
                        column: x => x.LimitConfigurationId,
                        principalTable: "LimitConfigurations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "The table stores wallet scheme information");

            migrationBuilder.CreateIndex(
                name: "IX_WalletSchemeAccounts_WalletSchemeId",
                table: "WalletSchemeAccounts",
                column: "WalletSchemeId");

            migrationBuilder.CreateIndex(
                name: "IX_Wallets_WalletSchemeId",
                table: "Wallets",
                column: "WalletSchemeId");

            migrationBuilder.CreateIndex(
                name: "IX_WalletSchemes_LimitConfigurationId",
                table: "WalletSchemes",
                column: "LimitConfigurationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Wallets_WalletSchemes_WalletSchemeId",
                table: "Wallets",
                column: "WalletSchemeId",
                principalTable: "WalletSchemes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WalletSchemeAccounts_WalletSchemes_WalletSchemeId",
                table: "WalletSchemeAccounts",
                column: "WalletSchemeId",
                principalTable: "WalletSchemes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
