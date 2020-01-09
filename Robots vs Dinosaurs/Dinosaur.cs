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
        

        public Dinosaur(string type, double health, double energy, double attackPower)
        {
            this.type = type;
            this.health = health;
            this.energy = energy;
            this.attackPower = attackPower;
        }

        public void Attack(Robot robot)
        {
            if (energy >= 15)
            {
                energy -= 15;
                robot.health -= attackPower;
            }
        }

        //public void Rest()
        //{
        //    health += 15;
        //    energy += 15;
        //}


    }
}
