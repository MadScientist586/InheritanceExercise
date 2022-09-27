using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            Bird bird1 = new Bird();
            bird1.Species = "bird";
            bird1.CanFly = "No";
            bird1.Age = 10;
            bird1.TypeOfFeathers = "long, neat, and beautiful";
            bird1.BirdType = "peacock";
            bird1.NumberOfLegs = 2;
            bird1.Size = "large";
            bird1.Habitat = "tropical forest";
            Console.WriteLine($"The species of the animal is {bird1.Species}.");
            Console.WriteLine($"Can the bird fly? {bird1.CanFly}.");
            Console.WriteLine($"The age of the bird is {bird1.Age} years old.");
            Console.WriteLine($"The type of feathers are {bird1.TypeOfFeathers}.");
            Console.WriteLine($"The type of bird is {bird1.BirdType}.");
            Console.WriteLine($"The number of legs is {bird1.NumberOfLegs}.");
            Console.WriteLine($"The size of the bird is {bird1.Size}.");
            Console.WriteLine($"The habitat of the bird is {bird1.Habitat}.");
            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            Reptile reptile1 = new Reptile();
            reptile1.Species = "reptile";
            reptile1.Size = "small";
            reptile1.Speed = "fast";
            reptile1.TextureOfScales = "smooth";
            reptile1.Age = 3;
            reptile1.NumberOfLegs = 4;
            reptile1.HasTail = "Yes";
            reptile1.Color = "green";
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"The species of the animal is {reptile1.Species}.");
            Console.WriteLine($"The size of the reptile is {reptile1.Size}.");
            Console.WriteLine($"The speed of the reptile is {reptile1.Speed}.");
            Console.WriteLine($"The texture of scales are {reptile1.TextureOfScales}.");
            Console.WriteLine($"The age of the reptile is {reptile1.Age}.");
            Console.WriteLine($"The number of legs is {reptile1.NumberOfLegs}.");
            Console.WriteLine($"Does the reptile have a tail? {reptile1.HasTail}.");
            Console.WriteLine($"The color of the reptile is {reptile1.Color}.");
        }
    }
}
