using System;
using SolidVehicles.Interfaces;

namespace SolidVehicles.Vehicles
{
    public class Airplane : IVehicle, IAirVehicle
    {
        public int Doors { get; set; }
        public bool Winged { get; set; }
        public int PassengerCapacity { get; set; }
        public string TransmissionType { get; set; }
        public double EngineVolume { get; set; }
        public double MaxAirSpeed { get; set; }

        public void Start()
        {
            Console.WriteLine("The airplane starts.");
        }

        public void Fly()
        {
            Console.WriteLine("The plane effortlessly glides through the clouds like a gleaming god of the Sun");
        }

        public void Land()
        {
            Console.WriteLine("The plane lands");
        }

        public void Stop()
        {
            Console.WriteLine("The plane finally stops moving");
        }
    }
}
