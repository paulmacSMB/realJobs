using Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Data.Interfaces
{
    public interface IRealJobDbContext
    {
        DbSet<Company> Companies { get; }
        DbSet<SearchStrategy> SearchStrategies { get; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
