using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Data
{
    public class RealJobDbContextFactory : IDesignTimeDbContextFactory<RealJobDbContext>
    {
        public RealJobDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<RealJobDbContext>();
            optionsBuilder.UseSqlServer("Server=CC\\SQLEXPRESS;Database=realJob;Trusted_Connection=True;TrustServerCertificate=True;");
            return new RealJobDbContext(optionsBuilder.Options);
        }
    }
}
