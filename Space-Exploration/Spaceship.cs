using System;
using System.Collections.Generic;
using System.Text;

namespace Space_Exploration
{
    class Spaceship
    {
        private string name,color;


        public Spaceship(string name, string color)
        {
            this.name = name;
            this.color = color;
        }

        public string getInfo()
        {
            string s = color + " color spaceship named " + name;
            return s;
        }
    }
}
