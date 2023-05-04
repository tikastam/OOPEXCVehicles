using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    enum Trans
    {
        manual = 0,
        automatic = 1
    }
    enum MType
    {
        Scooter = 0,
        Cross = 1,
        Chopper = 2,
        Sport=3
    }
    enum UseM
    {
        City=0,
        Long=1,
        Offroad=2,
        Racetrack=3
    }
    class Motorcycles:IVehicle
    {
        public string Mark { get; set; }
        public string Model { get; set; }
        public int europrice { get; set; }
        public int type { get; set; }
        public int transmition { get; set; }
        public int hpower { get; set; }

        

        public void Usability()
        {
            
            Console.WriteLine(Mark + " " + Model + " is recommended for " + (UseM)type + " because it is " + (MType)type + " type motorcycle");
        }
        public void Description()
        {
            Console.WriteLine(Mark + " " + Model + " with " + (Trans)transmition + " transmition and " + hpower + " horse power costs " + europrice + " euros");
        }
    }
}
