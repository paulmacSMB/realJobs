
using Data.Models;

namespace Service.Interfaces
{
    public interface ICompanyService
    {
        public Task CreateCompanyAsync(Company company);
    }
}
