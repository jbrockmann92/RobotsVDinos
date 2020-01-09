using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs_Dinosaurs
{
    class Herd
    {
        public List<Dinosaur> dinosaurs;
        public double herdHP;

        public Herd()
        {
            dinosaurs = new List<Dinosaur>() { new Dinosaur("T-Rex", 50, 50, 10), new Dinosaur("Triceratops", 90, 30, 15), new Dinosaur("Brachiosaurus", 110, 30, 5) };

            herdHP = dinosaurs[0].health + dinosaurs[1].health + dinosaurs[2].health;
        }
    }
}
