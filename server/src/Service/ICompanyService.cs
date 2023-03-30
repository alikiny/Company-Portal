using server.src.Dtos;

namespace server.src.Service
{
    public interface ICompanyService
    {
        Task<IEnumerable<CompanyDto>> GetByPostCodeAsycn(string parameter);
        Task<bool> AddCompaniesAsync(IEnumerable<CompanyDto> companies);
    }
}