using System;

namespace BusinessCore
{
    public class Door
    {
        private Boolean closingAutomatic;
        private Boolean electricWindow;

        public Door( bool closingAutomatic, bool electricWindow)
        {
            this.closingAutomatic = closingAutomatic;
            this.electricWindow = electricWindow;
        }
    }
}
