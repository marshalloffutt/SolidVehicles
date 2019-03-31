using System.Linq;
using System.Collections.Generic;
using SolidVehicles.Data;
using SolidVehicles.Vehicles;
using SolidVehicles.Interfaces;
using System;

namespace SolidVehicles
{

    public class Program
    {
        public static void Main()
        {
            // Build a collection of all vehicles that fly
            var flyingVehiclesCollection = new List<IAirVehicle>();

            var cessna = new Airplane();
            var blackhawk = new Helicopter();
            var flyingCar = new FlyingCar();

            flyingVehiclesCollection.Add(cessna);
            flyingVehiclesCollection.Add(blackhawk);
            flyingVehiclesCollection.Add(flyingCar);

            // With a single `foreach`, have each vehicle Fly()
            foreach (var flyingVehicle in flyingVehiclesCollection)
            {
                flyingVehicle.Fly();
            }

            // Build a collection of all vehicles that operate on roads
            var groundVehiclesCollection = new List<IGroundVehicle>();

            var modelT = new Car();
            groundVehiclesCollection.Add(modelT);
            groundVehiclesCollection.Add(flyingCar);

            // With a single `foreach`, have each road vehicle Drive()
            foreach (var groundVehicle in groundVehiclesCollection)
            {
                groundVehicle.Drive();
            }

            // Build a collection of all vehicles that operate on water
            var waterVehiclesCollection = new List<IWaterVehicle>();

            var speedBoat = new Boat();
            var jetSki = new Jetski();

            waterVehiclesCollection.Add(speedBoat);
            waterVehiclesCollection.Add(jetSki);

            // With a single `foreach`, have each water vehicle Drive()
            foreach (var aquaticVehicle in waterVehiclesCollection)
            {
                aquaticVehicle.Float();
            }

            Console.ReadKey();
        }
    }
}
