using System;
using System.Collections.Generic;

namespace Homework5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> list = new List<Animal>();
            Parrot parrot = new Parrot()
            {
                Name = "Kesha",
                Weight = 2,
                Age = 3,
                Speed = 15,
                TimeOfFly = 30,
            };
            list.Add(parrot);
            Wolf wolf = new Wolf()
            {
                Name = "Gray",
                Weight = 35,
                Age = 5,
                Speed = 40,
                TimeOfRun = 50,
            };
            list.Add(wolf);
            Dolphin dolphin = new Dolphin()
            {
                Name = "Wave",
                Weight = 75,
                Age = 7,
                Speed = 75,
                TimeOfSwim = 120,
            };
            list.Add(dolphin);

            Console.WriteLine("-----");
            Console.WriteLine("Parrot: {0}", parrot.Name);
            Console.Write("Type of move: ");
            parrot.Move();
            Console.Write("Type of sound: ");
            parrot.Sound();
            Console.WriteLine("Age: {0}", parrot.Age);

            Console.WriteLine("-----");
            Console.WriteLine("Wolf: {0}", wolf.Name);
            Console.Write("Type of move: ");
            wolf.Move();
            Console.Write("Type of sound: ");
            wolf.Sound();
            Console.WriteLine("Age: {0}", wolf.Age);

            Console.WriteLine("-----");
            Console.WriteLine("Dolphin: {0}", dolphin.Name);
            Console.Write("Type of move: ");
            dolphin.Move();
            Console.Write("Type of sound: ");
            dolphin.Sound();
            Console.WriteLine("Age: {0}", dolphin.Age);
            
            Console.ReadKey();
        }
    }
}
