using System;
using System.Collections.Generic;
using System.Text;

namespace Space_Exploration
{
    class ObserverTelescope : Telescope
    {
        private string name = "Observer Telescope";
        private int range = 2500;

        public override string getInfo()
        {
            string s = name + " has range of " + range + " light years";
            return s;
        }
    }
}
