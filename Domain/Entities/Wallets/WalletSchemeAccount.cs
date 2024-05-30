using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Wallets
{
    public class WalletSchemeAccount: BaseEntity<Guid>
    {
        public Guid WalletSchemeId { get; set; }
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }
        public string CheckSum { get; set; }
        public virtual WalletScheme WalletScheme { get; set; }
    }
}
