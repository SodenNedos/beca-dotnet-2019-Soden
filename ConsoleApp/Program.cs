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
            Door door = new Door(2, true, true);
            Motor motor = new Motor(2500, 120);
            Chassis chassis = new Chassis(800, "carbono");
            Wheel wheel = new Wheel(4, "Michellin", 50.5, 60.7, 200);
            BodyWork bodyWork = new BodyWork(false, false, "Carbono", "Rojo");
            Vehicle coche1 = new Vehicle("4152 Al",TypeVehicle.car, true, false, door, motor, chassis, wheel, bodyWork);
            Console.WriteLine(coche1);
            Console.ReadLine();
        }
    }
}
