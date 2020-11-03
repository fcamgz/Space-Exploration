using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace Space_Exploration
{
    class Menu
    {
        public void showOptionMenu(User user, Space space, Telescope telescope, Spaceship spaceship, Astronaut astronaut) {

            Console.WriteLine($"Welcome {user.getName()} we need your help" +
$" we are on year 2356 pollution got out of control and world population is" +
$" increasing dramatically everyday that's why we need to find a different planet" +
$" to maintain our race! You have {user.getPoints()} your goal is the find an another planet" +
$" without any alien life that has oxygen and water with Earth like habitat.");
            Console.WriteLine("You search for the planet by looking at the space with your telescope");
            Console.WriteLine("Each time you use your telescope you spend 10 points and if you are out of points you lose!");
            Console.WriteLine("You can upgrade your telescope by using your points and find further distance planets with your new telescope");
            Console.WriteLine("You can only learn about the name, distance and habitat about the planet by using telescope");
            Console.WriteLine("In order to learn more about the planet you need to go to that planet");
            Console.WriteLine("To do that you need to hire an Astronaut for 500 points and build a Spaceship for 1000 points");
            Console.WriteLine("On your way to research the planet your crew's spaceship might explode during takeoff or might even hit an asteroid!");
            Console.WriteLine("Or your astronauts might lost in the space and never comeback!");
            Console.WriteLine("Finding planets 20 points");
            Console.WriteLine("Finding stars 10 points");
            Console.WriteLine($"Good luck on your new planet search! {user.getName()}");

            Console.WriteLine("1 - Search planets by telescope");
            Console.WriteLine("2 - Show Points");
            Console.WriteLine("3 - Show Telescope");
            Console.WriteLine("4 - Show Astronaut");
            Console.WriteLine("5 - Show Spaceship");
            Console.WriteLine("6 - Time to explore more!");
            Console.WriteLine("7 - Show all the explored Planets!");
            Console.WriteLine("8 - Show all the explored Stars!");
            Console.WriteLine("9 - Exit");
            int userInput = Convert.ToInt32(Console.ReadLine());
                if (userInput <= 9 && userInput >= 1)
                {
                switch (userInput)
                {
                    case 1:
                        user.useTelescope(space, telescope);
                        break;
                    case 2:
                        Console.WriteLine(user.getName() + " has " + user.getPoints() + " points");
                        break;
                    case 3:
                        Console.WriteLine("Telescope that you have is " + user.getTelescope().getInfo());
                        break;
                    case 4:
                        if (user.getAstronaut())
                        {
                            Console.WriteLine(astronaut.getInfo());
                            break;
                        }
                        Console.WriteLine("You didn't hire an astronaut yet!");
                        break;

                    case 5:
                        if(user.getSpaceship())
                        {
                            Console.WriteLine(spaceship.getInfo());
                            break;
                        }
                        Console.WriteLine("You didn't buy a spaceship yet!");
                        break;

                    case 6:
                        Console.WriteLine("1- Buy new Telescope");
                        Console.WriteLine("2- Build a SpaceShip (1000 points)");
                        Console.WriteLine("3 - Hire an Astronaut (500 points)");
                        int userInputFirstCase = Convert.ToInt32(Console.ReadLine());
                        switch (userInputFirstCase)
                        {
                            case 1:
                                Console.WriteLine("Telescopes:");
                                Console.WriteLine("1 - * Advanced Home Telescope * 250 points");
                                Console.WriteLine("2 - * Observer Telescope * 500 points");
                                Console.WriteLine("3 - * Hubble Telescope * 750 points");
                                Console.WriteLine("4 - * James Webb Telescope * 1000 points");
                                int userInputSecondCase = Convert.ToInt32(Console.ReadLine());
                                switch (userInputSecondCase)
                                {
                                    case 1:
                                        if (user.getPoints() > 250)
                                        {
                                            user.setTelescope(1);
                                            user.setPoints(user.getPoints() - 250);
                                            Console.WriteLine("Nice telescope -250 points range increased by 2x " + telescope.getInfo());
                                        }
                                        Console.WriteLine("You don't have enough points! You have " + user.getPoints());
                                        break;
                                    case 2:
                                        if (user.getPoints() > 500)
                                        {
                                            user.setTelescope(2);
                                            user.setPoints(user.getPoints() - 500);
                                            Console.WriteLine("Hmm you starting to like observing huh -500 points range increased by 2x " + telescope.getInfo());
                                        }
                                        Console.WriteLine("You don't have enough points! You have " + user.getPoints());
                                        break;
                                    case 3:
                                        if (user.getPoints() > 750)
                                        {
                                            user.setTelescope(3);
                                            user.setPoints(user.getPoints() - 750);
                                            Console.WriteLine("Whoa we are getting serious -750 points range increased by 2x " + telescope.getInfo());
                                        }
                                        Console.WriteLine("You don't have enough points! You have " + user.getPoints());
                                        break;
                                    case 4:
                                        if (user.getPoints() > 1000)
                                        {
                                            user.setTelescope(4);
                                            user.setPoints(user.getPoints() - 1000);
                                            Console.WriteLine("Mind Blown! -1000 points range increased by 2x now you are able to see all the stars and planets" + telescope.getInfo());
                                        }
                                        Console.WriteLine("You don't have enough points! You have " + user.getPoints());
                                        break;
                                }
                                break;

                            case 2:
                                if (user.getPoints() > 1000)
                                {
                                    user.assignSpaceship();
                                    user.setPoints(user.getPoints() - 1000);
                                    user.assignSpaceship();
                                    Console.WriteLine("Name your Spaceship: ");
                                    string spaceShipName = Console.ReadLine();
                                    Console.WriteLine("Give it a color");
                                    string spaceShipColor = Console.ReadLine();
                                    spaceship = new Spaceship(spaceShipName,spaceShipColor);
                                    Console.WriteLine("Since we have a spaceship now SKY IS THE LIMIT " + spaceship.getInfo());
                                }
                                break;
                            case 3:
                                if (user.getPoints() > 500)
                                {
                                    user.assignAstronaut();
                                    user.setPoints(user.getPoints() - 500);
                                    user.assignAstronaut();
                                    Console.WriteLine("Name the Astronaut");
                                    string astronautName = Console.ReadLine();
                                    Console.WriteLine("Nationality?");
                                    string astronautNationality = Console.ReadLine();
                                    astronaut = new Astronaut(astronautName, astronautNationality);
                                    Console.WriteLine("Awesome now we hired an astronaut! " + astronaut.getInfo());
                                }
                                break;
                        }
                        break;

                    case 7:
                        user.showAllExploredPlanets(space);
                        break;
                    case 8:
                        user.showAllExploredStars(space);
                        break;
                    case 9:
                        Console.WriteLine("Exiting from the game see you next time!");
                        break;

                }
            }
            else
            {
                Console.WriteLine("Please enter a number between 1-5");
            }
        }   
    }
}