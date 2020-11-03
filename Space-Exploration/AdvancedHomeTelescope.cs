using System;
using System.Collections.Generic;
using System.Text;

namespace Space_Exploration
{
    class AdvancedHomeTelescope : Telescope
    {
        private string name = "Advanced Home Telescope";
        private int range = 1000;

        public override string getInfo()
        {
            string s = name + " has range of " + range + " light years";
            return s;
        }
    }
}
