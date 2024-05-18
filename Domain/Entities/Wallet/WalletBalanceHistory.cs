using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Wallet
{
    public class WalletBalanceHistory: BaseEntity<Guid>
    {
        public string WalletNumber { get; set; }
        public Guid TransactionId { get; set; }
        public decimal OpeningBalance { get; set; }
        public decimal ClosingBalance { get; set; }
        public string CheckSum { get; set; }

    }
}
