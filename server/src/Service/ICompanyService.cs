using server.src.Dtos;
using server.src.Models;

namespace server.src.Service
{
    public interface ICompanyService
    {
        Task<IEnumerable<CompanyDto>> GetByPostCodeAsycn(string parameter);
        Task<bool> AddCompaniesAsync(IEnumerable<CompanyDto> companies);
    }
}