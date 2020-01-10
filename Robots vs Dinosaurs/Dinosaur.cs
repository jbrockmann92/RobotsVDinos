using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs_Dinosaurs
{
    class Dinosaur
    {
        public string type;
        public double health;
        double energy;
        public double attackPower;
        Random rnd = new Random();
        

        public Dinosaur(string type, double health, double energy, double attackPower)
        {
            this.type = type;
            this.health = health;
            this.energy = energy;
            this.attackPower = attackPower;
        }

        public void Attack(Robot robot)
        {
            if (robot.health > 0)
            {
                int randomAttack = rnd.Next(1, 11);
                if (randomAttack == 5)
                {
                    Console.WriteLine("Your opponent's attack missed!");
                }
                else
                {
                    robot.health -= attackPower;
                }
            }
            else
            {
                Console.WriteLine("Sorry, that opponent is already dead");
            }
        }

        
        //public void Rest()
        //{
        //    health += 15;
        //    energy += 15;
        //}


    }
}
