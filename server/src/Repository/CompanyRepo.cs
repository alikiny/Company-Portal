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
            // Truncate whole database before feeding new dataset 
            var entityTypes = _context.Model.GetEntityTypes();
            foreach (var entityType in entityTypes)
            {
                var tableName = entityType.GetTableName();
                var schemaName = entityType.GetSchema();
                if (!string.IsNullOrEmpty(tableName) && !string.IsNullOrEmpty(schemaName))
                {
                    var sql = $"TRUNCATE TABLE \"{schemaName}\".\"{tableName}\" CASCADE";
                    _context.Database.ExecuteSqlInterpolated($"EXECUTE '{sql}'");
                }
            }
            await _context.SaveChangesAsync();
            await _dbSet.AddRangeAsync(companies);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<Company>> GetByPostCodeAsycn(string postCode)
        {
            var entities = await _dbSet.Where(e =>
                (e.Addresses != null) &&
                e.Addresses.Any(a => a.PostCode == postCode))
                .Include(e => e.Addresses)
                .Include(e => e.BusinessIdChanges)
                .Include(e => e.BusinessLines)
                .Include(e => e.CompanyForms)
                .Include(e => e.ContactDetails)
                .Include(e => e.Languages)
                .Include(e => e.RegistedOffices)
                .Include(e => e.RegisteredEntries)
                .Include(e => e.Liquidations)
                .Include(e => e.Names).AsNoTracking().ToArrayAsync();
            return entities;
        }
    }
}