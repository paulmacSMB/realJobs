using AutoMapper;
using Data.Models;
using Logic.DTOs;

namespace Logic
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CompanyDto, Company>()
                .ReverseMap();
            CreateMap<SearchStrategyDto, SearchStrategy>()
                .ReverseMap();
        }
    }
}
