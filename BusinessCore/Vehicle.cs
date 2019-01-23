using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessCore
{
    public class Vehicle
    {
        private String owner = "Soden";
        private String enrollment;
        private VehicleType typeVehicle;
        private Boolean combustionEngine;
        private Boolean electricEngine;
        private Door[] doors;
        private Engine motor;
        private Chassis chassis;
        private Wheel[] wheels;//ruedas
        private BodyWork bodyWork;//Carrocería

        public Vehicle(string enrollment, VehicleType typeVehicle,
            bool combustionEngine, bool electricEngine, Door[] doors,
            Engine motor, Chassis chasis, Wheel[] wheels,  BodyWork bodyWork)
        {
            this.enrollment = enrollment;
            this.typeVehicle = typeVehicle;
            this.combustionEngine = combustionEngine;
            this.electricEngine = electricEngine;
            this.doors = doors;
            this.motor = motor;
            this.chassis = chasis;
            this.wheels = wheels;
            this.bodyWork = bodyWork;
        }

        public override string ToString()
        {
            string text = "";
            text = "Hola soy el coche con matrícula; " +this.enrollment + 
                " mi dueño es "+this.owner+"." ;
            return text;
        }
    }
}
