using Domain.Enums;

namespace Domain.Entities.Wallets
{
    /// <summary>
    /// Class WalletScheme
    /// </summary>
    /// <seealso cref="Domain.Entities.BaseEntity&lt;System.Guid&gt;" />
    public class WalletScheme: BaseEntity<Guid>
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the code.
        /// </summary>
        /// <value>
        /// The code.
        /// </value>
        public string Code { get; set; }
        /// <summary>
        /// Gets or sets the status of the wallet scheme.
        /// </summary>
        /// <value>
        /// The is active.
        /// </value>
        public string IsActive { get; set; }        
        /// <summary>
        /// Gets or sets the type of the wallet scheme.
        /// </summary>
        /// <value>
        /// The type of the wallet scheme.
        /// </value>
        public WalletSchemeType WalletSchemeType { get; set; }
        /// <summary>
        /// Gets or sets the limit configuration navigation.
        /// </summary>
        /// <value>
        /// The limit configuration.
        /// </value>
        public virtual LimitConfiguration LimitConfiguration { get; set; }
    }
}
