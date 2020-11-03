using System;
using System.Collections.Generic;
using System.Text;

namespace Space_Exploration
{
    class JamesWebbTelescope : Telescope
    {
        private string name = "James Webb Telescope";
        private int range = 10000;

        public override string getInfo()
        {
            string s = name + " has range of " + range + " light years";
            return s;
        }
    }
}
