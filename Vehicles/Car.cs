using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    class Car:IPassVeh
    {
        public string Mark { get; set; }
        public string Model { get; set; }
        public int europrice { get; set; }
        public int sitplaces { get; set; }
        public int speedlimit { get; set; }
        public int maxdistance { get; set; }

        public void Drive()
        {
            Console.WriteLine(Mark + " " + Model + " has a speed limit " + speedlimit + " km/h");
        }

        public void Usability()
        {
            Console.WriteLine(Mark + " " + Model + " and it is intended for driving up to " + sitplaces + " people");
        }

        public void Description()
        {
            Console.WriteLine(Mark + " " + Model + " costs " + europrice + " and driving limit is " + maxdistance + " km");
        }
    }
}
