using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Onboarding
{
    public class BusinessTypes: BaseEntity<long>
    {
        public string Name { get; set; }
    }
}
