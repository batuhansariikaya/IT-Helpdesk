using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_Helpdesk.Domain.Entities.Identity
{
    public class AppRole:IdentityRole<Guid>
    {
        public bool IsActive { get;set; }

    }
}
