using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Identity
{
    public class User: BaseEntity<long>
    {
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public string TransactionPinHash { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public Status Status { get; set; }
        public bool IsEmailConfirmed { get; set; }
        public bool LockoutEnabled { get; set; }
        public int FailedLoginCount { get; set; }        
        public DateTime? LastLoginDate { get; set; }
        public bool ForceChangePassword { get; set; }
        public bool ForceChangeTransactionPin { get; set; }
    }
}
