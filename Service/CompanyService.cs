using Data.Interfaces;
using Data.Models;
using Service.Interfaces;

namespace Service
{
    public class CompanyService : ICompanyService
    {
        private readonly IRealJobDbContext _context;
        public CompanyService(IRealJobDbContext context)
        {
            _context = context;
        }

        public async Task CreateCompanyAsync(Company companyDto, CancellationToken cancellationToken)
        {
            _context.Companies.Add(companyDto);
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
