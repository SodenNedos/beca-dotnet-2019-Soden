using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessCore;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Door[] doors = new Door[]
                {
                new Door( true, true),
                new Door( true, true),
                new Door( true, true),
                new Door( true, true),
                };
            Engine motor = new Engine(2500, 120);
            Chassis chassis = new Chassis(800, "carbono");
            Wheel[] wheels = new Wheel[]
                {
                new Wheel( "Michellin", 50.5, 60.7, 200),
                new Wheel( "Michellin", 50.5, 60.7, 200),
                new Wheel( "Michellin", 50.5, 60.7, 200),
                new Wheel( "Michellin", 50.5, 60.7, 200),
                };
            BodyWork bodyWork = new BodyWork(false, false, "Carbono", "Rojo");
            Vehicle coche1 = new Vehicle("4152 Al", VehicleType.car, true, false, doors, motor, chassis, wheels, bodyWork);
            Console.WriteLine(coche1);
            Console.ReadLine();
        }
    }
}
