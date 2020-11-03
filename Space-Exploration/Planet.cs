using System;
using System.Collections.Generic;
using System.Text;

namespace Space_Exploration
{
    class Planet
    {
        public string name;
        public int distance;
        private bool alienLife, oxygen, suitableForHumans, hasWater;
        private string habitat;
        public string[] habitatList = new string[] {"extreme cold and icy -80 degrees", "extremely hot and sunny 80+ degrees",
            "toxic atmosphere", "very similar to earth's atmosphere!"};
        Random random = new Random();


        public Planet(string name, int distance)
        {
            this.name = name;
            this.distance = distance;
            habitat = habitatList[random.Next(4)];
            suitableForHumans = false;
        }


        public Planet(string name, int distance, string habitat)
        {
            this.name = name;
            this.distance = distance;
            this.habitat = habitat;
            suitableForHumans = false;
        }

        public string getName()
        {
            return name;
        }


        public string getAlienLife()
        {
            string s = "";
            if(alienLife == true)
            {
                s = "alien life exits";
                return s;
            }
            s = "alien life existence is unknown/don't have any aliens";
            return s;
        }

        public void setAlienLife(bool alienLife)
        {
            this.alienLife = alienLife;
        }

        public string getHabitat()
        {
            return habitat;
        }
        public void setHabitat(string habitat)
        {
            this.habitat = habitat;
        }
        public string getOxygen()
        {
            string s = "";
            if(oxygen == true)
            {
                s = "has oxygen";
                return s;
            }
            s = "oxygen availability is unknown/doesn't have";
            return s;
        }
        public void setOxygen(bool oxygen)
        {
            this.oxygen = oxygen;
        }

        public bool getSuitableForHumans()
        {
            if(oxygen == true && habitat == "very similar to earth's atmosphere!" && alienLife == false)
            {
                return true;
            }
            return false;
        }

        public void setSuitableForHumans(bool suitableForHumans)
        {
            this.suitableForHumans = suitableForHumans;
        }

        public string getHasWater()
        {
            string s = "";
            if(hasWater == true)
            {
                s = "has water";
                return s;
            }
            s = "water availability is unknown/doesn't have water";
            return s;
           
        }
        public void setHasWater(bool hasWater)
        {
            this.hasWater = hasWater;

        }
        public string getInfo()
        {
            string s = name + "," + distance + " lightyears away, habitat is " + habitat;
            return s;
        }
    }
}
