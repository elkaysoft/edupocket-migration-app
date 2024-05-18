using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Onboarding
{
    public class Vendor: BaseEntity<Guid>
    {
        public string BusinessName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BusinessType { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string? SettlementAccount { get; set; }
        public string? Address { get; set; }
        public Status Status { get; set; }
        public string CheckSum { get; set; }
        public OnboardingStatus OnboardingStatus { get; set; }
        public string WalletNumber { get; set; }
        public string Institution { get; set; }
    }
}
