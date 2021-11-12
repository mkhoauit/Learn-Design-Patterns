using LearnIterator2.Classes;
using System;

namespace LearnIterator2
{
    class Program
    {
        static void Main(string[] args)
        {
            Zoo zoo = new Zoo();

            zoo.AddMammal("Whale");
            zoo.AddMammal("Rhinoceros");
            zoo.AddBird("Penguin");
            zoo.AddBird("Warbler");

            Console.WriteLine("Your zoo have: ");
            foreach (string name in zoo)
            {
                Console.Write($"| {name} | ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Choose a number [1 or 2 or another number to skip]:");
            Console.WriteLine("1: Add a Mammal");
            Console.WriteLine("2: Add a Bird");
            uint input = Convert.ToUInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                    Console.WriteLine("Input Mammal's Name:");
                    string mammalName = Convert.ToString(Console.ReadLine());
                    zoo.AddMammal(mammalName);
                    break;
                case 2:
                    Console.WriteLine("Input Bird's Name:");
                    string birdName = Convert.ToString(Console.ReadLine());
                    zoo.AddMammal(birdName);
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("Birds");
            foreach (string name in zoo.Birds)
            {
                
                Console.Write($"| {name} | ");
            }
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("Mammals");
            foreach (string name in zoo.Mammals)
            {
                
                Console.Write($"| {name} | ");
            }
            Console.WriteLine();
       
        }
    }
}
