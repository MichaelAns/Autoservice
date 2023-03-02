using Autoservice.Persistance.Models;
using Microsoft.EntityFrameworkCore;

namespace Autoservice.Persistance.Data
{
    public class AutoserviceDbContext : DbContext
    {
        public AutoserviceDbContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }
        DbSet<Car> Car { get; set; }
        DbSet<Client> Client { get; set; }
        DbSet<Employee> Employee { get; set; }
        DbSet<Order> Order { get; set; }
        DbSet<Position> Position { get; set; }
        DbSet<Service> Service { get; set; }
        DbSet<ServiceOrder> ServiceOrder { get; set; }
    }
}
