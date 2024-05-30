using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Wallets
{
    [Table("PinChangeHistories", Schema = "Wallet")]
    public class PinChangeHistory: BaseEntity<long>
    {
        public Guid ProfileId { get; set; }
        public string PinHash { get; set; }
    }
}
