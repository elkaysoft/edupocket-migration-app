using Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Wallets
{
    [Table("Transactions", Schema = "Wallet")]
    public class Transaction: BaseEntity<Guid>
    {        
        public Guid SourceWalletId { get; set; }
        public TransactionType TransactionType { get; set; }
        public TransactionRecordType TransactionRecordType { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public TransactionStatus TransactionStatus { get; set; }
        public string TransactionReference { get; set; }
        public string? DestinationBankCode { get; set; }
        public string? DestinationBankName { get; set; }
        public string? DestinationAccountNumber { get; set; }
        public string? DestinationAccountName { get; set; }
        public Guid? DestinationWalletId { get; set; }
        public string Checksum { get; set; }
        public string ServiceResponse { get; set; }

        public virtual Wallet SourceWallet { get; set; }
        public virtual Wallet DestinationWallet { get; set;}
        public virtual Wallet Wallet { get; set; }
    }
}
