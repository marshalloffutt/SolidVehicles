using System;
using SolidVehicles.Interfaces;

namespace SolidVehicles.Vehicles
{
    public class Helicopter : IVehicle, IAirVehicle
    {
        public int Doors { get; set; }
        public bool Winged { get; set; } = false;
        public int PassengerCapacity { get; set; }
        public string TransmissionType { get; set; }
        public double EngineVolume { get; set; }
        public double MaxAirSpeed { get; set; }

        public void Start()
        {
            Console.WriteLine("The helicopter starts up.");
        }

        public void Stop()
        {
            Console.WriteLine("The helicopter comes to a stop.");
        }

        public void Fly()
        {
            Console.WriteLine("The helicopter flies through the air.");
        }

        public void Land()
        {
            Console.WriteLine("The helicopter lands safely.");
        }
    }
}
