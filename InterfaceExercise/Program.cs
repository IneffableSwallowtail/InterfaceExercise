using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values

            Truck truck = new Truck("C3500", "diesel", 2, 8, "Chevrolet", "bowtie", "standard", 4000);
            SUV suv = new SUV("Navigator", "premium", 6, 6, "Lincoln", "Continental star", true, true);
            Car car = new Car("S5 Premium Plus", "premium", 4, 6, "Audi", "link of four rings", "hatchback", true);

            Console.WriteLine($"The {truck.CompanyName} {truck.Model} can hold {truck.PassengerCapacity} passengers, " +
                $"has a {truck.BedLength} bed size, has an {truck.Cylinders}-cylinder engine, " +
                $"can carry {truck.WeightCapacity} lbs, and takes {truck.FuelType} fuel. {truck.CompanyName}'s logo is a {truck.Logo}.\n");

            Console.Write($"The {suv.CompanyName} {suv.Model} can hold {suv.PassengerCapacity} passengers, " +
                $"has a {suv.Cylinders}-cylinder engine, and takes {suv.FuelType} fuel. {suv.CompanyName}'s logo is a {suv.Logo}. ");
            if (suv.FoldFlatSeats)
            {
                Console.Write("It has fold-flat seats");
                if (suv.RoofRack)
                    Console.WriteLine(" and a roof rack.\n");
                else
                    Console.WriteLine(".\n");
            }
            else if (suv.RoofRack)
                Console.WriteLine("It has a roof rack.");

            Console.Write($"The {car.CompanyName} {car.Model} {car.BodyStyle} can hold {car.PassengerCapacity} passengers, " +
                $"has an {car.Cylinders}-cylinder engine, and takes {car.FuelType} fuel. {car.CompanyName}'s logo is a {car.Logo}. ");
            if (car.Sunroof) Console.WriteLine($"The {car.Model} has a sunroof.");
        }
    }
}
