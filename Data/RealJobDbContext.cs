using Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;

public class RealJobDbContext : DbContext
{
   
    public DbSet<Company> Companies { get; set; }
    public DbSet<SearchStrategy> SearchStrategies { get; set; }

    public RealJobDbContext(DbContextOptions<RealJobDbContext> options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Company>()
            .HasKey(c => c.CompanyId);

        modelBuilder.Entity<Company>()
            .HasMany(c => c.SearchStrategies)
            .WithOne(s   => s.Company)
            .HasForeignKey(s => s.CompanyId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<SearchStrategy>()
            .HasKey(s => s.StrategyId);



        // Store Dictionary<string,string> as JSON string
        modelBuilder.Entity<SearchStrategy>()
            .Property(s => s.Headers)
            .HasConversion(
                 v => System.Text.Json.JsonSerializer.Serialize(v, new System.Text.Json.JsonSerializerOptions()),
                 v => JsonSerializer.Deserialize<Dictionary<string, string>>(v, new System.Text.Json.JsonSerializerOptions())
     );

    }
}

