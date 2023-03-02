using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Autoservice.Persistance.Data
{
    public class AutoserviceDbContextFactory : IDesignTimeDbContextFactory<AutoserviceDbContext>
    {
        public AutoserviceDbContext CreateDbContext(string[] args = null)
        {
            var options = new DbContextOptionsBuilder<AutoserviceDbContext>();
            options.UseNpgsql("Host=localhost;Port=5432;Database=Autoservice;Username=postgres;Password=qwertyfsy");
            return new AutoserviceDbContext(options.Options);

            //string cs = GetConnectionStringFromFile();
            //options.UseNpgsql(cs);
            //return new DrugsLedgerDbContext(options.Options);
        }
    }
}
