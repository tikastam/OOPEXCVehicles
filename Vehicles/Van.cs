using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    class Van: IFreightVeh, IPassVeh
    {
        public string Mark { get; set; }
        public string Model { get; set; }
        public int europrice { get; set; }
        public int transcapacity { get; set; }
        public int powmin { get; set; }
        public int powmax { get; set; }

        public int sitplaces { get; set; }

        public int speedlimit { get; set; }

        public int maxdistance { get; set; }

        public void Usability()
        {
            Console.WriteLine("Van can be used like freight or passenger vehicle");
        }

        public void Description()
        {
            Console.WriteLine(Mark + " " + Model + " costs " + europrice + " euros");
        }

        public void LCCap()
        {
            Console.WriteLine("The load capacity of " + Mark + " " + Model + " is " + transcapacity + " kilograms and has " + sitplaces + " seats" );
        }
        public void Engines()
        {
            Console.WriteLine("For " + Mark + " " + Model + " you can find between " + powmin + " and " + powmax + " horse power");
        }

        public void Drive()
        {
            Console.WriteLine(Mark + " " + Model + " has a speed limit " + speedlimit + " km/h, and driving limit is " + maxdistance + " km");
        }
    }
}
