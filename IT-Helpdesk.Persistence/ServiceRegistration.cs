using IT_Helpdesk.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace IT_Helpdesk.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services) 
        {
            ConfigurationManager configurationManager = new();
            configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "..\\IT-Helpdesk.UI"));
            configurationManager.AddJsonFile("appsettings.json");
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(configurationManager.GetConnectionString("SQLServer")));

        }
    }
}
