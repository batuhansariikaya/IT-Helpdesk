using IT_Helpdesk.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_Helpdesk.Domain.Entities
{
    public class TicketType:BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Ticket> Tickets { get; set; }
    }
}
