using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations.WalletsDb
{
    /// <inheritdoc />
    public partial class IntroducedWalletSchemeEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Wallets_Profiles_ProfileId",
                table: "Wallets");

            migrationBuilder.DropIndex(
                name: "IX_Wallets_ProfileId",
                table: "Wallets");

            migrationBuilder.AddColumn<Guid>(
                name: "WalletSchemeId",
                table: "Wallets",
                type: "uniqueidentifier",
                maxLength: 50,
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<string>(
                name: "UserType",
                table: "Profiles",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 20);

            migrationBuilder.AddColumn<string>(
                name: "TransactionPinHash",
                table: "Profiles",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "LimitConfigurations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    MaxBalanceLimit = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    SingleLimit = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    CumulativeLimit = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    UserType = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByIp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedByIp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
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
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(28)", maxLength: 28, nullable: false),
                    IsActive = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LimitConfigurationId = table.Column<Guid>(type: "uniqueidentifier", maxLength: 50, nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByIp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedByIp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
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

            migrationBuilder.CreateTable(
                name: "WalletSchemeAccounts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WalletSchemeId = table.Column<Guid>(type: "uniqueidentifier", maxLength: 58, nullable: false),
                    AccountNumber = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Balance = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    CheckSum = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByIp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedByIp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WalletSchemeAccounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WalletSchemeAccounts_WalletSchemes_WalletSchemeId",
                        column: x => x.WalletSchemeId,
                        principalTable: "WalletSchemes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "The table stores wallet scheme account records");

            migrationBuilder.CreateIndex(
                name: "IX_Wallets_WalletSchemeId",
                table: "Wallets",
                column: "WalletSchemeId");

            migrationBuilder.CreateIndex(
                name: "IX_WalletSchemeAccounts_WalletSchemeId",
                table: "WalletSchemeAccounts",
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Wallets_WalletSchemes_WalletSchemeId",
                table: "Wallets");

            migrationBuilder.DropTable(
                name: "WalletSchemeAccounts");

            migrationBuilder.DropTable(
                name: "WalletSchemes");

            migrationBuilder.DropTable(
                name: "LimitConfigurations");

            migrationBuilder.DropIndex(
                name: "IX_Wallets_WalletSchemeId",
                table: "Wallets");

            migrationBuilder.DropColumn(
                name: "WalletSchemeId",
                table: "Wallets");

            migrationBuilder.DropColumn(
                name: "TransactionPinHash",
                table: "Profiles");

            migrationBuilder.AlterColumn<int>(
                name: "UserType",
                table: "Profiles",
                type: "int",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.CreateIndex(
                name: "IX_Wallets_ProfileId",
                table: "Wallets",
                column: "ProfileId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Wallets_Profiles_ProfileId",
                table: "Wallets",
                column: "ProfileId",
                principalTable: "Profiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
