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
            robots = new List<Robot>() { new Robot("0) Optimus Prime", 60, 75), new Robot("1) Wall-e", 30, 100), new Robot("2) BayMax", 100, 100) };

            fleetHP = robots[0].health + robots[1].health + robots[2].health;
        }

    }
}
