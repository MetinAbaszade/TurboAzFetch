using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TurboazFetching.Entities;

namespace TurboazFetching.Data
{
    public static class SeedData
    {
        public static async Task Initialize(AppDbContext dbContext)
        {
            Console.WriteLine("------------ Data Seeding Started ------------");

            // Delete the existing database and create a new one
            await dbContext.Database.EnsureDeletedAsync();
            await dbContext.Database.EnsureCreatedAsync();

            Language azLanguage = new Language()
            {
                LanguageName = "Azerbaijany",
                DisplayName = "Az"
            };
            Language ruLanguage = new Language()
            {
                LanguageName = "Russian",
                DisplayName = "Ru"
            };

            List<Language> languages = new()
            {
                azLanguage,
                ruLanguage
            };


            dbContext.Languages.AddRange(languages);

            var brands = Program.GetBrands().Result;
            var years = Program.GetYears().Result;
            var colors = Program.GetOptionsFromSelect<Entities.Color, ColorLocale>("q[color][]", languages).Result;
            var regions = Program.GetOptionsFromSelect<Entities.Region, RegionLocale>("q[region][]", languages).Result;
            var features = Program.GetFetures(languages);
            var fueltypes = Program.GetOptionsFromSelect<Fueltype, FueltypeLocale>("q[fuel_type][]", languages).Result;
            var autoSalons = Program.GetAutoSalons(languages).Result;
            var currencies = Program.GetCurrencies().Result;
            //var categories = Program.GetOptionsFromSelect<Category, CategoryLocale>("q[category][]").Result;
            var transmissions = Program.GetOptionsFromSelect<Transmission, TransmissionLocale>("q[transmission][]", languages).Result;



            dbContext.Years.AddRange(years);
            dbContext.Brands.AddRange(brands);
            dbContext.Colors.AddRange(colors);
            dbContext.Regions.AddRange(regions);
            dbContext.Features.AddRange(features);
            dbContext.Fueltypes.AddRange(fueltypes);
            dbContext.Currencies.AddRange(currencies);
            dbContext.AutoSalons.AddRange(autoSalons);
            // dbContext.Categories.AddRange(categories);
            dbContext.Transmissions.AddRange(transmissions);

            await dbContext.SaveChangesAsync();
            Console.WriteLine("------------ Data Seeding Completed ------------");
        }

        public static async Task StartAnimation(CancellationToken cancellationToken, string message)
        {
            string[] animationFrames = new string[] { "-", "\\", "|", "/" };
            int currentAnimationFrame = 0;

            while (!cancellationToken.IsCancellationRequested)
            {
                Console.Write("\r" + message + animationFrames[currentAnimationFrame]);
                currentAnimationFrame = (currentAnimationFrame + 1) % animationFrames.Length;
                await Task.Delay(200);
            }

            Console.Write("\r"); // Clear the last frame of animation
            Console.WriteLine(message + " Completed!!!");
        }
    }
}
