using server.src.Models;

namespace server.src.Service
{
    public interface ICompanyService
    {
        Task<IEnumerable<Company>> GetByPostCodeAsycn(string parameter);
        Task<bool> AddCompaniesAsync(IEnumerable<Company> companies);
    }
}