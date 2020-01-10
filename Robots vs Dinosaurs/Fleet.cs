using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs_Dinosaurs
{
    class Fleet
    {
        public List<Robot> robots;
        public double fleetHP;
        Random rnd = new Random();

        public Fleet()
        {
            int optimusPower = rnd.Next(20, 31);
            int optimusHealth = rnd.Next(70, 96);
            int wallePower = rnd.Next(15, 31);
            int walleHealth = rnd.Next(110, 146);
            int baymaxPower = rnd.Next(15, 51);
            int baymaxHealth = rnd.Next(70, 151);
            robots = new List<Robot>() { new Robot("0) Optimus Prime", optimusPower, optimusHealth), new Robot("1) Wall-e", wallePower, walleHealth), new Robot("2) BayMax", baymaxPower, baymaxHealth) };

            //currently means that one could have some health and the game would still end. Fix later
            fleetHP = robots[0].health + robots[1].health + robots[2].health;
        }
        public void CalcFleetHp()
        {
            fleetHP = robots[0].health + robots[1].health + robots[2].health;
        }

    }
}
