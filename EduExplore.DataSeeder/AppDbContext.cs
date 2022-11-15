using EduExplore.Infrastructure.Data.DbModels;
using Microsoft.EntityFrameworkCore;

namespace EduExplore.DataSeeder
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {

        }

        public AppDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<District> Districts { get; set; }
        public DbSet<InhabitedArea> InhabitedAreas { get; set; }
        public DbSet<Municipality> Municipalities { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Institution> Institutions { get; set; }
        public DbSet<InstitutionType> InstitutionTypes { get; set; }
        public DbSet<DetailedInstitutionType> DetailedInstitutionTypes { get; set; }
        public DbSet<FinancialType> FinancialTypes { get; set; }

        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    base.OnModelCreating(builder);
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseSqlServer("Server=.\\SQLEXPRESS;Database=EduExplore;Trusted_Connection=True;TrustServerCertificate=True");
            }
        }
    }
}
