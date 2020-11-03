using System;
using System.Collections.Generic;
using System.Text;

namespace Space_Exploration
{
    class Space
    {
        public int numberOfPlanetsExist, numberOfStarsExist;
        public String spaceName;
        public string[] habitatList;
        public Planet[] planets;
        public Star[] stars;
        private const int PLANETSPACE = 1000, STARSPACE = 1000;


        public Space(String spaceName)
        {
            this.spaceName = spaceName;
            planets = new Planet[PLANETSPACE];
            stars = new Star[STARSPACE];
            habitatList = new string[] {"extreme cold and icy -80 degrees", "extremely hot and sunny 80+ degrees",
            "toxic atmosphere", "very similar to earth's atmosphere!"};
            numberOfPlanetsExist = 0;
            numberOfStarsExist = 0;
        }

        public string getSpaceName()
        {
            return spaceName;
        }

        public void setSpaceName(string spaceName)
        {
            this.spaceName = spaceName;
        }

        public bool trueOrFalseGenerator()
        {
            Random gen = new Random();
            int prob = gen.Next(2);
            if (prob == 1)
            {
                return true;
            }
            return false;
        }

        public int getPlanetSpace()
        {
            return PLANETSPACE;
        }

        public int getStarSpace()
        {
            return STARSPACE;
        }
        
        public void generateRandomPlanets()
        {
            Random random = new Random();
            StringBuilder str_build = new StringBuilder();
            char letter;

            for (int x = 0; x < planets.Length; x++)
            {
                double flt = random.NextDouble();
                int shift = Convert.ToInt32(Math.Floor(25 * flt));
                letter = Convert.ToChar(shift + 65);
                str_build.Append(letter);
                String planetNameInStrings = "s- " + str_build.ToString();
                Planet temp = new Planet(planetNameInStrings, (x * 20), habitatList[random.Next(4)]);
                planets[x] = temp;
                numberOfPlanetsExist++;
            }
        }

        public Planet findPlanet(string planetNameInStrings)
        {
            for(int x = 0; x < PLANETSPACE; x++)
            {
                if (planets[x].name == planetNameInStrings)
                {
                    return planets[x];
                }
            }
            return null;
        }

        public void generateRandomStars()
        {
            Random random = new Random();
            StringBuilder str_build = new StringBuilder();
            char letter;

            for (int x = 0; x < stars.Length; x++)
            {
                double flt = random.NextDouble();
                int shift = Convert.ToInt32(Math.Floor(25 * flt));
                letter = Convert.ToChar(shift + 65);
                str_build.Append(letter);
                String starNameInStrings = "s-" + str_build.ToString();
                Star temp = new Star(starNameInStrings, (x * 20));
                stars[x] = temp;
                numberOfStarsExist++;
            }
        }
    }
}
