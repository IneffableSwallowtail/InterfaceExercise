using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal class SUV : IVehicle, ICompany
    {
        public SUV(string model, string fuelType, int passengerCapacity, int cylinders, string slogan, string logo, bool foldFlatSeats, bool roofRack)
        {
            Model = model;
            FuelType = fuelType;
            PassengerCapacity = passengerCapacity;
            Cylinders = cylinders;
            CompanyName = slogan;
            Logo = logo;
            FoldFlatSeats = foldFlatSeats;
            RoofRack = roofRack;
        }

        public string Model { get; set; }
        public string FuelType { get; set; }
        public int PassengerCapacity { get; set; }
        public int Cylinders { get; set; }
        public string CompanyName { get; set; }
        public string Logo { get; set; }
        public bool FoldFlatSeats { get; set; }
        public bool RoofRack { get; set; }
    }
}
