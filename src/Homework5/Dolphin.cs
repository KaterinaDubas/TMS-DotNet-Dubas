using System;
using System.Collections.Generic;
using System.Text;

namespace Homework5
{
    class Dolphin : Animal, ISwim
    {
        public Dolphin()
        {
            Console.WriteLine("New dolphin in Zoo");
        }
        public double Speed { get; set; }
        public double TimeOfSwim { get; set; }
        public override void Move()
        {
            Console.WriteLine("Can swim");
        }
        public override void Sound()
        {
            Console.WriteLine("KiKiKi");
        }
    }
}
