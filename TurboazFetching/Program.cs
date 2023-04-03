using System;
using System.Linq;
using System.Net.Http;
using HtmlAgilityPack;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace TurboazFetching
{
    internal class Program
    {
        public async void GetCars()
        {
            var httpClient = new HttpClient();
            Console.WriteLine("How many pages do you want to fetch: ");
            int pagecountcount = int.Parse(Console.ReadLine());
            int carcount = 1;

            for (int i = 0; i < pagecountcount; i++)
            {
                var url = $"https://turbo.az/autos?page={i}";

                var response = await httpClient.GetAsync(url);
                var content = await response.Content.ReadAsStringAsync();

                var doc = new HtmlDocument();
                doc.LoadHtml(content);

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

        public async static void GetAllBrands() {

            HttpClient httpClient = new HttpClient();
            string baseUrl = "https://turbo.az";
            var optionvalue = String.Empty;

            var response = await httpClient.GetAsync(baseUrl);
            var content = await response.Content.ReadAsStringAsync();

            var doc = new HtmlDocument();
            doc.LoadHtml(content);

            var elements = doc.DocumentNode.Descendants("select").FirstOrDefault(e => e.GetAttributeValue("name", "") == "q[make][]").Descendants("option");
            foreach (var item in elements)
            {
                optionvalue = item.GetAttributeValue("value", "");

                Console.WriteLine("Brand: ");
                Console.WriteLine("BrandOptionValue: " + optionvalue);
                Console.WriteLine("InnerHtml: " + item.InnerHtml);

                Console.WriteLine();

                Console.WriteLine("Models: ");

                baseUrl = "https://turbo.az/autos";

                var parameters = new Dictionary<string, string>
                {
                    { "q[make][]", $"{optionvalue}" }
                };


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

        static async Task Main(string[] args)
        {
            GetAllBrands();
            Console.ReadLine();
        }
    }
}



// Where vs Contains vs Firstordefault