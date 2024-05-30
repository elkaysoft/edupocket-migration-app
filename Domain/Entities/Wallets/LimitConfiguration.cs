using Domain.Enums;

namespace Domain.Entities.Wallets
{
    public class LimitConfiguration: BaseEntity<Guid>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal MaxBalanceLimit { get; set; }
        public decimal SingleLimit { get; set; }
        public decimal CumulativeLimit { get; set; }
        public UserType UserType { get; set; }
        public bool IsActive { get; set; }
    }
}
