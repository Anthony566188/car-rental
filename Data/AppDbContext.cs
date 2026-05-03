using car_rental.Models;
using Microsoft.EntityFrameworkCore;

namespace car_rental.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        
        public DbSet<Car> Cars { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>().ToTable("DB_CARS");

            modelBuilder.Entity<Car>().Property(c => c.Id).HasColumnName("ID");
            modelBuilder.Entity<Car>().Property(c => c.Model).HasColumnName("MODEL");
            modelBuilder.Entity<Car>().Property(c => c.Brand).HasColumnName("BRAND");
            modelBuilder.Entity<Car>().Property(c => c.Year).HasColumnName("YEAR");
            modelBuilder.Entity<Car>().Property(c => c.DailyValue).HasColumnName("DAILY_VALUE");

            base.OnModelCreating(modelBuilder);

        }

    }
}
