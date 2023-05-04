using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    interface IFreightVeh : IVehicle
    {
        int transcapacity { get; set; }

        int powmin { get; set; }

        int powmax { get; set; }

        void LCCap();
        void Engines();

        
    }
}
