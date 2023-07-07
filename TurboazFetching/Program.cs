using HtmlAgilityPack;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using PuppeteerSharp;
using TurboazFetching.Data;
using System.Net;
using System.Reflection;
using TurboazFetching.Entities;
using System;
using Microsoft.EntityFrameworkCore;
using System.Security.Policy;
using Newtonsoft.Json.Linq;
using System.Drawing;
using System.Dynamic;
using System.Reflection.Emit;
using System.Drawing.Drawing2D;

namespace TurboazFetching
{
    internal class Program
    {
        public static async Task<HtmlDocument> DownloadPage(string Url)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync(Url);
            var content = await response.Content.ReadAsStringAsync();

            var doc = new HtmlDocument();
            doc.LoadHtml(content);

            return doc;
        }

        public static async void GetCars()
        {
            Console.WriteLine("How many pages do you want to fetch: ");
            int pagecountcount = int.Parse(Console.ReadLine());
            int carcount = 1;

            for (int i = 0; i < pagecountcount; i++)
            {
                var url = $"https://turbo.az/autos?page={i}";

                var doc = DownloadPage(url).Result;

                var productNodes = doc.DocumentNode.Descendants("div")
                                  .Where(node => node.GetAttributeValue("class", "") == "products-i");

                foreach (var element in productNodes)
                {
                    var Name = element.Descendants("div").FirstOrDefault(e => e.GetAttributeValue("class", "").Contains("products-i__name")).InnerHtml;
                    string Atributes = element.Descendants("div").FirstOrDefault(e => e.GetAttributeValue("class", "").Contains("products-i__attributes")).InnerHtml;
                    string Datetime = element.Descendants("div").FirstOrDefault(e => e.GetAttributeValue("class", "").Contains("products-i__datetime")).InnerHtml;

                    Console.WriteLine($"Car {carcount++}");
                    Console.WriteLine("Name: " + Name);
                    Console.WriteLine("Atributes: " + Atributes);
                    Console.WriteLine("Datetime: " + Datetime);
                    Console.WriteLine();
                }
            }
        }

        public static async void GetCarsSelenium()
        {
            Console.WriteLine("How many pages do you want to fetch: ");
            int pageCount = int.Parse(Console.ReadLine());

            using var driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            for (int i = 1; i <= pageCount; i++)
            {
                var url = $"https://turbo.az/autos?page={i}";
                Console.WriteLine($"Fetching page {i}...");

                driver.Navigate().GoToUrl(url);

                // Wait for all product elements to be visible
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
                wait.Until(condition =>
                {
                    try
                    {
                        var elementToBeDisplayed = driver.FindElement(By.ClassName("products-i"));
                        return elementToBeDisplayed.Displayed;
                    }
                    catch (StaleElementReferenceException)
                    {
                        return false;
                    }
                    catch (NoSuchElementException)
                    {
                        return false;
                    }
                });

                var productElements = driver.FindElements(By.CssSelector(".products-i"));
                int CarCount = 1;

                foreach (var productNode in productElements)
                {

                    var Name = productNode.FindElement(By.CssSelector(".products-i__name")).Text;
                    var Attributes = productNode.FindElement(By.CssSelector(".products-i__attributes")).Text;
                    var DateTime = productNode.FindElement(By.CssSelector(".products-i__datetime")).Text;
                    var CarLink = productNode.FindElement(By.CssSelector(".products-i__link")).Text;

                    Console.WriteLine($"Car {CarCount++}");
                    Console.WriteLine("Name: " + Name);
                    Console.WriteLine("Attributes: " + Attributes);
                    Console.WriteLine("Datetime: " + DateTime);
                    Console.WriteLine("CarLink: " + CarLink);
                    Console.WriteLine();
                }
            }
        }

