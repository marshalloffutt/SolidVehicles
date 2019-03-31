using SolidVehicles.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidVehicles.Data
{
    class GroundVehiclesRepository
    {
        static List<IGroundVehicle> _groundVehicles { get; set; }

        public GroundVehiclesRepository()
        {
            _groundVehicles = new List<IGroundVehicle>();
        }
    }
}
