using System;
using System.Collections.Generic;
using System.Text;

namespace Homework5
{
    class Wolf : Animal, IRun
    {
        public Wolf()
        {
            Console.WriteLine("New wolf in Zoo");
        }
        public double Speed { get; set; }
        public double TimeOfRun { get; set; }
        public override void Move()
        {
            Console.WriteLine("Can run");
        }
        public override void Sound()
        {
            Console.WriteLine("WWWW");
        }
    }
}
