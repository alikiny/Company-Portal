using Microsoft.EntityFrameworkCore;

using server.src.Database;
using server.src.Models;

namespace server.src.Repository
{
    public class CompanyRepo : ICompanyRepo
    {
        private readonly DatabaseContext _context;
        private readonly DbSet<Company> _dbSet;

        public CompanyRepo(DatabaseContext context)
        {
            _context = context;
            _dbSet = context.Set<Company>();
        }

        public async Task<bool> AddCompaniesAsync(IEnumerable<Company> companies)
        {
            await _dbSet.AddRangeAsync(companies);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<Company>> GetByPostCodeAsycn(string postCode)
        {
            var entities = _dbSet.Where(e =>
                (e.Addresses != null) &&
                e.Addresses.Any(a => a.PostCode == postCode));
            return await entities.ToArrayAsync();
        }
    }
}