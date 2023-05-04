using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    class Truck:IFreightVeh
    {
        public string Mark { get; set; }
        public string Model { get; set; }
        public int europrice { get; set; }
        public int transcapacity { get; set; }
        public int lcap { get; set; }
        public int powmin { get; set; }

        public int powmax { get; set; }

        public void Usability()
        {
            Console.WriteLine("With " + Mark + " " + Model + " it serves for the delivery of various products");
        }
        public void LCCap()
        {
            Console.WriteLine("The load capacity of " + Mark + " " + Model + " is " + lcap + " tones if you choise most powerfull engine and equipment");
        }
        
        public void Description()
        {
            Console.WriteLine("Truck " + Mark + " " + Model + " costs " + europrice + " euros");
        }

        public void Engines()
        {
            Console.WriteLine("For " + Mark + " " + Model + " you can choise between " + powmin + " and " + powmax + " horse power");
        }
    }
}
