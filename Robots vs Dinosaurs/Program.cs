using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs_Dinosaurs
{
    class Program
    {
        static void Main(string[] args)
        {
            Battlefield battle = new Battlefield();
            battle.RunSimulation();
        }
    }
}
