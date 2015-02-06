/***********************************************************
 * Hyoim Shin (300802252)
 * February 5, 2015
 * Assignment2 : Implement SuperHero Class
 * Revision History : 
 * - Added new superhero object by using SuperHero class
 * ********************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Assignment2_HyoimShin
{
    class Program
    {
        static void Main(string[] args)
        {
            string consoleKey = "";

            Hero superman = new Hero("Superman");
            SuperHero superhero = new SuperHero("Super Hero");

            superman.show();                      // calls show method of Hero class
            superhero.showPowers();               // calls showPowers of SuperHero class


            while (consoleKey != "q")
            {
                switch (consoleKey)
                {
                    case "q":
                        break;
                    case "y":
                        // superman.fight();     //calls fight method
                        superhero.fight();
                        consoleKey = "";
                        break;
                    default:
                        consoleKey = checkKey(consoleKey);
                        break;
                }

            }

        }
        private static string checkKey(string consoleKey)
        {
            Console.Write("Press 'y' to attack the target or 'q' to exit : ");
            consoleKey = Console.ReadLine();
            Console.WriteLine();
            return consoleKey;
        }
    }
}
