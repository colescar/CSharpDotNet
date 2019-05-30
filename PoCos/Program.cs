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

    }
}
