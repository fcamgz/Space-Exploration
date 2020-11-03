using System;
using System.Collections.Generic;
using System.Text;

namespace Space_Exploration
{
    class HomeTelescope : Telescope
    {
        private string name = "Home Telescope (Default)";
        private int range = 500;

        public override string getInfo()
        {
            string s = name + " has range of " + range + " light years";
            return s;
        }
    }
}
