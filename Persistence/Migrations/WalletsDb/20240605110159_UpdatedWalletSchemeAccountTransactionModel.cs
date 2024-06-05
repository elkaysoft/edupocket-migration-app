using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations.WalletsDb
{
    /// <inheritdoc />
    public partial class UpdatedWalletSchemeAccountTransactionModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_WalletSchemeAccountsTransactions_TransactionId",
                table: "WalletSchemeAccountsTransactions",
                column: "TransactionId");

            migrationBuilder.CreateIndex(
                name: "IX_WalletSchemeAccountsTransactions_WalletSchemeAccountId",
                table: "WalletSchemeAccountsTransactions",
                column: "WalletSchemeAccountId");

            migrationBuilder.AddForeignKey(
                name: "FK_WalletSchemeAccountsTransactions_Transactions_TransactionId",
                table: "WalletSchemeAccountsTransactions",
                column: "TransactionId",
                principalTable: "Transactions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WalletSchemeAccountsTransactions_WalletSchemeAccounts_WalletSchemeAccountId",
                table: "WalletSchemeAccountsTransactions",
                column: "WalletSchemeAccountId",
                principalTable: "WalletSchemeAccounts",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WalletSchemeAccountsTransactions_Transactions_TransactionId",
                table: "WalletSchemeAccountsTransactions");

            migrationBuilder.DropForeignKey(
                name: "FK_WalletSchemeAccountsTransactions_WalletSchemeAccounts_WalletSchemeAccountId",
                table: "WalletSchemeAccountsTransactions");

            migrationBuilder.DropIndex(
                name: "IX_WalletSchemeAccountsTransactions_TransactionId",
                table: "WalletSchemeAccountsTransactions");

            migrationBuilder.DropIndex(
                name: "IX_WalletSchemeAccountsTransactions_WalletSchemeAccountId",
                table: "WalletSchemeAccountsTransactions");
        }
    }
}
