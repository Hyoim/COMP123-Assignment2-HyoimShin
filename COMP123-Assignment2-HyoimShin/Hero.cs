/***********************************************
 * Hyoim Shin (300802252)
 * 30 January, 2015
 * Assignment1 : Implement Hero Class
 * Revision History : 
 * - Changed return type of hitDamage 
 * - Added comment and program header
 * ********************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Assignment2_HyoimShin
{
    class Hero
    {
        Random rnd = new Random();   // is used to generate random number

        // PUBLIC PROPERTIES +++++++++++++++++++++++++++++++++++++++++
        public string name;

        // PRIVATE PROPERTIES ++++++++++++++++++++++++++++++++++++++++
        protected int strength = 0;
        protected int speed = 0;
        protected int health = 0;

        // CONSTRUCTOR +++++++++++++++++++++++++++++++++++++++++++++++
        public Hero(string name)
        {
            this.name = name;
            generateAblities(rnd);
        }


        // PUBLIC METHODS ++++++++++++++++++++++++++++++++++++++++++++

        //calls the hitAttempt method that determines sucess or failure of attack
        public void fight()
        {
            bool hitResult;                  // success or failure for attack
            int damage, damageFact;          // is used to calculate damage

            hitResult = hitAttempt(rnd);     

            if (hitResult == true)
            {
                damageFact = hitDamage(rnd);    

                // damage = hero's strength * damageFact
                damage = this.strength * damageFact;

                Console.WriteLine("--------------------------------");
                Console.WriteLine("Attack succeeded");
                Console.WriteLine("The target is attacked by {0}", damage);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Attack failed");
                Console.WriteLine();
            }
        }

        //displays hero's ability score
        public void show()
        {
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine(String.Format("The ability of {0}", this.name).PadLeft(42 - (14 - (this.name.Length / 2))));
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++");

            Console.WriteLine("{0, 22} {1, -20}", "Strength:", this.strength);
            Console.WriteLine("{0, 22} {1, -20}", "Speed:", this.speed);
            Console.WriteLine("{0, 22} {1, -20}", "Health:", this.health);
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine();
        }


        // PRIVATE METHODS +++++++++++++++++++++++++++++++++++++++++++

        // generates the ability numbers for the strength, speed, health 
        private void generateAblities(Random rnd)
        {
            // Random class is used for making random hero's ability between 1 to 100 
            this.strength = rnd.Next(1, 101);
            this.speed = rnd.Next(1, 101);
            this.health = rnd.Next(1, 101);
        }

        //determines sucess or failure of hero's attack 
        private bool hitAttempt(Random rnd)
        {
            // Random class is used for determining success or failure for attack
            // Hero hits would succeed 20% of the time

            int hitAttempt = rnd.Next(1, 11);
            Console.Write("{0} is attempting attack", this.name);
            Console.WriteLine();

            if ((hitAttempt == 1) || (hitAttempt == 2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //calculates the damage the Hero causes to the target on a hit
        private int hitDamage(Random rnd)
        {
            // Random class is used for generating hit factor
            // the factor between 1 and 6 is used to calculate the hit damage

            int hitDamageFact = rnd.Next(1, 7);
            return hitDamageFact;
        }
    }
}
