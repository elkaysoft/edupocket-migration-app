using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations.WalletsDb
{
    /// <inheritdoc />
    public partial class RenamedSomeEntitiesOnWalletContext : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WalletSchemeAccountsTransactions");

            migrationBuilder.DropTable(
                name: "WalletSchemeAccounts");

            migrationBuilder.CreateTable(
                name: "SystemWalletAccount",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserType = table.Column<string>(type: "nvarchar(58)", maxLength: 58, nullable: false),
                    TransactionType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
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
                    table.PrimaryKey("PK_SystemWalletAccount", x => x.Id);
                },
                comment: "The table stores wallet scheme account records");

            migrationBuilder.CreateTable(
                name: "SystemWalletAccountTransaction",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WalletSchemeAccountId = table.Column<Guid>(type: "uniqueidentifier", maxLength: 50, nullable: false),
                    TransactionId = table.Column<Guid>(type: "uniqueidentifier", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    TransactionRecordType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TransactionReference = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
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
                    table.PrimaryKey("PK_SystemWalletAccountTransaction", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SystemWalletAccountTransaction_SystemWalletAccount_WalletSchemeAccountId",
                        column: x => x.WalletSchemeAccountId,
                        principalTable: "SystemWalletAccount",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SystemWalletAccountTransaction_Transactions_TransactionId",
                        column: x => x.TransactionId,
                        principalTable: "Transactions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "The table holds wallet scheme account transactions");

            migrationBuilder.CreateIndex(
                name: "IX_SystemWalletAccountTransaction_TransactionId",
                table: "SystemWalletAccountTransaction",
                column: "TransactionId");

            migrationBuilder.CreateIndex(
                name: "IX_SystemWalletAccountTransaction_WalletSchemeAccountId",
                table: "SystemWalletAccountTransaction",
                column: "WalletSchemeAccountId");

            migrationBuilder.InsertData(
                table: "SystemWalletAccount",
                columns: new[] { 
                    "Id",
                    "UserType",
                    "TransactionType", 
                    "AccountNumber",
                    "Balance", 
                    "CheckSum", 
                    "CreatedBy", 
                    "DateCreated", 
                    "IsDeleted" },
                values: new object[,]
                {
                    { Guid.NewGuid(), "Student", "Wallet Inflow", "INF-100001-1036", 0M, "9939", "SYSTEM", DateTime.Now, false },
                    { Guid.NewGuid(), "Student", "Local Transfer", "LFT-100002-1037", 0M, "9939", "SYSTEM", DateTime.Now, false },
                    { Guid.NewGuid(), "Student", "Outbound Transfer", "OTB-100003-1038", 0M, "9939", "SYSTEM", DateTime.Now, false },
                    { Guid.NewGuid(), "Vendor", "Wallet Inflow", "INF-200001-2036", 0M, "9939", "SYSTEM", DateTime.Now, false },
                    { Guid.NewGuid(), "Vendor", "Local Transfer", "LFT-200002-2037", 0M, "9939", "SYSTEM", DateTime.Now, false },
                    { Guid.NewGuid(), "Vendor", "Outbound Transfer", "OTB-200003-2038", 0M, "9939", "SYSTEM", DateTime.Now, false },
                });

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SystemWalletAccountTransaction");

            migrationBuilder.DropTable(
                name: "SystemWalletAccount");

            migrationBuilder.CreateTable(
                name: "WalletSchemeAccounts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AccountNumber = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Balance = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    CheckSum = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedByIp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedByIp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UserType = table.Column<string>(type: "nvarchar(58)", maxLength: 58, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WalletSchemeAccounts", x => x.Id);
                },
                comment: "The table stores wallet scheme account records");

            migrationBuilder.CreateTable(
                name: "WalletSchemeAccountsTransactions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TransactionId = table.Column<Guid>(type: "uniqueidentifier", maxLength: 50, nullable: false),
                    WalletSchemeAccountId = table.Column<Guid>(type: "uniqueidentifier", maxLength: 50, nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    CheckSum = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedByIp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedByIp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TransactionRecordType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TransactionReference = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WalletSchemeAccountsTransactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WalletSchemeAccountsTransactions_Transactions_TransactionId",
                        column: x => x.TransactionId,
                        principalTable: "Transactions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WalletSchemeAccountsTransactions_WalletSchemeAccounts_WalletSchemeAccountId",
                        column: x => x.WalletSchemeAccountId,
                        principalTable: "WalletSchemeAccounts",
                        principalColumn: "Id");
                },
                comment: "The table holds wallet scheme account transactions");

            migrationBuilder.CreateIndex(
                name: "IX_WalletSchemeAccountsTransactions_TransactionId",
                table: "WalletSchemeAccountsTransactions",
                column: "TransactionId");

            migrationBuilder.CreateIndex(
                name: "IX_WalletSchemeAccountsTransactions_WalletSchemeAccountId",
                table: "WalletSchemeAccountsTransactions",
                column: "WalletSchemeAccountId");
        }
    }
}
