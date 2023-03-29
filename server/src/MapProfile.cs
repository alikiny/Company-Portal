using AutoMapper;
using server.src.Dtos;
using server.src.Models;

namespace server.src
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Address, AddressDto>();
            CreateMap<AddressDto, Address>();

            CreateMap<BusinessIdChange, BusinessIdChangeDto>();
            CreateMap<BusinessIdChangeDto, BusinessIdChange>();

            CreateMap<BusinessLine, BusinessLineDto>();
            CreateMap<BusinessLineDto, BusinessLine>();

            CreateMap<Company, CompanyDto>();
            CreateMap<CompanyDto, Company>();

            CreateMap<CompanyForm, CompanyFormDto>();
            CreateMap<CompanyFormDto, CompanyForm>();

            CreateMap<CompanyName, CompanyNameDto>();
            CreateMap<CompanyNameDto, CompanyName>();

            CreateMap<ContactDetail, ContactDetailDto>();
            CreateMap<ContactDetailDto, ContactDetail>();

            CreateMap<Language, LanguageDto>();
            CreateMap<LanguageDto, Language>();

            CreateMap<Liquidation, LiquidationDto>();
            CreateMap<LiquidationDto, Liquidation>();

            CreateMap<RegistedOffice, RegistedOfficeDto>();
            CreateMap<RegistedOfficeDto, RegistedOffice>();

            CreateMap<RegisteredEntry, RegisteredEntryDto>();
            CreateMap<RegisteredEntryDto, RegisteredEntry>();
        }
    }
}