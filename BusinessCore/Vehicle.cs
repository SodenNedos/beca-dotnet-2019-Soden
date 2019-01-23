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
        private TypeVehicle typeVehicle;
        private Boolean combustionEngine;
        private Boolean electricEngine;
        private Object door;
        private Object motor;
        private Object chasis;
        private Object wheel;//ruedas
        private Object bodyWork;//Carrocería

        public Vehicle(string enrollment, TypeVehicle typeVehicle, bool combustionEngine, bool electricEngine, object door, object motor, object chasis, object wheel, object bodyWork)
        {
            this.enrollment = enrollment;
            this.typeVehicle = typeVehicle;
            this.combustionEngine = combustionEngine;
            this.electricEngine = electricEngine;
            this.door = door;
            this.motor = motor;
            this.chasis = chasis;
            this.wheel = wheel;
            this.bodyWork = bodyWork;
        }

        public override string ToString()
        {
            string text = "";
            text = "Hola soy el coche de matrícula; " + this.enrollment + " mi dueño es "+this.owner+"." ;
            return text;
        }
    }
    public enum TypeVehicle
    {
        bike, motorcycle, car, truck, trailer, airplane, ship
    }
}
