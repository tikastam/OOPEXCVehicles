using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    class Excavator:WMachines
    {
        private string ty = "Excavator";

        public int weightveh;

        public override string type { get { return ty; } set { ty = value; } }

        public override void Usability()
        {
            Console.WriteLine(ty + " used for excavating and shifting soil");
        }

        public override void Special()
        {
            Console.WriteLine(Mark + " " + Model + " is " + weightveh + "t, and costs " + europrice);
        }



    }
}
