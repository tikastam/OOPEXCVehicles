using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    interface IVehicle
    {
         string Mark { get; set; }
         string Model { get; set; }
         int europrice { get; set; }

        void Usability();
        void Description();
    }
}
