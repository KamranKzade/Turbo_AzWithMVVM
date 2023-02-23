using System.Data.Entity;
using Turbo_AzWithMVVM.Domain.Entities;



namespace Turbo_AzWithMVVM.DataAccess.EFrameworkServer
{
    public class CarContext : DbContext
    {
        public CarContext() : base(@"Data Source=DESKTOP-E15UN3T;Initial Catalog=CarsDb2;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        {
        }
        public DbSet<Car> Cars { get; set; }
    }
}
