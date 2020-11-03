using System;
using System.Collections.Generic;
using System.Text;

namespace Space_Exploration
{
    class Star
    {
        public string name;
        public int distance;
        
        public Star(string name, int distance)
        {
            this.name = name;
            this.distance = distance;
        }

        public string getName()
        {
            return name;
        }

        public string getInfo()
        {
            string s = name + "," + distance;
            return s;
        }
    }
}
