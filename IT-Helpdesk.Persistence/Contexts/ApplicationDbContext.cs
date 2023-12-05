using IT_Helpdesk.Domain.Entities;
using IT_Helpdesk.Domain.Entities.Common;
using IT_Helpdesk.Domain.Entities.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_Helpdesk.Persistence.Contexts
{
    public class ApplicationDbContext:IdentityDbContext<AppUser,AppRole,Guid>
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<Department> Departments  { get; set; }
        public DbSet<Staff> Staff  { get; set; }
        public DbSet<Ticket> Tickets  { get; set; }
        public DbSet<TicketType> TicketTypes { get; set; }

        public override async Task<int>  SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var datas = ChangeTracker.Entries<BaseEntity>();

            foreach (var data in datas)
            {
                _ = data.State switch
                {
                    EntityState.Added => data.Entity.CreatedDate = DateTime.UtcNow,
                    EntityState.Modified => data.Entity.UpdatedDate = DateTime.UtcNow,
                    _=> DateTime.UtcNow
                };
            }

            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}
