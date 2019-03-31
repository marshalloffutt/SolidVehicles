using System;
using System.Collections.Generic;
using System.Text;

namespace SolidVehicles.Interfaces
{
    interface IAirVehicle
    {
        double MaxAirSpeed { get; set; }

        void Fly();
        void Land();
    }
}
