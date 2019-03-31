using SolidVehicles.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidVehicles.Data
{
    class WaterVehiclesRepository
    {
        static List<IWaterVehicle> _waterVehicles { get; set; }

        public WaterVehiclesRepository()
        {
            _waterVehicles = new List<IWaterVehicle>();
        }
    }
}
