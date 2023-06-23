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
        public DbSet<Region> Regions { get; set; }
        public DbSet<Currency> Currencies { get; set; }

        public AppDbContext() { }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=METIN-ABASZADE;Initial Catalog=CarUniverse;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
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

            #endregion

            #region DataSeeding
            var Brands = Program.GetOptionsFromSelect<Brand>("q[make][]").Result;
            var Models = new List<Model>();

            foreach (var brand in Brands)
            {
                var newModels = Program.GetAllModels(brand.Id.ToString()).Result;
                Models.AddRange(newModels);
            }
           

            //foreach (var fetchedBrand in fetchedBrands)
            //{
            //    var brand = new Brand { Name = fetchedBrand.Name };
            //    Brands.Add(brand);
            //    // Keep track of old and new IDs
            //    brandIdMappings.Add(fetchedBrand.Id, brand.Id);

            //    var fetchedModels = Program.GetAllModels(fetchedBrand.Id.ToString()).Result;
            //    var baseModels = fetchedModels.Where((m) => m.IsBaseModel());
            //    var subModels = fetchedModels.Where((m) => !m.IsBaseModel());

            //    foreach (var baseModel in baseModels)
            //    {
            //        var model = new Model
            //        {
            //            Name = baseModel.Name,
            //            BrandId = baseModel.BrandId
            //        };
            //        Models.Add(model);

            //        if (!modelIdMappings.ContainsKey(baseModel.Id.ToString()))
            //        {
            //            // Add the key-value pair to the dictionary
            //            modelIdMappings.Add(baseModel.Id.ToString(), model.Id);
            //        }
            //    }

            //    foreach (var subModel in subModels)
            //    {
            //        modelIdMappings.TryGetValue(subModel.BaseModelId.ToString(), out var baseModelId);
            //        var model = new Model
            //        {
            //            Name = subModel.Name,
            //            BrandId = subModel.BrandId,
            //            BaseModelId = baseModelId
            //        };
            //        Models.Add(model);
            //    }
            //}

            var Transmissions = Program.GetOptionsFromSelect<Transmission>("q[transmission][]").Result;
            //var Categories = Program.GetOptionsFromSelect<Category>("q[category][]").Result;
            var Currencies = Program.GetOptionsFromSelect<Currency>("q[currency]").Result;
            var Fueltypes = Program.GetOptionsFromSelect<Fueltype>("q[fuel_type][]").Result;
            var Regions = Program.GetOptionsFromSelect<Entities.Region>("q[region][]").Result;
            var Colors = Program.GetOptionsFromSelect<Entities.Color>("q[color][]").Result;
            var Years = Program.GetYears().Result;

           // var model = new Entities.Model(1, "TestModel", Brands[0].Id);
         

            modelBuilder.Entity<Brand>().HasData(Brands);
            modelBuilder.Entity<Model>().HasData(Models);
            modelBuilder.Entity<Transmission>().HasData(Transmissions);
            //modelBuilder.Entity<Category>().HasData(Categories);
            modelBuilder.Entity<Currency>().HasData(Currencies);
            modelBuilder.Entity<Fueltype>().HasData(Fueltypes);
            modelBuilder.Entity<Entities.Region>().HasData(Regions);
            modelBuilder.Entity<Entities.Color>().HasData(Colors);
            modelBuilder.Entity<Year>().HasData(Years);

            #endregion

        }
    }
}
