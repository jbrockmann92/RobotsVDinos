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

        public Fleet()
        {
            robots = new List<Robot>() { new Robot("Optimus Prime", 60, 75), new Robot("Wall-e", 30, 100), new Robot("BayMax", 100, 100) };

            fleetHP = robots[0].health + robots[1].health + robots[2].health;
        }

    }
}
