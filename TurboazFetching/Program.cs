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

        public static async Task<List<Model>> GetAllModels(List<Brand> brands)
        {
            string Url = "https://turbo.az";
            var doc = await DownloadPage(Url);
            int modelId = 1;
            var modelList = new List<Model>();
            Dictionary<int, int> modelgroup = new();

            foreach (var brand in brands)
            {
                var models = doc.DocumentNode.Descendants("select").FirstOrDefault(e => e.GetAttributeValue("name", "") == "q[model][]")
                    .Descendants("option").Where(e => e.GetAttributeValue("class", "") == brand.Id.ToString());

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
                            modelgroup.Add(groupNumberInt, modelId);
                        }
                        newModel.Id = modelId;
                        newModel.Name = model.InnerHtml;
                        newModel.BrandId = brand.Id;
                    }

                    else
                    {
                        var datagroup = model.GetAttributeValue("data-group", "");
                        if (!string.IsNullOrEmpty(datagroup))
                        {
                            int.TryParse(datagroup, out int datagroupInt);
                            newModel.Id = modelId;
                            newModel.Name = model.InnerHtml;
                            newModel.BrandId = brand.Id;
                            var baseModelId = modelgroup[datagroupInt];
                            newModel.BaseModelId = baseModelId;
                        }

                        else
                        {
                            newModel.Id = modelId;
                            newModel.Name = model.InnerHtml;
                            newModel.BrandId = brand.Id;
                        }
                    }

                    modelId++;
                    modelList.Add(newModel);
                }

                // Clear the existing dictionary
                modelgroup.Clear();
            }

            return modelList;
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

        private static T CreateElement<T>(int id, string value) where T : new()
        {
            T elementObj = new T();

            PropertyInfo idProperty = typeof(T).GetProperty("Id");
            PropertyInfo nameProperty = typeof(T).GetProperty("Name");

            if (idProperty != null && nameProperty != null)
            {
                idProperty.SetValue(elementObj, id);
                nameProperty.SetValue(elementObj, value);
            }

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
        public static async Task<List<T>> GetOptionsFromSelect<T>(string selectname) where T : new()
        {
            var Url = $"https://turbo.az";
            var doc = DownloadPage(Url).Result;
            var Value = String.Empty;

            // List of options inside select:
            var ProductOptions = doc.DocumentNode.Descendants("select")
                .FirstOrDefault(e => e.GetAttributeValue("name", "") == selectname)?.Descendants("option");

            if (ProductOptions == null)
            {
                throw new Exception($"Could not find select with specified name: {selectname}");
            }

            List<T> elements = new List<T>();
            int id;

            foreach (var Option in ProductOptions)
            {
                int.TryParse(Option.GetAttributeValue("value", ""), out id);
                Value = Option.InnerHtml;
                // Because first element in the select is empty
                if (id != 0)
                {
                    var NewElement = CreateElement<T>(id, Value);
                    elements.Add(NewElement);
                }
            }

            return elements;
        }

        public static async Task<List<Year>> GetYears()
        {
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

            List<Year> Years = new List<Year>();
            int id = 1;

            foreach (var Option in ProductOptions)
            {
                OptionValue = Option.InnerHtml;
                if (!string.IsNullOrEmpty(Option.InnerHtml))
                {
                    var Year = new Year(id++, ushort.Parse(OptionValue));
                    Years.Add(Year);
                }
            }

            return Years;
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

        public static AutoSalon GetAutoSalonDetails(string url)
        {
            var fullurl = "https://turbo.az/" + url;
            var doc = DownloadPage(fullurl).Result;

            HtmlNode salonCoverNode = doc.DocumentNode.SelectSingleNode("//div[contains(@class, 'shop--cover')]");
            HtmlNode salonLogoNode = doc.DocumentNode.SelectSingleNode("//div[contains(@class, 'shop--logo')]");
            HtmlNode salonTitleNode = doc.DocumentNode.SelectSingleNode("//h1[contains(@class, 'shop--title')]").SelectSingleNode(".//a");
            HtmlNode salonSloganNode = doc.DocumentNode.SelectSingleNode("//div[contains(@class, 'shop--special-offer')]");
            HtmlNode salonDescriptionNode = doc.DocumentNode.SelectSingleNode("//h2[contains(@class, 'shop--description')]");
            HtmlNode locationNode = doc.DocumentNode.SelectSingleNode("//a[contains(@class, 'shop--location')]");
            HtmlNodeCollection phoneNumberNodes = doc.DocumentNode.SelectNodes("//a[contains(@class, 'shop-phones--number')]");

            string coverUrl = GetBackgroundUrlFromStyle(salonCoverNode);
            string logoUrl = GetBackgroundUrlFromStyle(salonLogoNode);
            string title = salonTitleNode.InnerHtml;
            string description = salonDescriptionNode.InnerHtml;
            string location = locationNode.InnerHtml;
            string locationUrl = locationNode.GetAttributeValue("href", "");
            string slogan = WebUtility.HtmlDecode(salonSloganNode.InnerHtml);

            JArray numbersArray = new JArray();
            foreach (var phoneNumberNode in phoneNumberNodes)
            {
                string number = phoneNumberNode.InnerHtml;

                // Add the number to the JSON array
                numbersArray.Add(number);
            }
            // Convert the JSON number array to a string
            string numberJson = numbersArray.ToString();

            AutoSalon autoSalon = new()
            {
                CoverUrl = coverUrl,
                LogoUrl = logoUrl,
                Title = title,
                Slogan = slogan,
                Description = description,
                Location = location,
                LocationUrl = locationUrl,
                Number = numberJson
            };

            return autoSalon;
        }

        public static async Task<List<AutoSalon>> GetAutoSalons()
        {
            var url = "https://ru.turbo.az/avtosalonlar";
            var doc = DownloadPage(url).Result;
            var Links = doc.DocumentNode.Descendants("a");

            List<AutoSalon> autoSalons = new();
            int autoSalonId = 1;

            // Getting AutoSalon details: 
            var autoSalonLinks = Links.Where(node => node.GetAttributeValue("class", "").Contains("shops-i "));
            foreach (var autosalonlink in autoSalonLinks)
            {
                var link = autosalonlink.GetAttributeValue("href", "");
                var autoSalon = GetAutoSalonDetails(link);
                autoSalon.Id = autoSalonId++;
                autoSalons.Add(autoSalon);
            }

            return autoSalons;
        }

        static async Task Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            AppDbContext dbContext = new AppDbContext();

            #region Testing Db Brand and Models
            //var Brands = dbContext.Brands.Include((b) => b.Models).ToList();
            //foreach (var brand in Brands)
            //{
            //    Console.WriteLine("Brand Id: " + brand.Id);
            //    Console.WriteLine("Brand Name: " + brand.Name);
            //    Console.WriteLine("\n-------- Models --------\n");
            //    foreach (var model in brand.Models)
            //    {
            //        Console.WriteLine("Model Id: " + model.Id);
            //        Console.WriteLine("Model Name: " + model.Name);
            //        Console.WriteLine("Model BrandId: " + model.BrandId);
            //        Console.WriteLine("Model BaseModelId: " + model.BaseModelId);
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            // GetCars();
            // GetCarsPuppeteer();
            // GetCarsSelenium();

            var autoSalons = await GetAutoSalons();
            foreach (var autoSalon in autoSalons)
            {
                Console.WriteLine();
                Console.WriteLine("Cover Url: " + autoSalon.CoverUrl);
                Console.WriteLine("Logo Url: " + autoSalon.LogoUrl);
                Console.WriteLine("Title: " + autoSalon.Title);
                Console.WriteLine("Slogan: " + autoSalon.Slogan);
                Console.WriteLine("Description: " + autoSalon.Description);
                Console.WriteLine("Location: " + autoSalon.Location);
                Console.WriteLine("Location Link: " + autoSalon.LocationUrl);
                Console.WriteLine("Numbers: " + autoSalon.Number);
                Console.WriteLine();
            }

            // https://turbo.az/autos/7026350-bmw-m5

            //GetSpesificCarPuppeteer("https://turbo.az/autos/7026350-bmw-m5");

            #region GetBrands
            //var Brands = GetOptionsFromSelect<Brand>("q[make][]").Result;

            //foreach (var brand in Brands)
            //{
            //    Console.WriteLine("Brand Id " + brand.Id);
            //    Console.WriteLine("Brand Name " + brand.Name);
            //    Console.WriteLine();
            //}
            #endregion

            #region GetModels of All Brands
            //var Brands = GetOptionsFromSelect<Brand>("q[make][]").Result;
            //var Models = GetAllModels(Brands).Result;

            //foreach (var model in Models)
            //{
            //    Console.WriteLine("Model Id " + model.Id);
            //    Console.WriteLine("Model Name " + model.Name);
            //    Console.WriteLine("Model BrandId " + model.BrandId);
            //    Console.WriteLine("Model BaseModelId " + model.BaseModelId);
            //    Console.WriteLine();
            //}
            #endregion

            #region GetRegions
            //var Regions = GetOptionsFromSelect<Entities.Region>("q[region][]").Result;
            //foreach (var Region in Regions)
            //{
            //    Console.WriteLine("Id: " + Region.Id);
            //    Console.WriteLine("Region Name: " + Region.Name);
            //}
            #endregion

            #region GetYears
            //var Years = GetYears().Result;
            //foreach (var Year in Years)
            //{
            //    Console.WriteLine("Id: " + Year.Id);
            //    Console.WriteLine("Year: " + Year.Value);
            //}
            #endregion

            #region GetCategories
            //var Categories = GetOptionsFromSelect<Category>("q[category][]").Result;
            //foreach (var Category in Categories)
            //{
            //    Console.WriteLine("Id: " + Category.Id);
            //    Console.WriteLine("Category Name: " + Category.Name);
            //}
            #endregion

            #region GetColors
            //var Colors = GetOptionsFromSelect<Entities.Color>("q[color][]").Result;
            //foreach (var Color in Colors)
            //{
            //    Console.WriteLine("Id: " + Color.Id);
            //    Console.WriteLine("Color Name: " + Color.Name);
            //}
            #endregion

            #region GetFueltypes
            //var Fueltypes = GetOptionsFromSelect<Fueltype>("q[fuel_type][]").Result;
            //foreach (var Fueltype in Fueltypes)
            //{
            //    Console.WriteLine("Id: " + Fueltype.Id);
            //    Console.WriteLine("Transmission Name: " + Fueltype.Name);
            //}
            #endregion

            #region GetTransmissions
            //var Transmissions = GetOptionsFromSelect<Transmission>("q[transmission][]").Result;
            //foreach (var Transmission in Transmissions)
            //{
            //    Console.WriteLine("Id: " + Transmission.Id);
            //    Console.WriteLine("Transmission Name: " + Transmission.Name);
            //}
            #endregion

            #region GetCurrencies
            //var Currencies = GetOptionsFromSelect<Currency>("q[currency]").Result;
            //foreach (var Currency in Currencies)
            //{
            //    Console.WriteLine("Id: " + Currency.Id);
            //    Console.WriteLine("Currency Name: " + Currency.Name);
            //}
            #endregion

            Console.ReadLine();
        }
    }
}



// Where vs Contains vs Firstordefault

// internal vs public
