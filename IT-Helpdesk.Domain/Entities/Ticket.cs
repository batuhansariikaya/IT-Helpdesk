using IT_Helpdesk.Domain.Entities.Common;
using IT_Helpdesk.Domain.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_Helpdesk.Domain.Entities
{
    public class Ticket : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public AppUser AppUser { get; set; }

        public TicketType TicketType { get; set; }
        public Department Department { get; set; }
    }
}
