using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    abstract class WMachines:IVehicle
    {
        public string Mark { get; set; }
        public string Model { get; set; }
        public int europrice { get; set; }

        public abstract string type { get; set; }

        private string fuel = "Dizel";

        public int hpower;
        public int workingcapa;
        public string Fuel
        {
            get { return fuel; }
            set { fuel = value; }
        }

        public void Description()
        {
            Console.WriteLine(Mark + " " + Model + " have a engine of " + hpower + " horse power and runs on " + fuel);
        }

        public abstract void Usability();
        public abstract void Special();
    }
}
