using HtmlAgilityPack;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using PuppeteerSharp;
using System;
using System.Xml.Linq;
using TurboazFetching.Data;
using Microsoft.EntityFrameworkCore;

namespace TurboazFetching
{
    internal class Program
    {
        public static async Task<HtmlDocument> DownloadPage(string Url) {
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

                var productNodes = doc.DocumentNode.Descendants("div");
                //.Where(node => node.GetAttributeValue("class", "")
                //    .Contains("products-i"));

                foreach (var element in productNodes)
                {
                    if (element.GetAttributeValue("class", "") == "products-i")
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
        }

        public static async void GetAllBrands()
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

        public static async void GetCarsPuppeteer()
        {
            Console.WriteLine("How many pages do you want to fetch: ");
            int pageCount = int.Parse(Console.ReadLine());

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
                    var Name = await element.QuerySelectorAsync(".products-i__name");
                    var Atributes = await element.QuerySelectorAsync(".products-i__attributes");
                    var Datetime = await element.QuerySelectorAsync(".products-i__datetime");
                    var CarLink = await element.QuerySelectorAsync(".products-i__link");

                    Console.WriteLine($"Car {CarCount++}");
                    Console.WriteLine("Name: " + await Name?.EvaluateFunctionAsync<string>("node => node.innerText"));
                    Console.WriteLine("Atributes: " + await Atributes?.EvaluateFunctionAsync<string>("node => node.innerText"));
                    Console.WriteLine("Datetime: " + await Datetime?.EvaluateFunctionAsync<string>("node => node.innerText"));
                    Console.WriteLine("CarLink: " + await CarLink?.EvaluateFunctionAsync<string>("node => node.href"));
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
            }
        }

        public static async void GetSpesificCarPuppeteer() {

            var url = $"https://turbo.az/autos/7249762-bmw-528";

            var doc = DownloadPage(url).Result;

            var productNodes = doc.DocumentNode.Descendants("div");


            foreach (var element in productNodes)
            {
                if (element.GetAttributeValue("class", "") == "product-properties__i")
                {
                    var Property = element.Descendants().ToArray()[0].InnerHtml;
                    var Value = element.Descendants().ToArray().Last().InnerHtml;
                    Console.WriteLine($"{Property}: {Value}");
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

                for (int j = 0; j < productElements.Count; j++)
                {
                    var productNode = productElements[j];

                    var name = productNode.FindElement(By.CssSelector(".products-i__name")).Text;
                    var attributes = productNode.FindElement(By.CssSelector(".products-i__attributes")).Text;
                    var datetime = productNode.FindElement(By.CssSelector(".products-i__datetime")).Text;

                    Console.WriteLine($"Car {j + 1}");
                    Console.WriteLine("Name: " + name);
                    Console.WriteLine("Attributes: " + attributes);
                    Console.WriteLine("Datetime: " + datetime);
                    Console.WriteLine();
                }
            }
        }

        public static async void GetCities() {
            var url = $"https://turbo.az";
            var doc = DownloadPage(url).Result;
            var OptionValue = String.Empty;

            var productNodes = doc.DocumentNode.Descendants("select").FirstOrDefault(e => e.GetAttributeValue("name", "") == "q[region][]").Descendants("option"); ;

            int Id = 1;
            foreach (var item in productNodes)
            {
                OptionValue = item.GetAttributeValue("value", "");

                Console.WriteLine("City: ");
                Console.WriteLine("CityOptionValue: " + OptionValue);
                Console.WriteLine("InnerHtml: " + item.InnerHtml);
                Console.WriteLine();
            }
        }

        public static async void GetYears()
        {
            var url = $"https://turbo.az";
            var doc = DownloadPage(url).Result;
            var OptionValue = String.Empty;

            var productNodes = doc.DocumentNode.Descendants("select").FirstOrDefault(e => e.GetAttributeValue("name", "") == "q[year_from]").Descendants("option"); ;

            foreach (var item in productNodes)
            {
                OptionValue = item.GetAttributeValue("value", "");

                Console.WriteLine("Year: ");
                Console.WriteLine("YearOptionValue: " + OptionValue);
                Console.WriteLine("InnerHtml: " + item.InnerHtml);

                Console.WriteLine();
            }

        }

        public static async void GetCategory()
        {
            var url = $"https://turbo.az";
            var doc = DownloadPage(url).Result;
            var OptionValue = String.Empty;

            var productNodes = doc.DocumentNode.Descendants("select").FirstOrDefault(e => e.GetAttributeValue("name", "") == "q[category][]").Descendants("option"); ;

            foreach (var item in productNodes)
            {
                OptionValue = item.GetAttributeValue("value", "");

                Console.WriteLine("Category: ");
                Console.WriteLine("CategoryOptionValue: " + OptionValue);
                Console.WriteLine("InnerHtml: " + item.InnerHtml);

                Console.WriteLine();
            }

        }


        static async Task Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            AppDbContext dbContext = new AppDbContext();
            foreach (var item in dbContext.Cities.ToList())
            {
                Console.WriteLine(item.Name);
            }
            
            // GetCars();
            // GetAllBrands();
            // GetCarsPuppeteer();
            // GetCarsSelenium();
            // GetCities();
            // GetYears();
            // GetCategory();
            // GetSpesificCarPuppeteer();
  
        }
    }
}



// Where vs Contains vs Firstordefault

// internal vs public
