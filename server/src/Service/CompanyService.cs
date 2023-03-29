using server.src.Models;

namespace server.src.Service
{
    public class CompanyService : ICompanyService
    {
        public Task<bool> AddCompaniesAsync(IEnumerable<Company> companies)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Company>> GetByPostCodeAsycn(string parameter)
        {
            throw new NotImplementedException();
        }
    }
}