﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace TurboazFetching.Entities
{
    public class Car 
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public int ModelId { get; set; }
        public int YearId { get; set; }
        public int ColorId { get; set; }
        public int RegionId { get; set; }
        public int CategoryId { get; set; }
        public int FueltypeId { get; set; }
        public int CurrencyId { get; set; }
        public int AutoSalonId { get; set; }
        public int TransmissionId { get; set; }
        public ushort EngineVolume { get; set; }
        public ushort HorsePower { get; set; }
        public DateTime LastUpdated { get; set; }
        public string Comment { get; set; }
        public int Mileage { get; set; }
        public int Price { get; set; }
        public bool CreditAvailable { get; set; }
        public bool BarterAvailable { get; set; }
        public List<Image> Images { get; set; }
        public List<Feature> Features { get; set; }

        public Brand Brand { get; set; }
        public Model Model { get; set; }
        public Year Year { get; set; }
        public Color Color { get; set; }
        public Region Region { get; set; }
        public Category Category { get; set; }
        public Fueltype Fueltype { get; set; }
        public Currency Currency { get; set; }
        public Transmission Transmission { get; set; }
        public AutoSalon AutoSalon { get; set; }

        public Car() { }

        public Car(int id, Brand brand, Model model, Year year,
                   Region region, ushort engineVolume, ushort horsePower,
                   Fueltype fueltype, Transmission transmission, int mileage,
                   int price, Currency currency, bool creditAvailable, bool barterAvailable,
                   string comment, List<Image> images, Category category, Color color)
        {
            Id = id;
            Brand = brand;
            Model = model;
            Year = year;
            Region = region;
            EngineVolume = engineVolume;
            HorsePower = horsePower;
            Fueltype = fueltype;
            Transmission = transmission;
            Mileage = mileage;
            Price = price;
            Currency = currency;
            CreditAvailable = creditAvailable;
            BarterAvailable = barterAvailable;
            Comment = comment;
            Images = images;
            Category = category;
            Color = color;
        }
    }
}
