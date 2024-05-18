using Domain.Enums;

namespace Domain.Entities.Identity
{
    public class Role: BaseEntity<long>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Status Status { get; set; }
    }
}
