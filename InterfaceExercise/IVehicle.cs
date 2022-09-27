using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal interface IVehicle
    {
        public string Model { get; set; }
        public string FuelType { get; set; }
        public int PassengerCapacity { get; set; }
        public int Cylinders { get; set; }

    }
}
