using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Wallets
{
    [Table("WalletBalanceHistories", Schema = "Wallet")]
    /// <summary>
    /// Class WalletBalanceHistory
    /// </summary>
    public class WalletBalanceHistory: BaseEntity<Guid>
    {
        /// <summary>
        /// Wallet Id
        /// </summary>
        public Guid WalletId { get; set; }
        /// <summary>
        /// TransactionId
        /// </summary>
        public Guid TransactionId { get; set; }
        /// <summary>
        /// OpeningBalance
        /// </summary>
        public decimal OpeningBalance { get; set; }
        /// <summary>
        /// The ClosingBalance
        /// </summary>
        public decimal ClosingBalance { get; set; }
        /// <summary>
        /// The CheckSum
        /// </summary>
        public string CheckSum { get; set; }
        /// <summary>
        /// Gets or sets the wallet.
        /// </summary>
        /// <value>
        /// The wallet.
        /// </value>
        public virtual Wallet Wallet { get; set; }

    }
}
