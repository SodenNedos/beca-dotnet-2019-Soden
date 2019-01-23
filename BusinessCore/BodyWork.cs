using System;

namespace BusinessCore
{
    public class BodyWork
    {
        private String color;
        private Boolean mate;
        private Boolean brightness;
        private string material;

        public BodyWork(bool mate, bool brightness, string materialBodyWork, string color)
        {
            this.mate = mate;
            this.brightness = brightness;
            this.material = materialBodyWork;
            this.color = color;
        }
    }
}
