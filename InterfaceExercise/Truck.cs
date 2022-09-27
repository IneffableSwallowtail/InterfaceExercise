using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal class Truck : IVehicle, ICompany
    {
        public Truck(string model, string fuelType, int passengerCapacity, int cylinders, string companyName, string logo, string bedLength, int weightCapacity)
        {
            Model = model;
            FuelType = fuelType;
            PassengerCapacity = passengerCapacity;
            Cylinders = cylinders;
            CompanyName = companyName;
            Logo = logo;
            BedLength = bedLength;
            WeightCapacity = weightCapacity;
        }

        public string Model { get; set; }
        public string FuelType { get; set; }
        public int PassengerCapacity { get; set; }
        public int Cylinders { get; set; }
        public string CompanyName { get; set; }
        public string Logo { get; set; }
        public string BedLength { get; set; }
        public int WeightCapacity { get; set; }
    }
}
