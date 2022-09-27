using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal class Car : IVehicle, ICompany
    {
        public Car(string model, string fuelType, int passengerCapacity, int cylinders, string slogan, string logo, string bodyStyle, bool sunroof)
        {
            Model = model;
            FuelType = fuelType;
            PassengerCapacity = passengerCapacity;
            Cylinders = cylinders;
            CompanyName = slogan;
            Logo = logo;
            BodyStyle = bodyStyle;
            Sunroof = sunroof;
        }
        public string Model { get; set; }
        public string FuelType { get; set; }
        public int PassengerCapacity { get; set; }
        public int Cylinders { get; set; }
        public string CompanyName { get; set; }
        public string Logo { get; set; }
        public string BodyStyle { get; set; }
        public bool Sunroof { get; set; }
    }
}
