using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Truck FH16 = new Truck();
            FH16.Mark = "Volvo";
            FH16.Model = "FH16";
            FH16.transcapacity = 40;
            FH16.europrice = 150000;
            FH16.powmin = 460;
            FH16.powmax = 750;
            FH16.lcap = 40;
            FH16.Usability();
            FH16.LCCap();
            FH16.Description();
            FH16.Engines();

            Console.WriteLine("\n");
            //Truck

            
            Car A6 = new Car();
            A6.Mark = "Audi";
            A6.Model = "A6";
            A6.maxdistance = 1000000;
            A6.sitplaces = 5;
            A6.speedlimit = 280;
            A6.europrice = 70000;

            A6.Drive();
            A6.Description();
            A6.Usability();


            Console.WriteLine("\n");
            //Car


            Van Transit = new Van();
            Transit.Mark = "Ford";
            Transit.Model = "Transit";
            Transit.maxdistance = 1200000;
            Transit.europrice = 40000;
            Transit.powmax = 130;
            Transit.powmin = 110;
            Transit.sitplaces = 3;
            Transit.speedlimit = 200;
            Transit.transcapacity = 3500;

            Transit.Description();
            Transit.Drive();
            Transit.Engines();
            Transit.LCCap();
            Transit.Usability();

            Console.WriteLine("\n");
            //Van


            Motorcycles CBR1000rr = new Motorcycles();
            CBR1000rr.Mark = "Honda";
            CBR1000rr.Model = "CBR1000rr";
            CBR1000rr.hpower = 1000;
            CBR1000rr.europrice = 18000;
            CBR1000rr.transmition = 0;
            CBR1000rr.type = 3;

            CBR1000rr.Usability();
            CBR1000rr.Description();


            Console.WriteLine("\n");
            // Motorcycle



            Excavator ex = new Excavator();
            ex.Mark = "JCB";
            ex.Model = "140X";
            ex.hpower = 110;
            ex.workingcapa = 4800;
            ex.europrice = 115000;
            ex.Special();
            ex.Usability();
            ex.Description();

            Console.WriteLine("\n");
            //Excavator-WMachines


            Crane XCT25 = new Crane();
            XCT25.carrcap = 25;
            XCT25.europrice = 180000;
            XCT25.hpower = 300;
            XCT25.Mark = "XCMG";
            XCT25.Model = "XCT25";
            XCT25.weightveg = 30;
            XCT25.Description();
            XCT25.Usability();
            XCT25.Special();

            Console.WriteLine("\n");
            //Crane-Wmachines

            Bulldozer bu = new Bulldozer();
            bu.europrice = 20000;
            bu.hpower = 76;
            bu.Mark = "CAT";
            bu.Model = "D4E";
            bu.weightveh = 10;
            bu.Description();
            bu.Special();
            bu.Usability();

            Console.WriteLine("\n");
            Console.ReadKey();
        }
    }
}
