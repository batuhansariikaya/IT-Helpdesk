using IT_Helpdesk.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_Helpdesk.Domain.Entities
{
    public class Staff:BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public Department Department { get; set; }
    }
}
