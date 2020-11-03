using System;
using System.Collections.Generic;
using System.Text;

namespace Space_Exploration
{
    class Astronaut
    {
        private string name, nationality;

        public Astronaut(string name, string nationality)
        {
            this.name = name;
            this.nationality = nationality;
        }

        public string getInfo()
        {
            string s = "Astronaut " + name + " from " + nationality;
            return s;
        }
    }
}
