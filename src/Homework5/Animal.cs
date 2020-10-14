using System;
using System.Collections.Generic;
using System.Text;

namespace Homework5
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public int Age { get; set; }
        public virtual void Move()
        {
            Console.WriteLine("Some move");
        }
        public virtual void Sound() 
        {
            Console.WriteLine("Some sound");
        }
    }
}
