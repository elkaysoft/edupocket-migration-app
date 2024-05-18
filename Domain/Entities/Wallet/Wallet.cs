using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Wallet
{
    public class Wallet: BaseEntity<Guid>
    {
        public string WalletNumber { get; set; }
        public decimal Balance { get; set; }
        public Guid ProfileId { get; set; }
        public Status Status { get; set; }
        public string CheckSum { get; set; }
        public bool IsPndActive { get; set; }
    }
}
