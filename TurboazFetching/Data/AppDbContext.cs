using Microsoft.EntityFrameworkCore;
using TurboazFetching.Entities;
using static System.Net.Mime.MediaTypeNames;

namespace TurboazFetching.Data
{
    internal class AppDbContext : DbContext
    {

        public DbSet<Brand> Brands { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Transmission> Transmissions { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Fueltype> Fueltypes { get; set; }
        public DbSet<Entities.Image> Images { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Currency> Currencies { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-G1Q07RP;Initial Catalog=CarUniverse;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Brand>()
              .HasMany<Car>()
              .WithOne(c => c.Brand)
              .HasForeignKey("BrandId")
              .IsRequired();

            modelBuilder.Entity<Model>()
              .HasOne<Brand>()
              .WithMany(b => b.Models)
              .HasForeignKey(m => m.BrandId)
              .IsRequired();

            modelBuilder.Entity<Model>()
              .HasMany<Car>()
              .WithOne(c => c.Model)
              .HasForeignKey("ModelId")
              .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Category>()
              .HasMany<Car>()
              .WithOne(c => c.Category)
              .HasForeignKey("CategoryId")
              .OnDelete(DeleteBehavior.Restrict)
              .IsRequired();

            modelBuilder.Entity<City>()
              .HasMany<Car>()
              .WithOne(c => c.City)
              .HasForeignKey("CityId")
              .IsRequired();

            modelBuilder.Entity<Fueltype>()
              .HasMany<Car>()
              .WithOne(c => c.Fueltype)
              .HasForeignKey("FueltypeId")
              .IsRequired();

            modelBuilder.Entity<Color>()
              .HasMany<Car>()
              .WithOne(c => c.Color)
              .HasForeignKey("ColorId")
              .IsRequired();

            modelBuilder.Entity<Currency>()
              .HasMany<Car>()
              .WithOne(c => c.Currency)
              .HasForeignKey("CurrencyId")
              .IsRequired();

            modelBuilder.Entity<Transmission>()
              .HasMany<Car>()
              .WithOne(c => c.Transmission)
              .HasForeignKey("TransmissionId")
              .IsRequired();

            modelBuilder.Entity<Entities.Image>()
             .HasOne<Car>()
             .WithMany(c => c.Images)
             .HasForeignKey("CarId")
             .IsRequired();
        }
    }
}
