using System;

namespace BusinessCore
{
    public class Wheel
    {
        private int number;
        private String brand;//marca
        private double width;//anchura
        private double height;//altura
        private double diameter;//diametro

        public Wheel(int number, string brand, double width, double height, double diameter)
        {
            this.number = number;
            this.brand = brand;
            this.width = width;
            this.height = height;
            this.diameter = diameter;
        }
    }
}
