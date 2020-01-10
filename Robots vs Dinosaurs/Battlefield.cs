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
                Console.WriteLine("Which dinosaur would you like to attack?");
                int attackChoice = int.Parse(Console.ReadLine());
                Console.WriteLine("Which robot would you like to attack with?");
                int attackerChoice = int.Parse(Console.ReadLine());
                fleet.robots[attackerChoice].Attack(herd.dinosaurs[attackChoice]);
                Console.WriteLine("You successfully hit " + $"{herd.dinosaurs[attackChoice].type} with {fleet.robots[attackerChoice].name}");
                //why doesn't this one work? I should be able to put herd.dinosaurs.type or fleet.robots.name

                herd.dinosaurs[attackerChoice].Attack(fleet.robots[attackChoice]);
                    //doesn't exactly work, but fine temporarily

                foreach (Robot robot in fleet.robots)
                {
                    Console.WriteLine($"{robot.name} health is {robot.health}");
                }
                foreach (Dinosaur dinosaur in herd.dinosaurs)
                {
                    Console.WriteLine($"{dinosaur.type} health is {dinosaur.health}");
                }
                herd.CalcHerdHp();
                Console.ReadLine();
            }

            Console.WriteLine("The Dinosaurs' total health is: " + herd.herdHP);
            Console.WriteLine("The Robots' total health is: " + fleet.fleetHP);
            Console.WriteLine("The battle is over!");
            Console.ReadLine();
        }
    }
}
