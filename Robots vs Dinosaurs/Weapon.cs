using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs_Dinosaurs
{
    class Weapon
    {
        public double damage;
        public string weaponName;

        public Weapon(double damage, string weaponName)
        {
            this.damage = damage;
            this.weaponName = weaponName;
        }

    }
}
