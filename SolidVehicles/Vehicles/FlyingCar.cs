using System;
using SolidVehicles.Interfaces;

namespace SolidVehicles.Vehicles
{
    public class FlyingCar : IVehicle, IGroundVehicle, IAirVehicle
    {
        public int Doors { get; set; } = 4;
        public bool Winged { get; set; } = true;
        public int PassengerCapacity { get; set; } = 4;
        public string TransmissionType { get; set; }
        public double EngineVolume { get; set; }
        public double MaxLandSpeed { get; set; }
        public double MaxAirSpeed { get; set; }

        public void Start()
        {
            Console.WriteLine("The flying car's engine starts.");
        }

        public void Stop()
        {
            Console.WriteLine("The flying car comes to a stop.");
        }

        public void Drive()
        {
            Console.WriteLine("The flying car drives on the road.");
        }

        public void Fly()
        {
            Console.WriteLine("The flying car glides through the air.");
        }

        public void Land()
        {
            Console.WriteLine("The flying car lands safely.");
        }

        public void Park()
        {
            Console.WriteLine("The flying car is parked.");
        }
    }
}
