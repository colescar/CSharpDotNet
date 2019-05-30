using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoCos
{
    class Program

    {
        static void Main(string[] args)
        {
            // Car myCar = new Car();
            //myCar.Model = "Ford";
            //myCar.Year = "2015";
            //myCar.NumberofDoors = 2;

            //Console.WriteLine(myCar.GetCarDetails());
            


        }

    }

    class DriversLicense
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string LicenseNumber { get; set; }

        public DriversLicense(string First_Name, string Last_Name, string gender, string number)
        {
            FirstName = First_Name;
            LastName = Last_Name;
            Gender = gender;
            LicenseNumber = number;
        }
    }
    class book
    {
        public string Title { get; set;}
        public string Author { get; set;}
        public string Pages { get; set; }
        public string SKU { get; set; }
        public string Publisher { get; set; }
        public string Price { get; set; }

        public book(string title, string author, string pages, string sku, string publisher, string price)
        {
            Title = title;
            Author = author;
            Pages = pages;
            SKU = sku;
            Publisher = publisher;
            Price = price;

        }




    }
    class Airplane
    {
        public string Manufactuer { get; set; }
        public string Model { get; set; }
        public string Variant { get; set; }
        public string Capacity { get; set; }
        public string Engines { get; set; }

        public Airplane(string manufactuer, string model, string variant, string capacity, string engines)
        {
            Manufactuer = manufactuer;
            Model = model;
            Variant = variant;
            Capacity = capacity;
            Engines = engines;
        }
           
    }
}
