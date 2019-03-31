using SolidVehicles.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidVehicles.Data
{
    class AirVehiclesRepository
    {
        static List<IAirVehicle> _airVehicles { get; set; }

        public AirVehiclesRepository()
        {
            _airVehicles = new List<IAirVehicle>();
        }
    }
}
