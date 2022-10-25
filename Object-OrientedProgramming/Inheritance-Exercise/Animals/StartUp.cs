﻿using System;

namespace Animals
{
    public class StartUp
    {
        static void Main()
        {

            while (true)
            {
                Animals animals = default;
                string commands = Console.ReadLine();

                if (commands == "Beast!")
                {
                    break;
                }

                string typeOfAnimal = commands;
                string[] tokens = Console.ReadLine().Split();
                string nameOfAnimal = tokens[0];
                int ageOfAnimal = int.Parse(tokens[1]);

                if (ageOfAnimal < 0)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                if (typeOfAnimal == "Dog")
                {
                    animals = new Dog(nameOfAnimal, ageOfAnimal, tokens[2]);
                }
                else if (typeOfAnimal =="Frog")
                {
                    animals = new Frog(nameOfAnimal, ageOfAnimal, tokens[2]);
                }
                else if (typeOfAnimal == "Kitten")
                {
                    animals = new Kitten(nameOfAnimal, ageOfAnimal);
                }
                else if (typeOfAnimal == "Tomcat")
                {
                    animals = new Tomcat(nameOfAnimal, ageOfAnimal);
                }
                else
                {
                    animals = new Cat(nameOfAnimal, ageOfAnimal, tokens[2]);
                }
                
                Console.WriteLine(typeOfAnimal);
                Console.WriteLine($"{animals.Name} {animals.Age} {animals.Gender}");
                string sound = animals.ProduceSound();
                Console.WriteLine(sound);
            }
        }
    }
}
