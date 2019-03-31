using System;
using SolidVehicles.Interfaces;

namespace SolidVehicles.Vehicles
{
    public class Boat : IVehicle, IWaterVehicle
    {
        public int Doors { get; set; }
        public bool Winged { get; set; }
        public int PassengerCapacity { get; set; }
        public string TransmissionType { get; set; }
        public double EngineVolume { get; set; }
        public double MaxWaterSpeed { get; set; }

        public void Start()
        {
            Console.WriteLine("The boat captain turns the key.");
        }

        public void Stop()
        {
            Console.WriteLine("The boat captain turns the engine off.");
        }

        public void Float()
        {
            Console.WriteLine("The boat floats on the water.");
        }
        public void Sink()
        {
            Console.WriteLine("The boat sinks to the bottom of the ocean.");
        }
    }
}
