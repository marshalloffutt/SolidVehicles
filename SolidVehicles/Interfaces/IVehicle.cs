using System;
using System.Collections.Generic;
using System.Text;

namespace SolidVehicles.Interfaces
{
    interface IVehicle
    {
        int Doors { get; set; }
        bool Winged { get; set; }
        int PassengerCapacity { get; set; }
        string TransmissionType { get; set; }
        double EngineVolume { get; set; }

        void Start();
        void Stop();
    }
}
