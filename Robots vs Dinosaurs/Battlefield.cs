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
            Robot optimusPrime;
            
            Console.WriteLine("You're on the robot team, and you'll be fighting the dinosaurs. Ready?");
            Console.ReadLine();

            if (fleet.fleetHP <= 0)
            {
                Console.WriteLine("Game is over!");
            }
            else if (herd.herdHP <= 0)
            {
                Console.WriteLine("Game is over!");
            }

            //have a loop to print off each side's stats after each turn
            Console.WriteLine("The Dinosaurs' total health is: " + herd.herdHP);
            Console.WriteLine("The Robots' total health is: " + fleet.fleetHP);

            foreach (Robot robot in fleet.robots)
            {
                Console.WriteLine($"{robot.name} health is {robot.health}");
            }
            foreach (Dinosaur dinosaur in herd.dinosaurs)
            {
                Console.WriteLine($"{dinosaur.type} health is {dinosaur.health}");
            }


            //JUST GET IT WORKING, THEN WORRY ABOUT THE FUN STUFF
            //should I write an automated system to pick up the other side? So I can allow the user to choose which side.
        }
    }
}
