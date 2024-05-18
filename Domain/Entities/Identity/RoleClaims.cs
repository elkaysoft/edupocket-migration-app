using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Identity
{
    public class RoleClaims: BaseEntity<long>
    {
        public long RoleId { get; set; }
        public string ClaimValue { get; set; }
    }
}
