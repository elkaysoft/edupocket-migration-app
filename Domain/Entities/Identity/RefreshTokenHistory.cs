using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Identity
{
    public class RefreshTokenHistory : BaseEntity<long>
    {
        public long UserId { get; set; }
        public string RefreshToken { get; set; }
        public bool IsActive { get; set; }
    }
}
