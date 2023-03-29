using AutoMapper;
using server.src.Dtos;
using server.src.Models;
using server.src.Repository;

namespace server.src.Service
{
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyRepo _repo;
        protected readonly IMapper _mapper;

        public CompanyService(ICompanyRepo repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<bool> AddCompaniesAsync(IEnumerable<CompanyDto> companies)
        {
            return await _repo.AddCompaniesAsync(_mapper.Map<IEnumerable<Company>>(companies));
        }

        public async Task<IEnumerable<CompanyDto>> GetByPostCodeAsycn(string postCode)
        {
            var entities = await _repo.GetByPostCodeAsycn(postCode);
            return _mapper.Map<IEnumerable<CompanyDto>>(entities);
        }
    }
}