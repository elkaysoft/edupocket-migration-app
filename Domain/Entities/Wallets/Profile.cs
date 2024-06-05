using Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Wallets
{
    [Table("Profile", Schema = "Wallet")]
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
        public string? TransactionPinHash { get; set; }
        public ProfileType UserType { get; set; }        
        public Beneficiary Beneficiary { get; set;}
    }
}
