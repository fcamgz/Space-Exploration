using System;
using System.Collections.Generic;
using System.Text;

namespace Space_Exploration
{
    class HubbleTelescope : Telescope
    {
        private string name = "Hubble Telescope";
        private int range = 5000;

        public override string getInfo()
        {
            string s = name + " has range of " + range + " light years";
            return s;
        }
    }
}
