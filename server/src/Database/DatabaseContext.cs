using Microsoft.EntityFrameworkCore;
using Npgsql;

using server.src.Dtos;
using server.src.Models;

namespace server.src.Database
{
    public class DatabaseContext : DbContext
    {
        private readonly IConfiguration _config;

        public DbSet<Company> Companies { get; set; } = null!;

        static DatabaseContext()
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        }

        public DatabaseContext(DbContextOptions<DatabaseContext> options, IConfiguration config) : base(options)
        {
            _config = config;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            _ = modelBuilder
            .HasPostgresEnum<AddressType>()
/*             .HasPostgresEnum<Change>() */
            .HasPostgresEnum<Source>()
            .HasPostgresEnum<CompanyFormType>()
            .HasPostgresEnum<Authority>()
            .HasPostgresEnum<Register>()
            .HasPostgresEnum<Status>();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            NpgsqlDataSourceBuilder dataSourceBuilder = new NpgsqlDataSourceBuilder(
                _config.GetConnectionString("DefaultConnection")
            );
            _ = dataSourceBuilder
            .MapEnum<AddressType>("address_type")
            /* .MapEnum<Change>("change") */
            .MapEnum<Source>("source")
            .MapEnum<CompanyFormType>("company_form_type")
            .MapEnum<Authority>("authority")
            .MapEnum<Register>("register")
            .MapEnum<Status>("status");
            NpgsqlDataSource dataSource = dataSourceBuilder.Build();
            _ = optionsBuilder
                .UseNpgsql(dataSource)
                .UseSnakeCaseNamingConvention();
        }
    }
}