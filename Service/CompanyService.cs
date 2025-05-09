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

        public Task CreateCompanyAsync(Company companyDto)
        {
            return Task.CompletedTask;
        }
    }
}
