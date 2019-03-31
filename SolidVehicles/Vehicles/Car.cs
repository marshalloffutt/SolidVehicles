using System;
using SolidVehicles.Interfaces;

namespace SolidVehicles.Vehicles
{
    public class Car : IVehicle, IGroundVehicle
    {
        public int Doors { get; set; }
        public bool Winged { get; set; } = false;
        public int PassengerCapacity { get; set; } = 4;
        public string TransmissionType { get; set; }
        public double EngineVolume {get; set; }
        public double MaxLandSpeed { get; set; }

        public void Start()
        {
            Console.WriteLine("The car's engine starts.");
        }

        public void Stop()
        {
            Console.WriteLine("The car stops.");
        }

        public void Drive()
        {
            Console.WriteLine("The car proceeds down the street.");
        }

        public void Park()
        {
            Console.WriteLine("The car is in park.");
        }
    }
}
