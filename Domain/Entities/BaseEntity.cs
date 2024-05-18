using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class BaseEntity<TId>
    {
        public TId Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime DateCreated { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? DateUpdated { get; set; }
        public bool IsDeleted { get; set; }
        public string? CreatedByIp { get; set; }
        public string? ModifiedByIp { get; set; }
    }
}
