using server.src.Models;
using server.src.Repository;

namespace server.src.Service
{
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyRepo _repo; 

        public CompanyService(ICompanyRepo repo)
        {
            _repo = repo;
        }

        public async Task<bool> AddCompaniesAsync(IEnumerable<Company> companies)
        {
            return await _repo.AddCompaniesAsync(companies);
        }

        public async Task<IEnumerable<Company>> GetByPostCodeAsycn(string postCode)
        {
            return await _repo.GetByPostCodeAsycn(postCode);
        }
    }
}