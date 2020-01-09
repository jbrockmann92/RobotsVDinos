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
        Weapon weapon;
        public Dinosaur dinosaur;
        List<Weapon> weapons = new List<Weapon>();
        Weapon gun;
        Weapon knife;
        Weapon mace;

        public Robot(string name, double power, double health)
        {
            this.name = name;
            this.power = power;
            this.health = health;

            PickUpWeapon();
        }

        public void PickUpWeapon()
        {
            gun = new Weapon(10);
            knife = new Weapon(5);
            mace = new Weapon(15);

            if (name == "Optimus Prime")
            {
                weapons.Add(gun);
            }
            if (name == "Wall-e")
            {
                weapons.Add(knife);
            }
            if (name == "BayMax")
            {
                weapons.Add(mace);
            }
        }

        public void Attack(Dinosaur dinosaur)
        {
            if (power < 15)
            {
                Console.WriteLine("Sorry, your attack power is not high enough. You'll need to recharge before you can attack again");
                Console.ReadLine();
            }
            else
            {
                power -= 15;
                // don't let this go negative
            }
            dinosaur.health -= weapon.damage;
        }

        public void Recharge()
        {
            health += 15;
            power += 15;
        }
    }
}
