using Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Wallets
{
    [Table("VirtualWallets", Schema = "Wallet")]
    public class Wallet: BaseEntity<Guid>
    {
        public string WalletNumber { get; set; }
        public decimal Balance { get; set; }
        public Guid ProfileId { get; set; }
        public Status Status { get; set; }
        public string CheckSum { get; set; }
        public bool IsPndActive { get; set; }    

        public ICollection<WalletBalanceHistory> BalanceHistory { get; set; }
        public ICollection<Transaction> Transactions { get; set; }
    }
}
