using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs_Dinosaurs
{
    class Robot
    {
        public double health;
        double power;
        public string name;
        public Dinosaur dinosaur;
        public List<Weapon> weapons = new List<Weapon>();
        Weapon gun;
        Weapon knife;
        Weapon mace;
        int weaponChoice;
        Random rnd = new Random();


        public Robot(string name, double power, double health)
        {
            this.name = name;
            this.power = power;
            this.health = health;

            gun = new Weapon(50, "0) Gun");
            knife = new Weapon(25, "1) Knife");
            mace = new Weapon(75, "2) Mace");

            weapons.Add(gun);
            weapons.Add(knife);
            weapons.Add(mace);
        }

        //I don't think I want to pick up a weapon here. I think I want to do it either in the fleet or battlefield class

        public void PickUpWeapon()
        {

            Console.WriteLine("What weapon would you like to use?");
            foreach (Weapon weapon in weapons)
            {
                Console.WriteLine(weapon.weaponName);
            }
            weaponChoice = int.Parse(Console.ReadLine());
        }

        public void Attack(Dinosaur dinosaur)
        {
            PickUpWeapon();
            int randomRobotAttack = rnd.Next(1, 11);

            if (randomRobotAttack != 5)
            {
                if (dinosaur.health > 0)
                {
                    dinosaur.health -= weapons[weaponChoice].damage;
                }
                else
                {
                    Console.WriteLine("Sorry, that opponent is already dead");
                }
            }
            else
            {
                Console.WriteLine("Your attack missed!");
            }
        }

        //public void Recharge()
        //{
        //    health += 15;
        //    power += 15;
        //}
    }
}
