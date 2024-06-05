using Domain.Enums;

namespace Domain.Entities.Wallets
{
    /// <summary>
    /// Class LimitConfiguration
    /// </summary>
    /// <seealso cref="Domain.Entities.BaseEntity&lt;System.Guid&gt;" />
    public class LimitConfiguration: BaseEntity<Guid>
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        public string Description { get; set; }
        /// <summary>
        /// Gets or sets the maximum balance limit that for inflow.
        /// </summary>
        /// <value>
        /// The maximum balance limit.
        /// </value>
        public decimal MaxBalanceLimit { get; set; }
        /// <summary>
        /// Gets or sets the single limit.
        /// </summary>
        /// <value>
        /// The single limit.
        /// </value>
        public decimal SingleLimit { get; set; }
        /// <summary>
        /// Gets or sets the cumulative limit.
        /// </summary>
        /// <value>
        /// The cumulative limit.
        /// </value>
        public decimal CumulativeLimit { get; set; }
        /// <summary>
        /// Gets or sets the type of the user.
        /// </summary>
        /// <value>
        /// The type of the user.
        /// </value>
        public ProfileType UserType { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this instance is active.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is active; otherwise, <c>false</c>.
        /// </value>
        public bool IsActive { get; set; }
    }
}
