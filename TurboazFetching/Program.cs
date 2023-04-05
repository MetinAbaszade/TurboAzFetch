using HtmlAgilityPack;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using PuppeteerSharp;
using System;
using System.Xml.Linq;
using TurboazFetching.Data;
using Microsoft.EntityFrameworkCore;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Drawing;
using TurboazFetching.Entities;
using Microsoft.VisualBasic.FileIO;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Runtime.Intrinsics.X86;

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

            var test = doc.DocumentNode.InnerHtml;

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

        public static async void GetAllBrandandModels()
        {
            string Url = "https://turbo.az";
            var optionvalue = String.Empty;

            var doc = DownloadPage(Url).Result;

            var elements = doc.DocumentNode.Descendants("select").FirstOrDefault(e => e.GetAttributeValue("name", "") == "q[make][]").Descendants("option");

            foreach (var item in elements)
            {
                optionvalue = item.GetAttributeValue("value", "");

                Console.WriteLine("Brand: ");
                Console.WriteLine("BrandOptionValue: " + optionvalue);
                Console.WriteLine("InnerHtml: " + item.InnerHtml);

                Console.WriteLine();

                Console.WriteLine("Models: ");

                var models = doc.DocumentNode.Descendants("select").FirstOrDefault(e => e.GetAttributeValue("name", "") == "q[model][]")
                    .Descendants("option").Where(e => e.GetAttributeValue("class", "") == optionvalue);

                foreach (var model in models)
                {
                    Console.Write("ModelOptionValue: " + model.GetAttributeValue("value", ""));
                    Console.WriteLine(" Model: " + model.InnerHtml);

                }

                Console.WriteLine();
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
                    //var Name = await element.QuerySelectorAsync(".products-i__name");
                    //var Atributes = await element.QuerySelectorAsync(".products-i__attributes");
                    //var Datetime = await element.QuerySelectorAsync(".products-i__datetime");
                    var CarLink = await element.QuerySelectorAsync(".products-i__link");

                    Console.WriteLine($"Car {CarCount++}");
                    Console.WriteLine("CarLink: " + await CarLink?.EvaluateFunctionAsync<string>("node => node.href"));
                    GetSpesificCarPuppeteer(await CarLink?.EvaluateFunctionAsync<string>("node => node.href"));
                    //Console.WriteLine("Name: " + await Name?.EvaluateFunctionAsync<string>("node => node.innerText"));
                    //Console.WriteLine("Atributes: " + await Atributes?.EvaluateFunctionAsync<string>("node => node.innerText"));
                    //Console.WriteLine("Datetime: " + await Datetime?.EvaluateFunctionAsync<string>("node => node.innerText"));
                    //Console.WriteLine();
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

            var test = doc.DocumentNode.InnerHtml;

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

        private static T CreateElement<T>(int idValue, string nameValue) where T : new()
        {
            T elementObj = new T();

            PropertyInfo idProperty = typeof(T).GetProperty("Id");
            PropertyInfo nameProperty = typeof(T).GetProperty("Name");

            if (idProperty != null && nameProperty != null)
            {
                idProperty.SetValue(elementObj, idValue);
                nameProperty.SetValue(elementObj, nameValue);
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
            var OptionValue = String.Empty;

            // List of options inside select:
            var ProductOptions = doc.DocumentNode.Descendants("select")
                .FirstOrDefault(e => e.GetAttributeValue("name", "") == selectname)?.Descendants("option");

            if (ProductOptions == null)
            {
                throw new Exception($"Could not find select with specified name: {selectname}");
            }

            List<T> elements = new List<T>();
            int id = 1;

            foreach (var Option in ProductOptions)
            {
                OptionValue = Option.InnerHtml;
                var NewElement = CreateElement<T>(id++, OptionValue);
                elements.Add(NewElement);
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

        static async Task Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            AppDbContext dbContext = new AppDbContext();

            // GetCars();
            // GetAllBrandandModels();
            // GetCarsPuppeteer();
            // GetCarsSelenium();
            // GetCities();

            // https://turbo.az/autos/7026350-bmw-m5

            //GetSpesificCarPuppeteer("https://turbo.az/autos/7026350-bmw-m5");

            //// GetRegions:
            //var Regions = GetOptionsFromSelect<Entities.Region>("q[region][]").Result;
            //foreach (var Region in Regions)
            //{
            //    Console.WriteLine("Id: " + Region.Id);
            //    Console.WriteLine("Region Name: " + Region.Name);
            //}

            // GetYears:
            var Years = GetYears().Result;
            foreach (var Year in Years)
            {
                Console.WriteLine("Id: " + Year.Id);
                Console.WriteLine("Year: " + Year.Value);
            }

            //// GetCategories:
            //var Categories = GetOptionsFromSelect<Category>("q[category][]").Result;
            //foreach (var Category in Categories)
            //{
            //    Console.WriteLine("Id: " + Category.Id);
            //    Console.WriteLine("Category Name: " + Category.Name);
            //}

            //// GetColors:
            //var Colors = GetOptionsFromSelect<Entities.Color>("q[color][]").Result;
            //foreach (var Color in Colors)
            //{
            //    Console.WriteLine("Id: " + Color.Id);
            //    Console.WriteLine("Color Name: " + Color.Name);
            //}

            //// GetFueltypes:
            //var Fueltypes = GetOptionsFromSelect<Fueltype>("q[fuel_type][]").Result;
            //foreach (var Fueltype in Fueltypes)
            //{
            //    Console.WriteLine("Id: " + Fueltype.Id);
            //    Console.WriteLine("Transmission Name: " + Fueltype.Name);
            //}

            //// GetTransmissions:
            //var Transmissions = GetOptionsFromSelect<Transmission>("q[transmission][]").Result;
            //foreach (var Transmission in Transmissions)
            //{
            //    Console.WriteLine("Id: " + Transmission.Id);
            //    Console.WriteLine("Transmission Name: " + Transmission.Name);
            //}

            //// GetCurrencies:
            //var Currencies = GetOptionsFromSelect<Currency>("q[currency]").Result;
            //foreach (var Currency in Currencies)
            //{
            //    Console.WriteLine("Id: " + Currency.Id);
            //    Console.WriteLine("Currency Name: " + Currency.Name);
            //}

            // GetImagesofCarandCopytoFile("https://turbo.az/autos/7026350-bmw-m5");

            Console.ReadLine();
        }
    }
}



// Where vs Contains vs Firstordefault

// internal vs public
