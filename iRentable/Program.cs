using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRentable
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<iRentable> rentList = new List<iRentable>();
            rentList.Add(new House("Home"));
            rentList.Add(new Car("Truck"));
            rentList.Add(new Boat("Yacht"));
            foreach(iRentable item in rentList)
            {
                Console.WriteLine(item.GetDescription() + " " + item.GetDailyRate());

            }
            Console.ReadLine();
        }






        interface iRentable
        {
            decimal GetDailyRate();
            string GetDescription();
        }

        public class Car : iRentable
        {
            private decimal _dailyRate = 60m;
            public string Description { get; set; }

            public Car(string description)
            {
                Description = description;
            }
            public decimal GetDailyRate()
            {
                return Decimal.Round(_dailyRate = 60, 2);
            }
            public string GetDescription()
            {
                return Description;
            }
        }
        public class House : iRentable
        {
            private decimal _weeklyRate = 275m;

            public string Description { get; set; }

            public House(string description)
            {
                Description = description;
            }
            public decimal GetDailyRate()
            {
                return Decimal.Round(_weeklyRate / 7);
            }
            public decimal GetWeeklyRate()
            {
                return Decimal.Round(_weeklyRate );
            }
            public string GetDescription()
            {
                return Description;
            }

        }
        public class Boat : iRentable
        {
            private decimal _hourlyRate = 12.5m;
            public string Description { get; set; }

            public Boat(string description)
            {
                Description = description;
            }

            public decimal GetDailyRate()
            {
                return Decimal.Round(_hourlyRate *24);

            }
            public string GetDescription()
            {
                return Description;
            }
        }
    }
}
