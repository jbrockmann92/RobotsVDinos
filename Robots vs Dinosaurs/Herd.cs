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
        Random rnd = new Random();

        public Herd()
        {
            int rexHealth = rnd.Next(40, 56);
            int rexPower = rnd.Next(55, 71);
            int triHealth = rnd.Next(100, 166);
            int triPower = rnd.Next(25, 31);
            int brachHealth = rnd.Next(90, 111);
            int brachPower = rnd.Next(30, 41);
            dinosaurs = new List<Dinosaur>() { new Dinosaur("0) T-Rex", rexHealth, 50, rexPower), new Dinosaur("1) Triceratops", triHealth, 30, triPower), new Dinosaur("2) Brachiosaurus", brachHealth, 30, brachPower) };
            herdHP = dinosaurs[0].health + dinosaurs[1].health + dinosaurs[2].health;
        }
        public void CalcHerdHp()
        {
            herdHP = dinosaurs[0].health + dinosaurs[1].health + dinosaurs[2].health;
        }
    }
}
