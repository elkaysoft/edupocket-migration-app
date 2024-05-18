using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Wallet
{
    public class Profile: BaseEntity<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string OtherName { get; set; }
        public string EmailAddress { get; set; }
        public string MobileNumber { get; set; }        
        public string Gender { get; set; }
        public string CheckSum { get; set; }        
        public string? ProfileImage { get; set; }
        public UserType UserType { get; set; }
    }
}
