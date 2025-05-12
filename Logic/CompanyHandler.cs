using AutoMapper;
using Data.Models;
using Logic.DTOs;
using Logic.Interfaces;
using Service.Interfaces;

namespace Logic
{
    public class CompanyHandler: ICompanyHandler
    {
        private readonly ICompanyService _companyService;
        private readonly IMapper _mapper;
        public CompanyHandler(ICompanyService companyService, IMapper mapper)
        {
            _companyService = companyService;
            _mapper = mapper;
        }

        public async Task CreateCompanyAsync(CompanyDto companyDto, CancellationToken cancellationToken)
        {
            var company = _mapper.Map<Company>(companyDto);
            await _companyService.CreateCompanyAsync(company, cancellationToken);
        }
    }
}
