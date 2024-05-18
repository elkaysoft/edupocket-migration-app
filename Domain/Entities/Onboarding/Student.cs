using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Onboarding
{
    public class Student: BaseEntity<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? OtherNames { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string Gender { get; set; }
        public string? Department { get; set; }
        public string Institution { get; set; }
        public string? CurrentLevel { get; set; }
        public string WalletNumber { get; set; }
        public Status Status { get; set; }
        public string CheckSum { get; set; }

    }
}
