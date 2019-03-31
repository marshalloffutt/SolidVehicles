using System;
using SolidVehicles.Interfaces;

namespace SolidVehicles.Vehicles
{
    public class Jetski : IVehicle, IWaterVehicle
    {
        public int Doors { get; set; } = 0;
        public bool Winged { get; set; } = false;
        public int PassengerCapacity { get; set; } = 2;
        public string TransmissionType { get; set; }
        public double EngineVolume { get; set; }
        public double MaxWaterSpeed { get; set; }

        public void Start()
        {
            Console.WriteLine("The jetski starts.");
        }

        public void Stop()
        {
            Console.WriteLine("The jetski comes to a stop.");
        }

        public void Float()
        {
            Console.WriteLine("The jetski idles on the water.");
        }

        public void Sink()
        {
            Console.WriteLine("Oh no!! The jetski is sinking!");
        }
    }
}
