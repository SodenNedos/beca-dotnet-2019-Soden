using System;

namespace BusinessCore
{
    public class Door
    {
        private int number;
        private Boolean closingAutomatic;
        private Boolean electricWindow;

        public Door(int number, bool closingAutomatic, bool electricWindow)
        {
            this.number = number;
            this.closingAutomatic = closingAutomatic;
            this.electricWindow = electricWindow;
        }
    }
}
