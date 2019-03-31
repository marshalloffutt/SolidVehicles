using System;
using System.Collections.Generic;
using System.Text;

namespace SolidVehicles.Interfaces
{
    interface IGroundVehicle
    {
        double MaxLandSpeed { get; set; }

        void Drive();
        void Park();
    }
}
