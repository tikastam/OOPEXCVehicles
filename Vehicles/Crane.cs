using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    class Crane: WMachines
    {
        private string ty = "Crane";
        public override string type { get { return ty; } set { ty = value; } }

        public int carrcap;
        public int weightveg;

        public override void Usability()
        {
            Console.WriteLine(ty + "s can be used for work on oil fields, mines, construction site ...");
        }

        public override void Special()
        {
            Console.WriteLine("Carring capacity of " + Mark + " " + Model + " is " + carrcap + "t and his weight is " + weightveg + "t ,costs " + europrice + " euros");
        }
    }
}
