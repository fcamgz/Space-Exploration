using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Space_Exploration
{
    class User
    {
        private int points;
        private string name;
        private bool astronaut, spaceship;
        private Telescope telescope;
        private Planet[] exploredPlanetsList;
        private Star[] exploredStarsList;
        private int numOfExploredStars;
        private int numOfExploredPlanets;


        public User()
        {
            telescope = new HomeTelescope();
            astronaut = false;
            spaceship = false;
            points = 1000;
            numOfExploredPlanets = 0;
            numOfExploredStars = 0;
        }

        public Telescope getTelescope()
        {
            return telescope;
        }

        public void setTelescope(int number)
        {
            switch (number)
            {
                case 1:
                    telescope = new AdvancedHomeTelescope();
                    break;
                case 2:
                    telescope = new ObserverTelescope();
                    break;
                case 3:
                    telescope = new HubbleTelescope();
                    break;
                case 4:
                    telescope = new JamesWebbTelescope();
                    break;
            }
        }

        public bool getAstronaut()
        {
            return astronaut;
        }

        public void assignAstronaut()
        {
            astronaut = true;
        }

        public bool getSpaceship()
        {
            return spaceship;
        }

        public void assignSpaceship()
        {
            spaceship = true;
        }


        public string getName()
        {
            return name;
        }
        
        public void setName(string name)
        {
            this.name = name;
        }

        public int getPoints()
        {
            return points;
        }

        public void setPoints(int points)
        {
            this.points = points;
        }

        public void addPoints(int points)
        {
            this.points += points; 
        }

        public void showAllExploredStars(Space space)
        {
            for(int x = 0; x < numOfExploredStars; x++)
            {
                space.stars[x].getInfo();
            }
        }

        public void showAllExploredPlanets(Space space)
        {
            for(int x = 0; x < numOfExploredPlanets; x++)
            {
                space.planets[x].getInfo();
            }
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

        public string findPlanetsInListByName(string name)
        {
            string s = "";
            for(int x = 0; x < numOfExploredPlanets; x++)
            {
                if(exploredPlanetsList[x].getName() == name)
                {
                    s = "Planet is already in the found planets list!";
                    return s;
                }
            }
            s = "Planet is not in the found planets list";
            return s;
        }

        public string findStarsInListByName(string name)
        {
            string s = "";
            for(int x = 0; x < numOfExploredStars; x++)
            {
                if(exploredStarsList[x].getName() == name)
                {
                    s = "Star is already in the found stars list!";
                    return s;
                }
            }
            s = "Star is not in the found stars list";
            return s;
        }

        public void useTelescope(Space space, Telescope telescope)
        {
            points -= 10;
            Random random = new Random();

            for (int x = random.Next(telescope.range); x < space.getPlanetSpace();)
            {
                bool result = trueOrFalseGenerator();
                if(result == true)
                {
                    bool secondResult = trueOrFalseGenerator();
                    if(secondResult == true)
                    {
                        if(space.planets[x].getName() == findPlanetsInListByName(space.planets[x].getName()))
                        {
                            Console.WriteLine("Planet is already in the list! -10 points");
                        }
                        else
                        {
                            exploredPlanetsList[numOfExploredPlanets] = space.planets[x];
                            numOfExploredPlanets++;
                            Console.WriteLine($"Congrats planet {space.planets[x].getInfo()} found and added in the list you earned 20 points!");
                        }
                    }
                    else
                    {
                        if(space.stars[x].getName() == findStarsInListByName(space.stars[x].getName()))
                        {
                            Console.WriteLine("Star is already in the list! -10 points");
                        }
                        else 
                        { 
                        exploredStarsList[numOfExploredStars] = space.stars[x];
                        numOfExploredStars++;
                        Console.WriteLine($"Congrats star {space.stars[x].getInfo()} found and added in the list you earned 10 points!");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("You spent all night looking at sky but nothing been seen try again  -10 points");
                }
            }
        }
    }
}
