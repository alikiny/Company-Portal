using server.src.Models;

namespace server.src.Repository
{
    public interface ICompanyRepo
    {
        Task<IEnumerable<Company>> GetByPostCodeAsycn(string parameter);
        Task<bool> AddCompaniesAsync(IEnumerable<Company> companies);
    }
}