        public static async void GetCarsPuppeteer()
        {
            Console.WriteLine("How many pages do you want to fetch: ");
            int pageCount = int.Parse(Console.ReadLine());
            Console.Clear();

            // Download the latest version of Chromium
            await new BrowserFetcher().DownloadAsync();
            var launchOptions = new LaunchOptions { Headless = true };
            using var browser = await Puppeteer.LaunchAsync(launchOptions);
            using var page = await browser.NewPageAsync();
            await page.SetViewportAsync(new ViewPortOptions { Width = 1280, Height = 800 });

            int CarCount = 1;

            for (int i = 1; i <= pageCount; i++)
            {
                var url = $"https://turbo.az/autos?page={i}";
                Console.WriteLine($"Fetching page {i}...\n");

                await page.GoToAsync(url, new NavigationOptions { WaitUntil = new[] { WaitUntilNavigation.Networkidle0 } });

                var productNodes = await page.QuerySelectorAllAsync(".products-i");

                foreach (var element in productNodes)
                {
                    var CarLink = await element.QuerySelectorAsync(".products-i__link");

                    Console.WriteLine($"Car {CarCount++}");
                    Console.WriteLine("CarLink: " + await CarLink?.EvaluateFunctionAsync<string>("node => node.href"));
                    GetSpesificCarPuppeteer(await CarLink?.EvaluateFunctionAsync<string>("node => node.href"));
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
            }
        }

        public static async void GetSpesificCarPuppeteer(string url)
        {
            var doc = DownloadPage(url).Result;
            var DecendantDivs = doc.DocumentNode.Descendants("div");

            // Getting Car details: 
            var CarProperties = DecendantDivs.Where(node => node.GetAttributeValue("class", "") == "product-properties__i");

            foreach (var property in CarProperties)
            {
                var PropertyName = property.Descendants().ToArray()[0].InnerHtml;
                var PropertyValue = property.Descendants().ToArray().Last().InnerHtml;
                Console.WriteLine($"{PropertyName}: {PropertyValue}");
            }

            // Getting Car Images:
            var CarImageNodes = DecendantDivs.Where(node => node.GetAttributeValue("class", "").Contains("js-fotorama fotorama"));
            foreach (var node in CarImageNodes)
            {
                doc.LoadHtml(node.InnerHtml);
                var images = doc.DocumentNode.Descendants("a");
                foreach (var image in images)
                {
                    var ImageLink = image.GetAttributeValue("href", "");
                    try
                    {
                        SaveImage(ImageLink);
                        Console.WriteLine("ImageLink: " + ImageLink + " Successfully Saved!");
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }

            Console.WriteLine();
        }

        private static DataType CreateElement<DataType, LocaleType>(Dictionary<Language, string> languageValuePairs) where DataType : new() where LocaleType : new()
        {
            // Create a new instance of DataType
            DataType elementObj = new DataType();

            // Get the name of the property which will contain the list of LocaleType instances
            string localePropertyName = typeof(LocaleType).Name + "s";

            string dataTypeName = typeof(DataType).Name;

            // Get the property info for relevant properties on DataType and LocaleType
            PropertyInfo localeListProperty = typeof(DataType).GetProperty(localePropertyName);

            // Initialize list for LocaleType instances
            List<LocaleType> localeList = new List<LocaleType>();

            // Iterate over each language-value pair in the provided dictionary
            foreach (var kvp in languageValuePairs)
            {
                // Create a new instance of LocaleType
                LocaleType localeObj = new LocaleType();

                // Get the property info for relevant properties on LocaleType
                PropertyInfo nameLocaleProperty = typeof(LocaleType).GetProperty("Name");
                PropertyInfo languageLocaleProperty = typeof(LocaleType).GetProperty("Language");
                PropertyInfo parentLocaleProperty = typeof(LocaleType).GetProperty(dataTypeName);

                // Set the Id, Name, and Language properties on the LocaleType instance
                if (nameLocaleProperty != null && languageLocaleProperty != null)
                {
                    nameLocaleProperty.SetValue(localeObj, kvp.Value);
                    languageLocaleProperty.SetValue(localeObj, kvp.Key);
                }

                // Set the Parent property on the LocaleType instance to point to the DataType instance
                if (parentLocaleProperty != null)
                {
                    parentLocaleProperty.SetValue(localeObj, elementObj);
                }

                // Add the LocaleType instance to the list
                localeList.Add(localeObj);
            }

            // Set the list property on the DataType instance to the list of LocaleType instances
            if (localeListProperty != null)
            {
                localeListProperty.SetValue(elementObj, localeList);
            }

            // Return the DataType instance
            return elementObj;
        }

        public static async void SaveImage(string imagelink)
        {
            try
            {
                var Client = new WebClient();
                var ImageName = Guid.NewGuid().ToString() + Path.GetExtension(imagelink);
                string FolderPath = Path.Combine(System.IO.Path.GetFullPath(@"..\..\..\"), "Images");

                if (!Directory.Exists(FolderPath))
                {
                    Directory.CreateDirectory(FolderPath);
                }

                string FilePath = Path.Combine(FolderPath, ImageName);
                Client.DownloadFile(imagelink, FilePath);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Downlods options inside select(Category, Color, Transmission, Fueltype...) and return list of these elements
        public static async Task<List<DataType>> GetOptionsFromSelect<DataType, LocaleType>(string selectname, List<Language> languages) where DataType : new() where LocaleType : new()
        {
            CancellationTokenSource cancellationToken = new();
            SeedData.StartAnimation(cancellationToken.Token, $"Seeding {selectname}...");

            Language azLanguage = languages.FirstOrDefault(l => l.DisplayName == "Az");
            Language ruLanguage = languages.FirstOrDefault(l => l.DisplayName == "Ru");

            // Downloading options in AZ language:
            var azUrl = $"https://turbo.az";
            var azDoc = DownloadPage(azUrl).Result;

            // List of options inside select:
            var productOptionsAZ = azDoc.DocumentNode.Descendants("select")
                .FirstOrDefault(e => e.GetAttributeValue("name", "") == selectname)?.Descendants("option");
            if (productOptionsAZ == null)
            {
                throw new Exception($"Could not find select with specified name: {selectname}");
            }


            // Downloading options in Ru language:
            var ruUrl = $"https://ru.turbo.az";
            var ruDoc = DownloadPage(ruUrl).Result;

            // List of options inside select:
            var productOptionsRU = ruDoc.DocumentNode.Descendants("select")
                .FirstOrDefault(e => e.GetAttributeValue("name", "") == selectname)?.Descendants("option");
            if (productOptionsRU == null)
            {
                throw new Exception($"Could not find select with specified name in Russian language: {selectname}");
            }

            List<DataType> elements = new List<DataType>();

            foreach (var productOptionAZ in productOptionsAZ)
            {
                var value = productOptionAZ.GetAttributeValue("value", "");
                var productOptionRU = productOptionsRU.FirstOrDefault(o => o.GetAttributeValue("value", "") == value);

                var azInnerHtml = productOptionAZ.InnerHtml;
                var ruInnerHtml = productOptionRU.InnerHtml;

                Dictionary<Language, string> languageValuePairs = new();
                languageValuePairs.Add(azLanguage, azInnerHtml);
                languageValuePairs.Add(ruLanguage, ruInnerHtml);

                // Because first element in the select is empty
                if (!string.IsNullOrEmpty(value))
                {
                    var newElement = CreateElement<DataType, LocaleType>(languageValuePairs);
                    elements.Add(newElement);
                }
            }

            cancellationToken.Cancel();
            return elements;
        }

        public static async Task<List<Year>> GetYears()
        {
            CancellationTokenSource cancellationToken = new();
            SeedData.StartAnimation(cancellationToken.Token, "Seeding Years...");

            var Url = $"https://turbo.az";
            var doc = DownloadPage(Url).Result;
            var OptionValue = String.Empty;

            // List of options inside select:
            var ProductOptions = doc.DocumentNode.Descendants("select")
                .FirstOrDefault(e => e.GetAttributeValue("name", "") == "q[year_from]")?.Descendants("option");

            if (ProductOptions == null)
            {
                throw new Exception($"Could not find select with specified name q[year_from]");
            }

            List<Year> years = new List<Year>();

            foreach (var Option in ProductOptions)
            {
                OptionValue = Option.InnerHtml;
                if (!string.IsNullOrEmpty(Option.InnerHtml))
                {
                    var year = new Year(ushort.Parse(OptionValue));
                    years.Add(year);
                }
            }

            cancellationToken.Cancel();
            return years;
        }

        public static async Task<List<Currency>> GetCurrencies()
        {
            CancellationTokenSource cancellationToken = new();
            SeedData.StartAnimation(cancellationToken.Token, "Seeding Currencies...");

            var url = $"https://turbo.az";
            var doc = DownloadPage(url).Result;
            var optionValue = String.Empty;

            // List of options inside select:
            var productOptions = doc.DocumentNode.Descendants("select")
                .FirstOrDefault(e => e.GetAttributeValue("name", "") == "q[currency]")?.Descendants("option");

            if (productOptions == null)
            {
                throw new Exception($"Could not find select with specified name q[currency]");
            }

            List<Currency> currencies = new List<Currency>();

            foreach (var productOption in productOptions)
            {
                optionValue = productOption.InnerHtml;
                if (!string.IsNullOrEmpty(productOption.InnerHtml))
                {
                    var currency = new Currency(optionValue);
                    currencies.Add(currency);
                }
            }

            cancellationToken.Cancel();
            return currencies;
        }

        public static async Task<List<Brand>> GetBrands()   
        {
            CancellationTokenSource cancellationToken = new();
            SeedData.StartAnimation(cancellationToken.Token, "Seeding Brands...");

            var url = $"https://turbo.az";
            var doc = DownloadPage(url).Result;
            var optionValue = String.Empty;
            var optionInnerHtml = String.Empty;

            // List of options inside select:
            var productOptions = doc.DocumentNode.Descendants("select")
                .FirstOrDefault(e => e.GetAttributeValue("name", "") == "q[make][]")?.Descendants("option");

            if (productOptions == null)
            {
                throw new Exception($"Could not find select with specified name q[currency]");
            }

            List<Brand> brands = new();

            foreach (var option in productOptions)
            {
                optionInnerHtml = option.InnerHtml;
                optionValue = option.GetAttributeValue("value", "");
                int.TryParse(optionValue, out int optionValueInt);
                if (!string.IsNullOrEmpty(option.InnerHtml))
                {
                    var brand = new Brand(optionInnerHtml);
                    var models = GetModels(optionValueInt).Result;
                    brand.Models = models;
                    brands.Add(brand);
                }
            }

            cancellationToken.Cancel();
            return brands;
        }

        public static async Task<List<Model>> GetModels(int brandId)
        {
            string Url = "https://turbo.az";
            var doc = await DownloadPage(Url);
            var modelList = new List<Model>();
            Dictionary<int, Model> modelgroup = new();

            var models = doc.DocumentNode.Descendants("select").FirstOrDefault(e => e.GetAttributeValue("name", "") == "q[model][]")
                .Descendants("option").Where(e => e.GetAttributeValue("class", "") == brandId.ToString());

            foreach (var model in models)
            {
                var newModel = new Model();
                var value = model.GetAttributeValue("value", "");

                if (value.Contains("group"))
                {
                    var groupNumberString = value.Replace("group", "");
                    int.TryParse(groupNumberString, out int groupNumberInt);

                    // Check if the key already exists in the dictionary
                    if (!modelgroup.ContainsKey(groupNumberInt))
                    {
                        // Add the key-value pair to the dictionary
                        modelgroup.Add(groupNumberInt, newModel);
                    }
                    newModel.Name = model.InnerHtml;
                }

                else
                {
                    var datagroup = model.GetAttributeValue("data-group", "");
                    if (!string.IsNullOrEmpty(datagroup))
                    {
                        int.TryParse(datagroup, out int datagroupInt);

                        newModel.Name = model.InnerHtml;
                        newModel.BaseModel = modelgroup[datagroupInt];
                    }
                    else
                    {
                        newModel.Name = model.InnerHtml;
                    }
                }
                modelList.Add(newModel);
            }

            return modelList;
        }

        public static string GetBackgroundUrlFromStyle(HtmlNode htmlNode)
        {
            // Get the style attribute value from the htmlNode
            string logoNodeStyle = htmlNode.GetAttributeValue("style", "");
            // Extract the URL from the logoNodeStyle using string manipulation
            int urlStartIndex = logoNodeStyle.IndexOf("url(") + 4;
            int urlEndIndex = logoNodeStyle.IndexOf(")", urlStartIndex);
            string backgroundUrl = logoNodeStyle.Substring(urlStartIndex, urlEndIndex - urlStartIndex);

            return backgroundUrl;
        }

        public static AutoSalon GetAutoSalonDetails(string url, List<Language> languages)
        {
            Language azLanguage = languages.FirstOrDefault(l => l.DisplayName == "Az");
            Language ruLanguage = languages.FirstOrDefault(l => l.DisplayName == "Ru");

            var fullUrlAZ = "https://turbo.az/" + url;
            var docAZ = DownloadPage(fullUrlAZ).Result;

            HtmlNode salonCoverNode = docAZ.DocumentNode.SelectSingleNode("//div[contains(@class, 'shop--cover')]");
            HtmlNode salonLogoNode = docAZ.DocumentNode.SelectSingleNode("//div[contains(@class, 'shop--logo')]");
            HtmlNode salonTitleNode = docAZ.DocumentNode.SelectSingleNode("//h1[contains(@class, 'shop--title')]").SelectSingleNode(".//a");
            HtmlNode salonSloganAzNode = docAZ.DocumentNode.SelectSingleNode("//div[contains(@class, 'shop--special-offer')]");
            HtmlNode salonDescriptionAzNode = docAZ.DocumentNode.SelectSingleNode("//h2[contains(@class, 'shop--description')]");
            HtmlNode salonLocationAzNode = docAZ.DocumentNode.SelectSingleNode("//a[contains(@class, 'shop--location')]");
            HtmlNodeCollection phoneNumberNodes = docAZ.DocumentNode.SelectNodes("//a[contains(@class, 'shop-phones--number')]");

            string coverUrl = GetBackgroundUrlFromStyle(salonCoverNode);
            string logoUrl = GetBackgroundUrlFromStyle(salonLogoNode);
            string title = salonTitleNode.InnerHtml;
            string sloganAZ = WebUtility.HtmlDecode(salonSloganAzNode.InnerHtml);
            string descriptionAZ = salonDescriptionAzNode.InnerHtml;
            string locationAZ = salonLocationAzNode.InnerHtml;
            string locationUrl = salonLocationAzNode.GetAttributeValue("href", "");

            var fullUrlRU = "https://ru.turbo.az/" + url;
            var docRU = DownloadPage(fullUrlRU).Result;

            HtmlNode salonSloganRuNode = docRU.DocumentNode.SelectSingleNode("//div[contains(@class, 'shop--special-offer')]");
            HtmlNode salonDescriptionRuNode = docRU.DocumentNode.SelectSingleNode("//h2[contains(@class, 'shop--description')]");
            HtmlNode salonLocationRuNode = docRU.DocumentNode.SelectSingleNode("//a[contains(@class, 'shop--location')]");

            string sloganRU = WebUtility.HtmlDecode(salonSloganRuNode.InnerHtml);
            string descriptionRU = salonDescriptionRuNode.InnerHtml;
            string locationRU = salonLocationRuNode.InnerHtml;

            JArray numbersArray = new JArray();
            foreach (var phoneNumberNode in phoneNumberNodes)
            {
                string number = phoneNumberNode.InnerHtml;

                // Add the number to the JSON array
                numbersArray.Add(number);
            }
            // Convert the JSON number array to a string
            string numberJson = numbersArray.ToString();

            var autoSalon = new AutoSalon();

            var autoSalonLocaleAz = new AutoSalonLocale()
            {
                Slogan = sloganAZ,
                Location = locationAZ,
                Description = descriptionAZ,
                Language = azLanguage,
                AutoSalon = autoSalon
            };

            var autoSalonLocaleRu = new AutoSalonLocale()
            {
                Slogan = sloganRU,
                Location = locationRU,
                Description = descriptionRU,
                Language = ruLanguage,
                AutoSalon = autoSalon
            };

            autoSalon.CoverUrl = coverUrl;

            autoSalon.LogoUrl = logoUrl;
            autoSalon.Title = title;
            autoSalon.LocationUrl = locationUrl;
            autoSalon.Number = numberJson;
            autoSalon.AutoSalonLocales = new() {
                 autoSalonLocaleAz,
                 autoSalonLocaleRu
            };

            return autoSalon;
        }

        public static async Task<List<AutoSalon>> GetAutoSalons(List<Language> languages)
        {
            CancellationTokenSource cancellationToken = new();
            SeedData.StartAnimation(cancellationToken.Token, "Seeding AutoSalons...");

            var url = "https://turbo.az/avtosalonlar";
            var doc = DownloadPage(url).Result;
            var links = doc.DocumentNode.Descendants("a");

            List<AutoSalon> autoSalons = new();

            // Getting AutoSalon details: 
            var autoSalonLinks = links.Where(node => node.GetAttributeValue("class", "").Contains("shops-i "));
            foreach (var autosalonlink in autoSalonLinks)
            {
                var link = autosalonlink.GetAttributeValue("href", "");
                var autoSalon = GetAutoSalonDetails(link, languages);
                autoSalons.Add(autoSalon);
            }

            cancellationToken.Cancel();
            return autoSalons;
        }

        public static List<Feature> GetFetures(List<Language> languages)
        {
            CancellationTokenSource cancellationToken = new();
            SeedData.StartAnimation(cancellationToken.Token, "Seeding Features...");

            Language azLanguage = languages.FirstOrDefault(l => l.DisplayName == "Az");
            Language ruLanguage = languages.FirstOrDefault(l => l.DisplayName == "Ru");

            var azUrl = "https://turbo.az/";
            var azDoc = DownloadPage(azUrl).Result;
            var allLabelsAz = azDoc.DocumentNode.Descendants("label");
            var featureLabelsAz = allLabelsAz.Where(node => node.GetAttributeValue("class", "").Contains("tz-text "));

            var ruUrl = "https://ru.turbo.az/";
            var ruDoc = DownloadPage(ruUrl).Result;
            var allLabelsRu = ruDoc.DocumentNode.Descendants("label");
            var featureLabelsRu = allLabelsRu.Where(node => node.GetAttributeValue("class", "").Contains("tz-text "));

            List<Feature> features = new();

            foreach (var featureLabelAz in featureLabelsAz)
            {
                var featureNameAz = featureLabelAz.InnerHtml;
                var valuofForTagAz = featureLabelAz.GetAttributeValue("for", "");

                var featureLabelRu = featureLabelsRu.FirstOrDefault(f => f.GetAttributeValue("for", "") == valuofForTagAz);
                var featureNameRu = featureLabelRu.InnerHtml;

                var feature = new Feature();
                var featureLocaleAz = new FeatureLocale()
                {
                    Name = featureNameAz,
                    Language = azLanguage,
                    Feature = feature
                };
                var featureLocaleRu = new FeatureLocale()
                {
                    Name = featureNameRu,
                    Language = ruLanguage,
                    Feature = feature
                };

                feature.FeatureLocales = new()
                {
                    featureLocaleAz,
                    featureLocaleRu
                };
                features.Add(feature);
            }

            cancellationToken.Cancel();
            return features;
        }

        static async Task Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            AppDbContext dbContext = new AppDbContext();

            //await SeedData.Initialize(dbContext);

            #region Testing Db Brand and Models
            var brands = dbContext.Brands.Include((b) => b.Models).ToList();
            Console.WriteLine("\n---------------- BRANDS ----------------\n");
            foreach (var brand in brands)
            {
                Console.WriteLine("Brand Id: " + brand.Id);
                Console.WriteLine("Brand Name: " + brand.Name);
                Console.WriteLine("--------" + brand.Name + "--------\n");
                foreach (var model in brand.Models)
                {
                    Console.WriteLine("Model Id: " + model.Id);
                    Console.WriteLine("Model Name: " + model.Name);
                    Console.WriteLine("Model BaseModel Id: " + model.BaseModel?.Id);
                    Console.WriteLine("Model BaseModel Name: " + model.BaseModel?.Name);
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            //var regions = dbContext.Regions.Include((r) => r.RegionLocales)
            //                               .ThenInclude(rl => rl.Language).ToList();
            //Console.WriteLine("\n---------------- REGIONS ----------------\n");
            //foreach (var region in regions)
            //{
            //    Console.WriteLine("Id: " + region.Id);
            //    foreach (var regionLocale in region.RegionLocales)
            //    {
            //        Console.WriteLine("Language: " + regionLocale.Language.LanguageName);
            //        Console.WriteLine("Region Name: " + regionLocale.Name);
            //        Console.WriteLine();
            //    }
            //}

            //var years = dbContext.Years.ToList();
            //Console.WriteLine("\n---------------- YEARS ----------------\n");
            //foreach (var year in years)
            //{
            //    Console.WriteLine("Id: " + year.Id);
            //    Console.WriteLine("Year: " + year.Value);
            //}

            //var categories = dbContext.Categories.Include(c => c.CategoryLocales)
            //                                     .ThenInclude(cl => cl.Language).ToList();
            //Console.WriteLine("\n---------------- CATEGORIES ----------------\n");
            //foreach (var category in categories)
            //{
            //    Console.WriteLine("Id: " + category.Id);
            //    foreach (var categoryLocale in category.CategoryLocales)
            //    {
            //        Console.WriteLine("Language: " + categoryLocale.Language.LanguageName);
            //        Console.WriteLine("Category Name: " + categoryLocale.Name);
            //        Console.WriteLine();
            //    }
            //}

            //var colors = dbContext.Colors.Include(c => c.ColorLocales)
            //                             .ThenInclude(cl => cl.Language).ToList();
            //Console.WriteLine("\n---------------- COLORS ----------------\n");
            //foreach (var color in colors)
            //{
            //    Console.WriteLine("Id: " + color.Id);
            //    foreach (var colorLocale in color.ColorLocales)
            //    {
            //        Console.WriteLine("ColorLocale Id: " + colorLocale.Id);
            //        Console.WriteLine("Language: " + colorLocale.Language.LanguageName);
            //        Console.WriteLine("Color Name: " + colorLocale.Name);
            //        Console.WriteLine("Color Id: " + colorLocale.Color.Id);
            //        Console.WriteLine();
            //    }
            //}

            //var fuelTypes = dbContext.Fueltypes.Include(ft => ft.FueltypeLocales)
            //                                   .ThenInclude(ftl => ftl.Language).ToList();
            //Console.WriteLine("\n---------------- FUELTYPES ----------------\n");
            //foreach (var fuelType in fuelTypes)
            //{
            //    Console.WriteLine("Id: " + fuelType.Id);
            //    foreach (var fueltypeLocale in fuelType.FueltypeLocales)
            //    {
            //        Console.WriteLine("Language: " + fueltypeLocale.Language.LanguageName);
            //        Console.WriteLine("Fueltype Name: " + fueltypeLocale.Name);
            //        Console.WriteLine();
            //    }
            //}

            //var transmissions = dbContext.Transmissions.Include(t => t.TransmissionLocales)
            //                                           .ThenInclude(tl => tl.Language).ToList();
            //Console.WriteLine("\n---------------- TRANSMISSIONS ----------------\n");
            //foreach (var transmission in transmissions)
            //{
            //    Console.WriteLine("Id: " + transmission.Id);
            //    foreach (var transmissionLocale in transmission.TransmissionLocales)
            //    {
            //        Console.WriteLine("Language: " + transmissionLocale.Language.LanguageName);
            //        Console.WriteLine("Fueltype Name: " + transmissionLocale.Name);
            //        Console.WriteLine();
            //    }
            //}

            //var currencies = dbContext.Currencies.ToList();
            //Console.WriteLine("\n---------------- CURRENCIES ----------------\n");
            //foreach (var currency in currencies)
            //{
            //    Console.WriteLine("Id: " + currency.Id);
            //    Console.WriteLine("Currency Name: " + currency.Name);
            //}

            //var autoSalons = dbContext.AutoSalons.Include(s => s.AutoSalonLocales)
            //                                     .ThenInclude(sl => sl.Language).ToList();
            //Console.WriteLine("\n---------------- AUTOSALONS ----------------\n");
            //foreach (var autoSalon in autoSalons)
            //{
            //    Console.WriteLine("AutoSalonId: " + autoSalon.Id);
            //    Console.WriteLine("Cover Url: " + autoSalon.CoverUrl);
            //    Console.WriteLine("Logo Url: " + autoSalon.LogoUrl);
            //    Console.WriteLine("Title: " + autoSalon.Title);
            //    foreach (var autoSalonLocale in autoSalon.AutoSalonLocales)
            //    {
            //        Console.WriteLine("SalonLocaleId: " + autoSalonLocale.Id);
            //        Console.WriteLine("Language: " + autoSalonLocale.Language.DisplayName);
            //        Console.WriteLine("AutoSalonId: " + autoSalonLocale.AutoSalon.Id);
            //        Console.WriteLine("Slogan: " + autoSalonLocale.Slogan);
            //        Console.WriteLine("Description: " + autoSalonLocale.Description);
            //        Console.WriteLine("Location: " + autoSalonLocale.Location);

            //    }
            //    Console.WriteLine("Location Link: " + autoSalon.LocationUrl);
            //    Console.WriteLine("Numbers: " + autoSalon.Number);
            //    Console.WriteLine();
            //}

            //var features = dbContext.Features.Include(f => f.FeatureLocales)
            //                                 .ThenInclude(fl => fl.Language).ToList();
            //Console.WriteLine("\n---------------- FEATURES ----------------\n");
            //foreach (var feature in features)
            //{
            //    Console.WriteLine("Feature Id: " + feature.Id);
            //    foreach (var fetureLocale in feature.FeatureLocales)
            //    {
            //        Console.WriteLine("Language: " + fetureLocale.Language.DisplayName);
            //        Console.WriteLine("Feature Name: " + fetureLocale.Name);
            //        Console.WriteLine("Feature Id: " + fetureLocale.Feature.Id);
            //    }
            //    Console.WriteLine();
            //}
            #endregion


            // GetCars();
            // GetCarsPuppeteer();
            // GetCarsSelenium();


            #region GetBrandsandModels
            //var brands = GetBrands().Result;
            //foreach (var brand in brands)
            //{
            //    Console.WriteLine("------------- " + brand.Name + " -------------");
            //    foreach (var model in brand.Models)
            //    {
            //        Console.WriteLine("Model Id: " + model.Id);
            //        Console.WriteLine("Model Name: " + model.Name);
            //        Console.WriteLine("Model BaseModel Id: " + model.BaseModel?.Id);
            //        Console.WriteLine("Model BaseModel Name: " + model.BaseModel?.Name);
            //        Console.WriteLine();
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region GetRegions
            //var regions = GetOptionsFromSelect<Entities.Region, RegionLocale>("q[region][]").Result;
            //foreach (var region in regions)
            //{
            //    Console.WriteLine("Id: " + region.Id);
            //    foreach (var regionLocale in region.RegionLocales)
            //    {
            //        Console.WriteLine("Language: " + regionLocale.Language.LanguageName);
            //        Console.WriteLine("Region Name: " + regionLocale.Name);
            //        Console.WriteLine();
            //    }

            //}
            #endregion

            #region GetYears
            //var years = GetYears().Result;
            //foreach (var year in years)
            //{
            //    Console.WriteLine("Id: " + year.Id);
            //    Console.WriteLine("Year: " + year.Value);
            //}
            #endregion

            #region GetCategories
            //var categories = GetOptionsFromSelect<Category, CategoryLocale>("q[category][]").Result;
            //foreach (var category in categories)
            //{
            //    Console.WriteLine("Id: " + category.Id);
            //    foreach (var categoryLocale in category.CategoryLocales)
            //    {
            //        Console.WriteLine("Language: " + categoryLocale.Language.LanguageName);
            //        Console.WriteLine("Category Name: " + categoryLocale.Name);
            //        Console.WriteLine();
            //    }
            //}
            #endregion

            #region GetColors
            //var colors = GetOptionsFromSelect<Entities.Color, ColorLocale>("q[color][]").Result;
            //foreach (var color in colors)
            //{
            //    Console.WriteLine("Id: " + color.Id);
            //    foreach (var colorLocale in color.ColorLocales)
            //    {
            //        Console.WriteLine("ColorLocale Id: " + colorLocale.Id);
            //        Console.WriteLine("Language: " + colorLocale.Language.LanguageName);
            //        Console.WriteLine("Color Name: " + colorLocale.Name);
            //        Console.WriteLine("Color Id: " + colorLocale.Color.Id);
            //        Console.WriteLine();
            //    }
            //}
            #endregion

            #region GetFueltypes
            //var fuelTypes = GetOptionsFromSelect<Fueltype, FueltypeLocale>("q[fuel_type][]").Result;
            //foreach (var fuelType in fuelTypes)
            //{
            //    Console.WriteLine("Id: " + fuelType.Id);
            //    foreach (var fueltypeLocale in fuelType.FueltypeLocales)
            //    {
            //        Console.WriteLine("Language: " + fueltypeLocale.Language.LanguageName);
            //        Console.WriteLine("Fueltype Name: " + fueltypeLocale.Name);
            //        Console.WriteLine();
            //    }
            //}
            #endregion

            #region GetTransmissions
            //var transmissions = GetOptionsFromSelect<Transmission, TransmissionLocale>("q[transmission][]").Result;
            //foreach (var transmission in transmissions)
            //{
            //    Console.WriteLine("Id: " + transmission.Id);
            //    foreach (var transmissionLocale in transmission.TransmissionLocales)
            //    {
            //        Console.WriteLine("Language: " + transmissionLocale.Language.LanguageName);
            //        Console.WriteLine("Fueltype Name: " + transmissionLocale.Name);
            //        Console.WriteLine();
            //    }
            //}
            #endregion

            #region GetCurrencies
            //var currencies = GetCurrencies().Result;
            //foreach (var currency in currencies)
            //{
            //    Console.WriteLine("Id: " + currency.Id);
            //    Console.WriteLine("Currency Name: " + currency.Name);
            //}
            #endregion

            #region GetAutoSalons
            //var autoSalons = await GetAutoSalons();
            //foreach (var autoSalon in autoSalons)
            //{
            //    Console.WriteLine();
            //    //Console.WriteLine("AutoSalonId: " + autoSalon.Id);
            //    Console.WriteLine("Cover Url: " + autoSalon.CoverUrl);
            //    //Console.WriteLine("Logo Url: " + autoSalon.LogoUrl);
            //    //Console.WriteLine("Title: " + autoSalon.Title);
            //    //foreach (var autoSalonLocale in autoSalon.AutoSalonLocales)
            //    //{
            //    //    Console.WriteLine("SalonLocaleId: " + autoSalonLocale.Id);
            //    //    Console.WriteLine("Language: " + autoSalonLocale.Language.DisplayName);
            //    //    Console.WriteLine("AutoSalonId: " + autoSalonLocale.AutoSalon.Id);
            //    //    Console.WriteLine("Slogan: " + autoSalonLocale.Slogan);
            //    //    Console.WriteLine("Description: " + autoSalonLocale.Description);
            //    //    Console.WriteLine("Location: " + autoSalonLocale.Location);

            //    //}
            //    //Console.WriteLine("Location Link: " + autoSalon.LocationUrl);
            //    //Console.WriteLine("Numbers: " + autoSalon.Number);
            //    Console.WriteLine();
            //}
            #endregion

            #region GetFetures
            //var features = GetFetures();

            //foreach (var feature in features)
            //{
            //    Console.WriteLine("Feature Id: " + feature.Id);
            //    foreach (var fetureLocale in feature.FeatureLocales)
            //    {
            //        Console.WriteLine("Language: " + fetureLocale.Language.DisplayName);
            //        Console.WriteLine("Feature Name: " + fetureLocale.Name);
            //        Console.WriteLine("Feature Id: " + fetureLocale.Feature.Id);
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            Console.ReadLine();
        }
    }
}



// Where vs Contains vs Firstordefault

// internal vs public
