using System;
using System.Collections.Generic;
using System.Text;

namespace SolidVehicles.Interfaces
{
    interface IWaterVehicle
    {
        double MaxWaterSpeed { get; set; }

        void Float();
        void Sink();
    }
}
