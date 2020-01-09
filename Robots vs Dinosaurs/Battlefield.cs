using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs_Dinosaurs
{
    class Battlefield
    {
        Herd dinosaurs;
        Fleet robots;

        public Battlefield()
        {
            dinosaurs = new Herd();
            robots = new Fleet();
        }
        public void RunSimulation() //master
        {
            Fleet fleet = new Fleet();
            Herd herd = new Herd();
            
            Console.WriteLine("You're on the robot team, and you'll be fighting the dinosaurs. Ready?");
            Console.ReadLine();

            while (fleet.fleetHP > 0 && herd.herdHP > 0)
            {
                herd.dinosaurs[0].Attack(fleet.robots[0]);
                herd.dinosaurs[1].Attack(fleet.robots[1]);
                herd.dinosaurs[2].Attack(fleet.robots[2]);
                fleet.robots[0].Attack(herd.dinosaurs[0]);
                fleet.robots[1].Attack(herd.dinosaurs[1]);
                fleet.robots[2].Attack(herd.dinosaurs[2]);

                foreach (Robot robot in fleet.robots)
                {
                    Console.WriteLine($"{robot.name} health is {robot.health}");
                }
                foreach (Dinosaur dinosaur in herd.dinosaurs)
                {
                    Console.WriteLine($"{dinosaur.type} health is {dinosaur.health}");
                }
                Console.ReadLine();

            }

            //have a loop to print off each side's stats after each turn
            Console.WriteLine("The Dinosaurs' total health is: " + herd.herdHP);
            Console.WriteLine("The Robots' total health is: " + fleet.fleetHP);
            Console.ReadLine();


            //last major step is to have the objects attack each other
            

            //JUST GET IT WORKING, THEN WORRY ABOUT THE FUN STUFF
        }
    }
}
