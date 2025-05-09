using Logic.DTOs;

namespace Logic.Interfaces
{
    public interface ICompanyHandler
    {
        public Task CreateCompanyAsync(CompanyDto company);
    }
}
