using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    class Bulldozer:WMachines
    {
        private string ty = "Bulldozer";

        public int weightveh;
        public override string type { get { return ty; } set { value = ty; } }

        public override void Usability()
        {
            Console.WriteLine(ty + " can be used for snow cleaning or excavating and shifting soil");
        }
        public override void Special()
        {
            Console.WriteLine(Mark + " " + Model + " is " + weightveh + "t, and costs " + europrice);
        }
    }
}
