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
        int randomAttack;
        int[] attacks = new int[3] { 15, 20, 25 };

        public Dinosaur(string type, double health, double energy, double attackPower)
        {
            this.type = type;
            this.health = health;
            this.energy = energy;
            this.attackPower = attackPower;
        }

        public void ChooseAttack()
        {
            int attackChoice = rnd.Next(0, 3);
            randomAttack = attackChoice;
        }

        public void Attack(Robot robot)
        {
            ChooseAttack();

            if (robot.health > 0)
            {
                int hitOrMiss = rnd.Next(1, 11);
                if (hitOrMiss == 5)
                {
                    Console.WriteLine("Your opponent's attack missed!");
                }
                else
                {
                    robot.health -= attacks[randomAttack];
                    if (robot.health < 0)
                    {
                        robot.health = 0;
                    }
                }

            }
            else
            {
                Console.WriteLine("Your attack missed!");
            }
        }
    }
}
