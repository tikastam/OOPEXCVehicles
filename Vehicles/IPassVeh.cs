using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    interface IPassVeh:IVehicle
    {
        int sitplaces { get; set; }

        int speedlimit { get; set; }

        int maxdistance { get; set; }

        void Drive();
    }
}
