using Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Wallets
{
    [Table("SystemWalletAccount", Schema = "Wallet")]
    public class SystemWalletAccount: BaseEntity<Guid>
    {
        public ProfileType UserType { get; set; }
        public TransactionType TransactionType { get; set; }
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }
        public string CheckSum { get; set; }        
    }
}
