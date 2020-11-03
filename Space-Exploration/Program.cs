using System;
using System.Security.Cryptography.X509Certificates;

namespace Space_Exploration
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Space Exploration Game!");
            Console.WriteLine("Please enter your name: ");
            String userName = Console.ReadLine();
            User user = new User();
            user.setName(userName);
            Space space = new Space("");
            Console.WriteLine("Enter the space name you'd like to create ");
            string userSpaceName = Console.ReadLine();
            space.setSpaceName(userSpaceName);

        }
    }

}


