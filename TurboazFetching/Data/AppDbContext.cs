using Microsoft.EntityFrameworkCore;
using TurboazFetching.Entities;
using static System.Net.Mime.MediaTypeNames;

namespace TurboazFetching.Data
{
    internal class AppDbContext : DbContext
    {

        public DbSet<Brand> Brands { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<AutoSalon> AutoSalons { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Transmission> Transmissions { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Fueltype> Fueltypes { get; set; }
        public DbSet<Entities.Image> Images { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Currency> Currencies { get; set; }

        public AppDbContext() { }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=METIN-ABASZADE;Initial Catalog=CarUniverse;Integrated Security=True;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            optionsBuilder.EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            #region SettingRelations

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

            modelBuilder.Entity<Region>()
              .HasMany<Car>()
              .WithOne(c => c.Region)
              .HasForeignKey("RegionId")
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

            modelBuilder.Entity<Year>()
              .HasMany<Car>()
              .WithOne(c => c.Year)
              .HasForeignKey("YearId")
              .IsRequired();

            modelBuilder.Entity<Entities.Image>()
             .HasOne<Car>()
             .WithMany(c => c.Images)
             .HasForeignKey("CarId")
             .IsRequired();

            modelBuilder.Entity<AutoSalon>()
            .HasMany(s => s.Cars)
            .WithOne(c => c.AutoSalon)
            .HasForeignKey("AutoSalonId");

            #endregion

            #region DataSeeding
            var brands = Program.GetOptionsFromSelect<Brand>("q[make][]").Result;
            var models = Program.GetAllModels(brands).Result;
            var autoSalons = Program.GetAutoSalons().Result;
            var transmissions = Program.GetOptionsFromSelect<Transmission>("q[transmission][]").Result;
            //var Categories = Program.GetOptionsFromSelect<Category>("q[category][]").Result;
            var currencies = Program.GetOptionsFromSelect<Currency>("q[currency]").Result;
            var fueltypes = Program.GetOptionsFromSelect<Fueltype>("q[fuel_type][]").Result;
            var regions = Program.GetOptionsFromSelect<Entities.Region>("q[region][]").Result;
            var colors = Program.GetOptionsFromSelect<Entities.Color>("q[color][]").Result;
            var years = Program.GetYears().Result;

           // var model = new Entities.Model(1, "TestModel", Brands[0].Id);
         

            modelBuilder.Entity<Brand>().HasData(brands);
            modelBuilder.Entity<Model>().HasData(models);
            modelBuilder.Entity<AutoSalon>().HasData(autoSalons);
            modelBuilder.Entity<Transmission>().HasData(transmissions);
            //modelBuilder.Entity<Category>().HasData(categories);
            modelBuilder.Entity<Currency>().HasData(currencies);
            modelBuilder.Entity<Fueltype>().HasData(fueltypes);
            modelBuilder.Entity<Entities.Region>().HasData(regions);
            modelBuilder.Entity<Entities.Color>().HasData(colors);
            modelBuilder.Entity<Year>().HasData(years);

            #endregion

        }
    }
}
