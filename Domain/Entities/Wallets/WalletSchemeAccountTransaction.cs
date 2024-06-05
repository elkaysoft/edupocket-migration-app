using Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Wallets
{
    [Table("WalletSchemeAccountTransaction", Schema = "Wallet")]
    public class WalletSchemeAccountTransaction: BaseEntity<Guid>
    {
        public Guid WalletSchemeAccountId { get; set; }
        public Guid? TransactionId { get; set; }
        public string? Description { get; set; }
        public decimal Amount { get; set; }
        public TransactionRecordType TransactionRecordType { get; set; }        
        public string? TransactionReference { get; set; }
        public string? CheckSum { get; set; }
        public virtual Transaction Transaction { get; set; }
        public virtual WalletSchemeAccount  WalletSchemeAccount { get; set; }
    }
}
