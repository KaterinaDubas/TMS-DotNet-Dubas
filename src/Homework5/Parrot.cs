using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Homework5
{
    class Parrot : Animal, IFly
    {
        public Parrot()
        {
            Console.WriteLine("New Parrot in Zoo");
        }
        public double Speed { get; set; }
        public double TimeOfFly { get; set; }
        public override void Move()
        {
            Console.WriteLine("Can Fly");
        }
        public override void Sound()
        {
            Console.WriteLine("Car");
        }
    }
}
