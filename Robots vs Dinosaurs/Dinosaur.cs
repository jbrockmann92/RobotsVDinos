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

        //public void PickUpWeapon()
        //{

        //    Console.WriteLine("What weapon would you like to use?");
        //    foreach (Weapon weapon in weapons)
        //    {
        //        Console.WriteLine(weapon.weaponName);
        //    }
        //    weaponChoice = int.Parse(Console.ReadLine());
        //}

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
                }
            }
        }

        
        //public void Rest()
        //{
        //    health += 15;
        //    energy += 15;
        //}


    }
}
