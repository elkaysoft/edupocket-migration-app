namespace Domain.Entities.Wallets
{
    public class WalletScheme: BaseEntity<Guid>
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string IsActive { get; set; }
        public Guid LimitConfigurationId { get; set; }
        public virtual LimitConfiguration LimitConfiguration { get; set; }
    }
}
