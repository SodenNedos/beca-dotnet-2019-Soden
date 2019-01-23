using System;

namespace BusinessCore
{
    public class Wheel
    {
        private String brand;//marca
        private double width;//anchura
        private double height;//altura
        private double diameter;//diametro

        public Wheel( string brand, double width, double height, double diameter)
        {
            this.brand = brand;
            this.width = width;
            this.height = height;
            this.diameter = diameter;
        }
    }
}
