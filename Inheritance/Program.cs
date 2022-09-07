using System;
using System.Collections.Generic;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Create an object of your Bird class
              *  give values to your members using the object of your Bird class
              *  
              * Creatively display the class member values 
              */
            var MyBird = new Bird();

            MyBird.Name = "Stan";
            MyBird.Age = 4;
            MyBird.NumberOfLegs = 2;
            MyBird.IsAlive = true;
            MyBird.Type = "Parakeet";
            MyBird.DoesItFly = false;
            MyBird.Color = "Blue";
            MyBird.DoesItMigrate = false;

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            var MySnake = new Reptile();
            MySnake.Name = "Salazar";
            MySnake.Age = 2;
            MySnake.NumberOfLegs = 0;
            MySnake.IsAlive = true;
            MySnake.DoesItHaveScales = true;
            MySnake.WhatIsItsHabitat = "Aquarium Home";
            MySnake.DoesItSwim = false;
            MySnake.IsItColdBlooded = true;

            var myBird = new Bird[] {MyBird};
            var myReptile = new Reptile[] {MySnake};

            foreach (var bird in myBird)
            {
                Console.WriteLine($"Name: {bird.Name}");
                Console.WriteLine($"Age: {bird.Age}");
                Console.WriteLine($"Number of legs: {bird.NumberOfLegs}");
                Console.WriteLine($"Is it alive: {bird.IsAlive}");
                Console.WriteLine($"Type: {bird.Type}");
                Console.WriteLine($"Can it fly: {bird.DoesItFly}");
                Console.WriteLine($"Color: {bird.Color}");
                Console.WriteLine($"Does it migrate for winter: {bird.DoesItMigrate}");
                Console.WriteLine($"");
            }
            foreach (var reptile in myReptile)
            {
                Console.WriteLine($"Name: {reptile.Name}");
                Console.WriteLine($"Age: {reptile.Age}");
                Console.WriteLine($"Number of Legs: {reptile.NumberOfLegs}");
                Console.WriteLine($"Is it Alive: {reptile.IsAlive}");
                Console.WriteLine($"Does it have scales: {reptile.DoesItHaveScales}");
                Console.WriteLine($"What is its habitat: {reptile.WhatIsItsHabitat}");
                Console.WriteLine($"Can it swim: {reptile.DoesItSwim}");
                Console.WriteLine($"Is it cold blooded: {reptile.IsItColdBlooded}");
                Console.WriteLine($"");
            }
        }
    }
}
