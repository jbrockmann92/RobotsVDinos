﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs_Dinosaurs
{
    class Battlefield
    {
        Herd dinoHerd;
        Fleet robotFleet;

        public Battlefield()
        {
            dinoHerd = new Herd();
            robotFleet = new Fleet();
        }
        public void RunSimulation() //master
        {
            Fleet fleet = new Fleet();
            Herd herd = new Herd();
            
            Console.WriteLine("You're on the robot team, and you'll be fighting the dinosaurs. Ready?");
            string readyOrNot = Console.ReadLine();
            if (readyOrNot == "No")
            {
                Console.WriteLine("Too bad. We're going to play anyway");
            }

            while (fleet.fleetHP > 0 && herd.herdHP > 0)
            {
                Console.WriteLine("Which dinosaur would you like to attack?");
                foreach (Dinosaur dinosaur in dinoHerd.dinosaurs)
                {
                    Console.WriteLine(dinosaur.type);
                }
                int attackChoice = int.Parse(Console.ReadLine());

                Console.WriteLine("Which robot would you like to attack with?");
                foreach (Robot robot in robotFleet.robots)
                {
                    Console.WriteLine(robot.name);
                }

                int attackerChoice = int.Parse(Console.ReadLine());

                fleet.robots[attackerChoice].Attack(herd.dinosaurs[attackChoice]);
                //how can I get this to not print if the character is dead? Already set in the robot and dinosaur classes, but runs here
                Console.WriteLine($"You successfully hit {herd.dinosaurs[attackChoice].type} with {fleet.robots[attackerChoice].name}");

                
                //need to write something for the dinos to attack the robots in return. Use Random rnd = new Random();
                Random rnd = new Random();
                int randomAttack = rnd.Next(0, 3);
                int randomVictim = rnd.Next(0, 3);

                herd.dinosaurs[randomAttack].Attack(fleet.robots[randomVictim]);

                //create special attacks for the dinosaurs to hit the robots with. Maybe a 1/10 chance of hitting with a power attack or something

                Console.WriteLine(" ");
                Console.WriteLine($"{herd.dinosaurs[randomAttack].type} successfully hit {fleet.robots[randomVictim].name} for {herd.dinosaurs[randomAttack].attackPower} damage!");
                Console.WriteLine(" ");

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
